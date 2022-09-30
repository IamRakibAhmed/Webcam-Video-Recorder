
namespace Video_Recorder
{
    partial class MainLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLayout));
            this.recordingScreen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webcamDevicesBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.recordBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recordingScreen)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // recordingScreen
            // 
            this.recordingScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
            this.recordingScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recordingScreen.Location = new System.Drawing.Point(14, 14);
            this.recordingScreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.recordingScreen.Name = "recordingScreen";
            this.recordingScreen.Size = new System.Drawing.Size(640, 480);
            this.recordingScreen.TabIndex = 0;
            this.recordingScreen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(10, 539);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Webcam Device";
            // 
            // webcamDevicesBox
            // 
            this.webcamDevicesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.webcamDevicesBox.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.webcamDevicesBox.FormattingEnabled = true;
            this.webcamDevicesBox.Location = new System.Drawing.Point(14, 570);
            this.webcamDevicesBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.webcamDevicesBox.Name = "webcamDevicesBox";
            this.webcamDevicesBox.Size = new System.Drawing.Size(640, 30);
            this.webcamDevicesBox.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(31)))), ((int)(((byte)(71)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.StripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 709);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(668, 27);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // StripStatusLabel
            // 
            this.StripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StripStatusLabel.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StripStatusLabel.ForeColor = System.Drawing.Color.Gold;
            this.StripStatusLabel.Name = "StripStatusLabel";
            this.StripStatusLabel.Size = new System.Drawing.Size(141, 22);
            this.StripStatusLabel.Text = "toolStripStatusLabel2";
            // 
            // recordBtn
            // 
            this.recordBtn.BackColor = System.Drawing.Color.Gold;
            this.recordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.recordBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.recordBtn.Location = new System.Drawing.Point(206, 624);
            this.recordBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(125, 30);
            this.recordBtn.TabIndex = 4;
            this.recordBtn.Text = "Start Recording";
            this.recordBtn.UseVisualStyleBackColor = false;
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 17;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Gold;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetBtn.Location = new System.Drawing.Point(351, 624);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(79, 30);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // MainLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(34)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(668, 736);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.recordBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.webcamDevicesBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recordingScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Recorder";
            this.Load += new System.EventHandler(this.MainLayout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordingScreen)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox recordingScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox webcamDevicesBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button resetBtn;
    }
}

