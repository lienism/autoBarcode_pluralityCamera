namespace plurality_Camera
{
    partial class plurality_Camera
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Camera3_Barcode_Label = new System.Windows.Forms.Label();
            this.Camera3_barcode_navi = new System.Windows.Forms.Label();
            this.Camera3_Barcode_Mode = new System.Windows.Forms.CheckBox();
            this.camera3FpsLabel = new System.Windows.Forms.Label();
            this.Camera3_drawContour = new System.Windows.Forms.CheckBox();
            this.Camera3_RGB = new System.Windows.Forms.CheckBox();
            this.camera3Combo = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer3 = new AForge.Controls.VideoSourcePlayer();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Camera2_Barcode_Label = new System.Windows.Forms.Label();
            this.Camera2_barcode_navi = new System.Windows.Forms.Label();
            this.Camera2_Barcode_Mode = new System.Windows.Forms.CheckBox();
            this.camera2FpsLabel = new System.Windows.Forms.Label();
            this.Camera2_drawContour = new System.Windows.Forms.CheckBox();
            this.Camera2_RGB = new System.Windows.Forms.CheckBox();
            this.camera2Combo = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer2 = new AForge.Controls.VideoSourcePlayer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Camera1_Barcode_Label = new System.Windows.Forms.Label();
            this.Camera1_barcode_navi = new System.Windows.Forms.Label();
            this.Camera1_Barcode_Mode = new System.Windows.Forms.CheckBox();
            this.Camera1_drawContour = new System.Windows.Forms.CheckBox();
            this.Camera1_RGB = new System.Windows.Forms.CheckBox();
            this.camera1FpsLabel = new System.Windows.Forms.Label();
            this.camera1Combo = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Camera3_Barcode_Label);
            this.groupBox3.Controls.Add(this.Camera3_barcode_navi);
            this.groupBox3.Controls.Add(this.Camera3_Barcode_Mode);
            this.groupBox3.Controls.Add(this.camera3FpsLabel);
            this.groupBox3.Controls.Add(this.Camera3_drawContour);
            this.groupBox3.Controls.Add(this.Camera3_RGB);
            this.groupBox3.Controls.Add(this.camera3Combo);
            this.groupBox3.Controls.Add(this.videoSourcePlayer3);
            this.groupBox3.Location = new System.Drawing.Point(392, 372);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 319);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera 3";
            // 
            // Camera3_Barcode_Label
            // 
            this.Camera3_Barcode_Label.AutoSize = true;
            this.Camera3_Barcode_Label.Location = new System.Drawing.Point(101, 292);
            this.Camera3_Barcode_Label.Name = "Camera3_Barcode_Label";
            this.Camera3_Barcode_Label.Size = new System.Drawing.Size(35, 12);
            this.Camera3_Barcode_Label.TabIndex = 20;
            this.Camera3_Barcode_Label.Text = "label1";
            // 
            // Camera3_barcode_navi
            // 
            this.Camera3_barcode_navi.AutoSize = true;
            this.Camera3_barcode_navi.Location = new System.Drawing.Point(38, 292);
            this.Camera3_barcode_navi.Name = "Camera3_barcode_navi";
            this.Camera3_barcode_navi.Size = new System.Drawing.Size(57, 12);
            this.Camera3_barcode_navi.TabIndex = 13;
            this.Camera3_barcode_navi.Text = "Barcode : ";
            // 
            // Camera3_Barcode_Mode
            // 
            this.Camera3_Barcode_Mode.AutoSize = true;
            this.Camera3_Barcode_Mode.Location = new System.Drawing.Point(178, 273);
            this.Camera3_Barcode_Mode.Name = "Camera3_Barcode_Mode";
            this.Camera3_Barcode_Mode.Size = new System.Drawing.Size(118, 16);
            this.Camera3_Barcode_Mode.TabIndex = 14;
            this.Camera3_Barcode_Mode.Text = "Barcode_recognize";
            this.Camera3_Barcode_Mode.UseVisualStyleBackColor = true;
            // 
            // camera3FpsLabel
            // 
            this.camera3FpsLabel.Location = new System.Drawing.Point(282, 270);
            this.camera3FpsLabel.Name = "camera3FpsLabel";
            this.camera3FpsLabel.Size = new System.Drawing.Size(50, 16);
            this.camera3FpsLabel.TabIndex = 4;
            this.camera3FpsLabel.Text = "label1";
            this.camera3FpsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Camera3_drawContour
            // 
            this.Camera3_drawContour.AutoSize = true;
            this.Camera3_drawContour.Location = new System.Drawing.Point(92, 273);
            this.Camera3_drawContour.Name = "Camera3_drawContour";
            this.Camera3_drawContour.Size = new System.Drawing.Size(88, 16);
            this.Camera3_drawContour.TabIndex = 13;
            this.Camera3_drawContour.Text = "drawContour";
            this.Camera3_drawContour.UseVisualStyleBackColor = true;
            // 
            // Camera3_RGB
            // 
            this.Camera3_RGB.AutoSize = true;
            this.Camera3_RGB.Location = new System.Drawing.Point(6, 273);
            this.Camera3_RGB.Name = "Camera3_RGB";
            this.Camera3_RGB.Size = new System.Drawing.Size(89, 16);
            this.Camera3_RGB.TabIndex = 12;
            this.Camera3_RGB.Text = "RGBProcess";
            this.Camera3_RGB.UseVisualStyleBackColor = true;
            // 
            // camera3Combo
            // 
            this.camera3Combo.FormattingEnabled = true;
            this.camera3Combo.Location = new System.Drawing.Point(10, 18);
            this.camera3Combo.Name = "camera3Combo";
            this.camera3Combo.Size = new System.Drawing.Size(322, 20);
            this.camera3Combo.TabIndex = 3;
            // 
            // videoSourcePlayer3
            // 
            this.videoSourcePlayer3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.videoSourcePlayer3.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer3.Location = new System.Drawing.Point(10, 44);
            this.videoSourcePlayer3.Name = "videoSourcePlayer3";
            this.videoSourcePlayer3.Size = new System.Drawing.Size(322, 223);
            this.videoSourcePlayer3.TabIndex = 0;
            this.videoSourcePlayer3.VideoSource = null;
            this.videoSourcePlayer3.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer3_NewFrame);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(392, 336);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 21);
            this.stopButton.TabIndex = 15;
            this.stopButton.Text = "S&top";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(292, 336);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 21);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "&Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Camera2_Barcode_Label);
            this.groupBox2.Controls.Add(this.Camera2_barcode_navi);
            this.groupBox2.Controls.Add(this.Camera2_Barcode_Mode);
            this.groupBox2.Controls.Add(this.camera2FpsLabel);
            this.groupBox2.Controls.Add(this.Camera2_drawContour);
            this.groupBox2.Controls.Add(this.Camera2_RGB);
            this.groupBox2.Controls.Add(this.camera2Combo);
            this.groupBox2.Controls.Add(this.videoSourcePlayer2);
            this.groupBox2.Location = new System.Drawing.Point(25, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 318);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera 2";
            // 
            // Camera2_Barcode_Label
            // 
            this.Camera2_Barcode_Label.AutoSize = true;
            this.Camera2_Barcode_Label.Location = new System.Drawing.Point(102, 292);
            this.Camera2_Barcode_Label.Name = "Camera2_Barcode_Label";
            this.Camera2_Barcode_Label.Size = new System.Drawing.Size(35, 12);
            this.Camera2_Barcode_Label.TabIndex = 19;
            this.Camera2_Barcode_Label.Text = "label1";
            // 
            // Camera2_barcode_navi
            // 
            this.Camera2_barcode_navi.AutoSize = true;
            this.Camera2_barcode_navi.Location = new System.Drawing.Point(39, 292);
            this.Camera2_barcode_navi.Name = "Camera2_barcode_navi";
            this.Camera2_barcode_navi.Size = new System.Drawing.Size(57, 12);
            this.Camera2_barcode_navi.TabIndex = 13;
            this.Camera2_barcode_navi.Text = "Barcode : ";
            // 
            // Camera2_Barcode_Mode
            // 
            this.Camera2_Barcode_Mode.AutoSize = true;
            this.Camera2_Barcode_Mode.Location = new System.Drawing.Point(179, 272);
            this.Camera2_Barcode_Mode.Name = "Camera2_Barcode_Mode";
            this.Camera2_Barcode_Mode.Size = new System.Drawing.Size(118, 16);
            this.Camera2_Barcode_Mode.TabIndex = 10;
            this.Camera2_Barcode_Mode.Text = "Barcode_recognize";
            this.Camera2_Barcode_Mode.UseVisualStyleBackColor = true;
            // 
            // camera2FpsLabel
            // 
            this.camera2FpsLabel.Location = new System.Drawing.Point(282, 273);
            this.camera2FpsLabel.Name = "camera2FpsLabel";
            this.camera2FpsLabel.Size = new System.Drawing.Size(50, 16);
            this.camera2FpsLabel.TabIndex = 5;
            this.camera2FpsLabel.Text = "label2";
            this.camera2FpsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Camera2_drawContour
            // 
            this.Camera2_drawContour.AutoSize = true;
            this.Camera2_drawContour.Location = new System.Drawing.Point(93, 272);
            this.Camera2_drawContour.Name = "Camera2_drawContour";
            this.Camera2_drawContour.Size = new System.Drawing.Size(88, 16);
            this.Camera2_drawContour.TabIndex = 9;
            this.Camera2_drawContour.Text = "drawContour";
            this.Camera2_drawContour.UseVisualStyleBackColor = true;
            // 
            // Camera2_RGB
            // 
            this.Camera2_RGB.AutoSize = true;
            this.Camera2_RGB.Location = new System.Drawing.Point(7, 272);
            this.Camera2_RGB.Name = "Camera2_RGB";
            this.Camera2_RGB.Size = new System.Drawing.Size(89, 16);
            this.Camera2_RGB.TabIndex = 8;
            this.Camera2_RGB.Text = "RGBProcess";
            this.Camera2_RGB.UseVisualStyleBackColor = true;
            // 
            // camera2Combo
            // 
            this.camera2Combo.FormattingEnabled = true;
            this.camera2Combo.Location = new System.Drawing.Point(10, 18);
            this.camera2Combo.Name = "camera2Combo";
            this.camera2Combo.Size = new System.Drawing.Size(322, 20);
            this.camera2Combo.TabIndex = 2;
            // 
            // videoSourcePlayer2
            // 
            this.videoSourcePlayer2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.videoSourcePlayer2.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer2.Location = new System.Drawing.Point(10, 46);
            this.videoSourcePlayer2.Name = "videoSourcePlayer2";
            this.videoSourcePlayer2.Size = new System.Drawing.Size(322, 223);
            this.videoSourcePlayer2.TabIndex = 1;
            this.videoSourcePlayer2.VideoSource = null;
            this.videoSourcePlayer2.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer2_NewFrame);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Camera1_Barcode_Label);
            this.groupBox1.Controls.Add(this.Camera1_barcode_navi);
            this.groupBox1.Controls.Add(this.Camera1_Barcode_Mode);
            this.groupBox1.Controls.Add(this.Camera1_drawContour);
            this.groupBox1.Controls.Add(this.Camera1_RGB);
            this.groupBox1.Controls.Add(this.camera1FpsLabel);
            this.groupBox1.Controls.Add(this.camera1Combo);
            this.groupBox1.Controls.Add(this.videoSourcePlayer1);
            this.groupBox1.Location = new System.Drawing.Point(186, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 318);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera 1";
            // 
            // Camera1_Barcode_Label
            // 
            this.Camera1_Barcode_Label.AutoSize = true;
            this.Camera1_Barcode_Label.Location = new System.Drawing.Point(101, 292);
            this.Camera1_Barcode_Label.Name = "Camera1_Barcode_Label";
            this.Camera1_Barcode_Label.Size = new System.Drawing.Size(35, 12);
            this.Camera1_Barcode_Label.TabIndex = 18;
            this.Camera1_Barcode_Label.Text = "label1";
            // 
            // Camera1_barcode_navi
            // 
            this.Camera1_barcode_navi.AutoSize = true;
            this.Camera1_barcode_navi.Location = new System.Drawing.Point(38, 292);
            this.Camera1_barcode_navi.Name = "Camera1_barcode_navi";
            this.Camera1_barcode_navi.Size = new System.Drawing.Size(57, 12);
            this.Camera1_barcode_navi.TabIndex = 12;
            this.Camera1_barcode_navi.Text = "Barcode : ";
            // 
            // Camera1_Barcode_Mode
            // 
            this.Camera1_Barcode_Mode.AutoSize = true;
            this.Camera1_Barcode_Mode.Location = new System.Drawing.Point(178, 273);
            this.Camera1_Barcode_Mode.Name = "Camera1_Barcode_Mode";
            this.Camera1_Barcode_Mode.Size = new System.Drawing.Size(118, 16);
            this.Camera1_Barcode_Mode.TabIndex = 7;
            this.Camera1_Barcode_Mode.Text = "Barcode_recognize";
            this.Camera1_Barcode_Mode.UseVisualStyleBackColor = true;
            // 
            // Camera1_drawContour
            // 
            this.Camera1_drawContour.AutoSize = true;
            this.Camera1_drawContour.Location = new System.Drawing.Point(92, 273);
            this.Camera1_drawContour.Name = "Camera1_drawContour";
            this.Camera1_drawContour.Size = new System.Drawing.Size(88, 16);
            this.Camera1_drawContour.TabIndex = 6;
            this.Camera1_drawContour.Text = "drawContour";
            this.Camera1_drawContour.UseVisualStyleBackColor = true;
            // 
            // Camera1_RGB
            // 
            this.Camera1_RGB.AutoSize = true;
            this.Camera1_RGB.Location = new System.Drawing.Point(6, 273);
            this.Camera1_RGB.Name = "Camera1_RGB";
            this.Camera1_RGB.Size = new System.Drawing.Size(89, 16);
            this.Camera1_RGB.TabIndex = 5;
            this.Camera1_RGB.Text = "RGBProcess";
            this.Camera1_RGB.UseVisualStyleBackColor = true;
            // 
            // camera1FpsLabel
            // 
            this.camera1FpsLabel.Location = new System.Drawing.Point(282, 274);
            this.camera1FpsLabel.Name = "camera1FpsLabel";
            this.camera1FpsLabel.Size = new System.Drawing.Size(50, 16);
            this.camera1FpsLabel.TabIndex = 4;
            this.camera1FpsLabel.Text = "label1";
            this.camera1FpsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // camera1Combo
            // 
            this.camera1Combo.FormattingEnabled = true;
            this.camera1Combo.Location = new System.Drawing.Point(10, 18);
            this.camera1Combo.Name = "camera1Combo";
            this.camera1Combo.Size = new System.Drawing.Size(322, 20);
            this.camera1Combo.TabIndex = 3;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.videoSourcePlayer1.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(10, 44);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(322, 223);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer1_NewFrame);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // plurality_Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 689);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "plurality_Camera";
            this.Text = "plurality_Camera";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Camera3_Barcode_Label;
        private System.Windows.Forms.Label Camera3_barcode_navi;
        private System.Windows.Forms.CheckBox Camera3_Barcode_Mode;
        private System.Windows.Forms.Label camera3FpsLabel;
        private System.Windows.Forms.CheckBox Camera3_drawContour;
        private System.Windows.Forms.CheckBox Camera3_RGB;
        private System.Windows.Forms.ComboBox camera3Combo;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer3;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Camera2_Barcode_Label;
        private System.Windows.Forms.Label Camera2_barcode_navi;
        private System.Windows.Forms.CheckBox Camera2_Barcode_Mode;
        private System.Windows.Forms.Label camera2FpsLabel;
        private System.Windows.Forms.CheckBox Camera2_drawContour;
        private System.Windows.Forms.CheckBox Camera2_RGB;
        private System.Windows.Forms.ComboBox camera2Combo;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Camera1_Barcode_Label;
        private System.Windows.Forms.Label Camera1_barcode_navi;
        private System.Windows.Forms.CheckBox Camera1_Barcode_Mode;
        private System.Windows.Forms.CheckBox Camera1_drawContour;
        private System.Windows.Forms.CheckBox Camera1_RGB;
        private System.Windows.Forms.Label camera1FpsLabel;
        private System.Windows.Forms.ComboBox camera1Combo;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Timer timer;
    }
}

