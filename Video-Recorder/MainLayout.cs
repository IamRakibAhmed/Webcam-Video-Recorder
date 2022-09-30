using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using DirectShowLib;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using BasicAudio;
using FFMpegCore;

namespace Video_Recorder
{
    public partial class MainLayout : Form
    {
        bool isCameraRunning = false;
        bool isMicrophoneStarted = false;
        bool isAltImgUsing = false;
        Mat frame;
        Bitmap image;
        Bitmap altImage;
        VideoCapture capture;
        VideoWriter outputVideo;
        Recording audioRecording;

        public MainLayout()
        {
            InitializeComponent();
        }

        private void DisposeCamera()
        {
            if (frame != null) frame.Dispose();
            if (image != null) image.Dispose();
            if (altImage != null) altImage.Dispose();
        }

        private void DisposeCapture()
        {
            if (capture != null)
            {
                capture.Release();
                capture.Dispose();
            }
            if (outputVideo != null)
            {
                outputVideo.Release();
                outputVideo.Dispose();
            }
        }

        private void StartCamera()
        {
            DisposeCamera();
            isCameraRunning = true;
            recordBtn.Text = "Stop Recording";
            recordBtn.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(105)))));

            int camIndex = webcamDevicesBox.SelectedIndex;
            capture = new VideoCapture(camIndex);
            capture.Open(camIndex);

            outputVideo = new VideoWriter("video.mp4", FourCC.AVC, 29, new OpenCvSharp.Size(640, 480));
        }

        private void StartMicroPhone()
        {
            audioRecording = new Recording();
            audioRecording.Filename = "audio.wav";
            //isMicrophoneStarted = true;
        }

        private void StopCamera()
        {
            isCameraRunning = false;
            recordBtn.Text = "Start Recording";
            recordBtn.BackColor = Color.Gold;

            timer1.Stop();
            timer1.Enabled = false;
            DisposeCapture();
        }

        private void StopMicroPhone()
        {
            audioRecording.StopRecording();
        }

        private void OutputRecording()
        {
            string outputPath = @"D:\Videos\";

            try
            {
                FFMpeg.ReplaceAudio("video.mp4", "audio.wav", outputPath + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".mp4", true);
                MessageBox.Show("Recording Finished", "Recording has been saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StripStatusLabel.Text = $"Recording saved to {outputPath} with the filename {DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")}.mp4";
            }
            catch (Exception ex)
            {
                StripStatusLabel.Text = "Recording can't be saved.";
                MessageBox.Show($"Recording cannot be saved because {ex.Message}", "Error on Recording Saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void recordBtn_Click(object sender, EventArgs e)
        {
            if (webcamDevicesBox.SelectedIndex < 0)
            {
                MessageBox.Show("Connect Your Webcam Device.", "No Webcam Devices Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!isCameraRunning)
            {
                StripStatusLabel.Text = "Record is starting...";
                StartCamera();
                StartMicroPhone();
                timer1.Enabled = true;
                timer1.Start();
                StripStatusLabel.Text = "Recording on progress...";
            }
            else
            {
                StopCamera();
                StopMicroPhone();
                StripStatusLabel.Text = "Recording finished.";
                OutputRecording();
            }
        }

        private void LoadForm()
        {
            StripStatusLabel.Text = "";
            var videoDevices = new List<DsDevice>(DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice));
            foreach (var device in videoDevices) webcamDevicesBox.Items.Add(device.Name);
        }

        private void MainLayout_Load(object sender, EventArgs e)
        {
            LoadForm();

            /*timer1 = new Timer();
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;*/
        }

        private void frameControl()
        {
            if (capture.IsOpened())
            {
                try
                {
                    frame = new Mat();
                    capture.Read(frame);

                    if (frame != null)
                    {
                        if (altImage == null)
                        {
                            isAltImgUsing = true;
                            altImage = BitmapConverter.ToBitmap(frame);
                        }
                        else if (image == null)
                        {
                            isAltImgUsing = false;
                            image = BitmapConverter.ToBitmap(frame);
                        }

                        recordingScreen.Image = isAltImgUsing ? altImage : image;
                        outputVideo.Write(frame);
                    }
                }
                catch (Exception)
                {
                    recordingScreen.Image = null;
                }
                finally
                {
                    if (frame != null) frame.Dispose();
                    if (isAltImgUsing && image != null)
                    {
                        image.Dispose();
                        image = null;
                    }
                    else if (!isAltImgUsing && altImage != null)
                    {
                        altImage.Dispose();
                        altImage = null;
                    }
                }

                if (isMicrophoneStarted)
                {
                    audioRecording.StartRecording();
                    //isMicrophoneStarted = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frameControl();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            if (isCameraRunning || isMicrophoneStarted || recordBtn.Text == "Stop Recording")
            {
                StopCamera();
                StopMicroPhone();
                StripStatusLabel.Text = "Recording finished.";
                OutputRecording();
            }

            webcamDevicesBox.SelectedIndex = -1;
            recordingScreen.Image = null;
            if (StripStatusLabel.Text != "") StripStatusLabel.Text = "";
        }
    }
}
