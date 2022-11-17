
namespace VolumetricApp
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CameraWorker = new System.ComponentModel.BackgroundWorker();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.cbHandShake = new System.Windows.Forms.ComboBox();
            this.lblHandShake = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cbDataSize = new System.Windows.Forms.ComboBox();
            this.lblDataSize = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblBuadRate = new System.Windows.Forms.Label();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.btConnectControl = new System.Windows.Forms.Button();
            this.tbRecvMessage = new System.Windows.Forms.TextBox();
            this.lblRecvMessage = new System.Windows.Forms.Label();
            this.btnBox = new System.Windows.Forms.Button();
            this.tbBoxWidth = new System.Windows.Forms.TextBox();
            this.lblBoxX = new System.Windows.Forms.Label();
            this.lblBoxZ = new System.Windows.Forms.Label();
            this.lblBoxY = new System.Windows.Forms.Label();
            this.lblBoxArea = new System.Windows.Forms.Label();
            this.lblBoxVolume = new System.Windows.Forms.Label();
            this.tbBoxHeight = new System.Windows.Forms.TextBox();
            this.tbBoxDepth = new System.Windows.Forms.TextBox();
            this.tbBoxArea = new System.Windows.Forms.TextBox();
            this.tbBoxVolume = new System.Windows.Forms.TextBox();
            this.lblCamDistance = new System.Windows.Forms.Label();
            this.tbCamDistance = new System.Windows.Forms.TextBox();
            this.cbCamList = new System.Windows.Forms.ComboBox();
            this.lblCamList = new System.Windows.Forms.Label();
            this.btnCamStart = new System.Windows.Forms.Button();
            this.btnCalibration = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.pbCalibration = new System.Windows.Forms.PictureBox();
            this.tbCapImg = new System.Windows.Forms.TextBox();
            this.btnCalbStart = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbThres1 = new System.Windows.Forms.TextBox();
            this.tbThres2 = new System.Windows.Forms.TextBox();
            this.tbApeture = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalibration)).BeginInit();
            this.SuspendLayout();
            // 
            // CameraWorker
            // 
            this.CameraWorker.WorkerReportsProgress = true;
            this.CameraWorker.WorkerSupportsCancellation = true;
            this.CameraWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CameraWorker_DoWork);
            this.CameraWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.CameraWorker_ProgressChanged);
            // 
            // pbCamera
            // 
            this.pbCamera.Location = new System.Drawing.Point(12, 12);
            this.pbCamera.Margin = new System.Windows.Forms.Padding(2);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(520, 325);
            this.pbCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCamera.TabIndex = 0;
            this.pbCamera.TabStop = false;
            // 
            // cbHandShake
            // 
            this.cbHandShake.FormattingEnabled = true;
            this.cbHandShake.Items.AddRange(new object[] {
            "none",
            "Xon/Xoff",
            "request to send",
            "request to send Xon/Xoff"});
            this.cbHandShake.Location = new System.Drawing.Point(724, 484);
            this.cbHandShake.Margin = new System.Windows.Forms.Padding(4);
            this.cbHandShake.Name = "cbHandShake";
            this.cbHandShake.Size = new System.Drawing.Size(128, 26);
            this.cbHandShake.TabIndex = 12;
            // 
            // lblHandShake
            // 
            this.lblHandShake.AutoSize = true;
            this.lblHandShake.Location = new System.Drawing.Point(617, 486);
            this.lblHandShake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHandShake.Name = "lblHandShake";
            this.lblHandShake.Size = new System.Drawing.Size(98, 18);
            this.lblHandShake.TabIndex = 7;
            this.lblHandShake.Text = "Handshake";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "none",
            "even",
            "mark",
            "odd",
            "space"});
            this.cbParity.Location = new System.Drawing.Point(724, 448);
            this.cbParity.Margin = new System.Windows.Forms.Padding(4);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(128, 26);
            this.cbParity.TabIndex = 13;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(617, 450);
            this.lblParity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(53, 18);
            this.lblParity.TabIndex = 8;
            this.lblParity.Text = "Parity";
            // 
            // cbDataSize
            // 
            this.cbDataSize.FormattingEnabled = true;
            this.cbDataSize.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.cbDataSize.Location = new System.Drawing.Point(724, 413);
            this.cbDataSize.Margin = new System.Windows.Forms.Padding(4);
            this.cbDataSize.Name = "cbDataSize";
            this.cbDataSize.Size = new System.Drawing.Size(128, 26);
            this.cbDataSize.TabIndex = 14;
            // 
            // lblDataSize
            // 
            this.lblDataSize.AutoSize = true;
            this.lblDataSize.Location = new System.Drawing.Point(617, 417);
            this.lblDataSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataSize.Name = "lblDataSize";
            this.lblDataSize.Size = new System.Drawing.Size(83, 18);
            this.lblDataSize.TabIndex = 9;
            this.lblDataSize.Text = "Data Size";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "921600",
            "115200",
            "19200",
            "38400",
            "57600",
            "9600"});
            this.cbBaudRate.Location = new System.Drawing.Point(724, 380);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(128, 26);
            this.cbBaudRate.TabIndex = 15;
            // 
            // lblBuadRate
            // 
            this.lblBuadRate.AutoSize = true;
            this.lblBuadRate.Location = new System.Drawing.Point(617, 382);
            this.lblBuadRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuadRate.Name = "lblBuadRate";
            this.lblBuadRate.Size = new System.Drawing.Size(91, 18);
            this.lblBuadRate.TabIndex = 10;
            this.lblBuadRate.Text = "Baud Rate";
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(724, 345);
            this.cbComPort.Margin = new System.Windows.Forms.Padding(4);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(128, 26);
            this.cbComPort.TabIndex = 16;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(617, 348);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(41, 18);
            this.lblPort.TabIndex = 11;
            this.lblPort.Text = "Port";
            // 
            // btConnectControl
            // 
            this.btConnectControl.Location = new System.Drawing.Point(548, 292);
            this.btConnectControl.Margin = new System.Windows.Forms.Padding(4);
            this.btConnectControl.Name = "btConnectControl";
            this.btConnectControl.Size = new System.Drawing.Size(301, 45);
            this.btConnectControl.TabIndex = 17;
            this.btConnectControl.Text = "Connect";
            this.btConnectControl.UseVisualStyleBackColor = true;
            this.btConnectControl.Click += new System.EventHandler(this.btConnectControl_Click);
            // 
            // tbRecvMessage
            // 
            this.tbRecvMessage.Location = new System.Drawing.Point(13, 375);
            this.tbRecvMessage.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecvMessage.Multiline = true;
            this.tbRecvMessage.Name = "tbRecvMessage";
            this.tbRecvMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbRecvMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRecvMessage.Size = new System.Drawing.Size(584, 135);
            this.tbRecvMessage.TabIndex = 19;
            // 
            // lblRecvMessage
            // 
            this.lblRecvMessage.AutoSize = true;
            this.lblRecvMessage.Location = new System.Drawing.Point(9, 348);
            this.lblRecvMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecvMessage.Name = "lblRecvMessage";
            this.lblRecvMessage.Size = new System.Drawing.Size(147, 18);
            this.lblRecvMessage.TabIndex = 18;
            this.lblRecvMessage.Text = "ReceiveMessage";
            // 
            // btnBox
            // 
            this.btnBox.Location = new System.Drawing.Point(548, 74);
            this.btnBox.Margin = new System.Windows.Forms.Padding(4);
            this.btnBox.Name = "btnBox";
            this.btnBox.Size = new System.Drawing.Size(84, 207);
            this.btnBox.TabIndex = 20;
            this.btnBox.Text = "Volume";
            this.btnBox.UseVisualStyleBackColor = true;
            this.btnBox.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // tbBoxWidth
            // 
            this.tbBoxWidth.Location = new System.Drawing.Point(766, 74);
            this.tbBoxWidth.Margin = new System.Windows.Forms.Padding(4);
            this.tbBoxWidth.Name = "tbBoxWidth";
            this.tbBoxWidth.ReadOnly = true;
            this.tbBoxWidth.Size = new System.Drawing.Size(83, 28);
            this.tbBoxWidth.TabIndex = 21;
            // 
            // lblBoxX
            // 
            this.lblBoxX.AutoSize = true;
            this.lblBoxX.Location = new System.Drawing.Point(648, 78);
            this.lblBoxX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoxX.Name = "lblBoxX";
            this.lblBoxX.Size = new System.Drawing.Size(89, 18);
            this.lblBoxX.TabIndex = 18;
            this.lblBoxX.Text = "Box Width";
            // 
            // lblBoxZ
            // 
            this.lblBoxZ.AutoSize = true;
            this.lblBoxZ.Location = new System.Drawing.Point(648, 148);
            this.lblBoxZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoxZ.Name = "lblBoxZ";
            this.lblBoxZ.Size = new System.Drawing.Size(92, 18);
            this.lblBoxZ.TabIndex = 18;
            this.lblBoxZ.Text = "Box Depth";
            // 
            // lblBoxY
            // 
            this.lblBoxY.AutoSize = true;
            this.lblBoxY.Location = new System.Drawing.Point(648, 114);
            this.lblBoxY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoxY.Name = "lblBoxY";
            this.lblBoxY.Size = new System.Drawing.Size(95, 18);
            this.lblBoxY.TabIndex = 18;
            this.lblBoxY.Text = "Box Heigth";
            // 
            // lblBoxArea
            // 
            this.lblBoxArea.AutoSize = true;
            this.lblBoxArea.Location = new System.Drawing.Point(647, 183);
            this.lblBoxArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoxArea.Name = "lblBoxArea";
            this.lblBoxArea.Size = new System.Drawing.Size(84, 18);
            this.lblBoxArea.TabIndex = 18;
            this.lblBoxArea.Text = "Box Area";
            // 
            // lblBoxVolume
            // 
            this.lblBoxVolume.AutoSize = true;
            this.lblBoxVolume.Location = new System.Drawing.Point(648, 220);
            this.lblBoxVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoxVolume.Name = "lblBoxVolume";
            this.lblBoxVolume.Size = new System.Drawing.Size(106, 18);
            this.lblBoxVolume.TabIndex = 18;
            this.lblBoxVolume.Text = "Box Volume";
            // 
            // tbBoxHeight
            // 
            this.tbBoxHeight.Location = new System.Drawing.Point(766, 110);
            this.tbBoxHeight.Margin = new System.Windows.Forms.Padding(4);
            this.tbBoxHeight.Name = "tbBoxHeight";
            this.tbBoxHeight.ReadOnly = true;
            this.tbBoxHeight.Size = new System.Drawing.Size(83, 28);
            this.tbBoxHeight.TabIndex = 21;
            // 
            // tbBoxDepth
            // 
            this.tbBoxDepth.Location = new System.Drawing.Point(767, 145);
            this.tbBoxDepth.Margin = new System.Windows.Forms.Padding(4);
            this.tbBoxDepth.Name = "tbBoxDepth";
            this.tbBoxDepth.ReadOnly = true;
            this.tbBoxDepth.Size = new System.Drawing.Size(83, 28);
            this.tbBoxDepth.TabIndex = 21;
            // 
            // tbBoxArea
            // 
            this.tbBoxArea.Location = new System.Drawing.Point(767, 180);
            this.tbBoxArea.Margin = new System.Windows.Forms.Padding(4);
            this.tbBoxArea.Name = "tbBoxArea";
            this.tbBoxArea.ReadOnly = true;
            this.tbBoxArea.Size = new System.Drawing.Size(83, 28);
            this.tbBoxArea.TabIndex = 21;
            // 
            // tbBoxVolume
            // 
            this.tbBoxVolume.Location = new System.Drawing.Point(767, 217);
            this.tbBoxVolume.Margin = new System.Windows.Forms.Padding(4);
            this.tbBoxVolume.Name = "tbBoxVolume";
            this.tbBoxVolume.ReadOnly = true;
            this.tbBoxVolume.Size = new System.Drawing.Size(83, 28);
            this.tbBoxVolume.TabIndex = 21;
            // 
            // lblCamDistance
            // 
            this.lblCamDistance.AutoSize = true;
            this.lblCamDistance.Location = new System.Drawing.Point(648, 256);
            this.lblCamDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCamDistance.Name = "lblCamDistance";
            this.lblCamDistance.Size = new System.Drawing.Size(77, 18);
            this.lblCamDistance.TabIndex = 18;
            this.lblCamDistance.Text = "Distance";
            // 
            // tbCamDistance
            // 
            this.tbCamDistance.Location = new System.Drawing.Point(767, 253);
            this.tbCamDistance.Margin = new System.Windows.Forms.Padding(4);
            this.tbCamDistance.Name = "tbCamDistance";
            this.tbCamDistance.ReadOnly = true;
            this.tbCamDistance.Size = new System.Drawing.Size(83, 28);
            this.tbCamDistance.TabIndex = 21;
            // 
            // cbCamList
            // 
            this.cbCamList.FormattingEnabled = true;
            this.cbCamList.Location = new System.Drawing.Point(548, 35);
            this.cbCamList.Name = "cbCamList";
            this.cbCamList.Size = new System.Drawing.Size(121, 26);
            this.cbCamList.TabIndex = 22;
            // 
            // lblCamList
            // 
            this.lblCamList.AutoSize = true;
            this.lblCamList.Location = new System.Drawing.Point(545, 9);
            this.lblCamList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCamList.Name = "lblCamList";
            this.lblCamList.Size = new System.Drawing.Size(104, 18);
            this.lblCamList.TabIndex = 18;
            this.lblCamList.Text = "Camera List";
            // 
            // btnCamStart
            // 
            this.btnCamStart.Location = new System.Drawing.Point(682, 12);
            this.btnCamStart.Name = "btnCamStart";
            this.btnCamStart.Size = new System.Drawing.Size(168, 49);
            this.btnCamStart.TabIndex = 23;
            this.btnCamStart.Text = "Cam Start";
            this.btnCamStart.UseVisualStyleBackColor = true;
            this.btnCamStart.Click += new System.EventHandler(this.btnCamStart_Click);
            // 
            // btnCalibration
            // 
            this.btnCalibration.Location = new System.Drawing.Point(1257, 9);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.Size = new System.Drawing.Size(133, 40);
            this.btnCalibration.TabIndex = 24;
            this.btnCalibration.Text = "Calibration";
            this.btnCalibration.UseVisualStyleBackColor = true;
            this.btnCalibration.Click += new System.EventHandler(this.btnCalibration_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(1009, 12);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(86, 37);
            this.btnCapture.TabIndex = 25;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // pbCalibration
            // 
            this.pbCalibration.Location = new System.Drawing.Point(870, 57);
            this.pbCalibration.Margin = new System.Windows.Forms.Padding(2);
            this.pbCalibration.Name = "pbCalibration";
            this.pbCalibration.Size = new System.Drawing.Size(520, 325);
            this.pbCalibration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCalibration.TabIndex = 0;
            this.pbCalibration.TabStop = false;
            // 
            // tbCapImg
            // 
            this.tbCapImg.Location = new System.Drawing.Point(1102, 18);
            this.tbCapImg.Margin = new System.Windows.Forms.Padding(4);
            this.tbCapImg.Name = "tbCapImg";
            this.tbCapImg.ReadOnly = true;
            this.tbCapImg.Size = new System.Drawing.Size(83, 28);
            this.tbCapImg.TabIndex = 21;
            // 
            // btnCalbStart
            // 
            this.btnCalbStart.Location = new System.Drawing.Point(870, 12);
            this.btnCalbStart.Name = "btnCalbStart";
            this.btnCalbStart.Size = new System.Drawing.Size(133, 37);
            this.btnCalbStart.TabIndex = 26;
            this.btnCalbStart.Text = "Calib Start";
            this.btnCalbStart.UseVisualStyleBackColor = true;
            this.btnCalbStart.Click += new System.EventHandler(this.btnCalbStart_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbThres1
            // 
            this.tbThres1.Location = new System.Drawing.Point(870, 387);
            this.tbThres1.Name = "tbThres1";
            this.tbThres1.Size = new System.Drawing.Size(100, 28);
            this.tbThres1.TabIndex = 27;
            this.tbThres1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbThres1_KeyPress);
            // 
            // tbThres2
            // 
            this.tbThres2.Location = new System.Drawing.Point(870, 438);
            this.tbThres2.Name = "tbThres2";
            this.tbThres2.Size = new System.Drawing.Size(100, 28);
            this.tbThres2.TabIndex = 27;
            this.tbThres2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbThres2_KeyPress);
            // 
            // tbApeture
            // 
            this.tbApeture.Location = new System.Drawing.Point(870, 484);
            this.tbApeture.Name = "tbApeture";
            this.tbApeture.Size = new System.Drawing.Size(100, 28);
            this.tbApeture.TabIndex = 27;
            this.tbApeture.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApeture_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 527);
            this.Controls.Add(this.tbApeture);
            this.Controls.Add(this.tbThres2);
            this.Controls.Add(this.tbThres1);
            this.Controls.Add(this.btnCalbStart);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.btnCalibration);
            this.Controls.Add(this.btnCamStart);
            this.Controls.Add(this.cbCamList);
            this.Controls.Add(this.tbCamDistance);
            this.Controls.Add(this.tbBoxVolume);
            this.Controls.Add(this.tbBoxArea);
            this.Controls.Add(this.tbBoxDepth);
            this.Controls.Add(this.tbBoxHeight);
            this.Controls.Add(this.tbCapImg);
            this.Controls.Add(this.tbBoxWidth);
            this.Controls.Add(this.btnBox);
            this.Controls.Add(this.tbRecvMessage);
            this.Controls.Add(this.lblCamDistance);
            this.Controls.Add(this.lblBoxY);
            this.Controls.Add(this.lblBoxVolume);
            this.Controls.Add(this.lblBoxArea);
            this.Controls.Add(this.lblBoxZ);
            this.Controls.Add(this.lblCamList);
            this.Controls.Add(this.lblBoxX);
            this.Controls.Add(this.lblRecvMessage);
            this.Controls.Add(this.btConnectControl);
            this.Controls.Add(this.cbHandShake);
            this.Controls.Add(this.lblHandShake);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.lblParity);
            this.Controls.Add(this.cbDataSize);
            this.Controls.Add(this.lblDataSize);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.lblBuadRate);
            this.Controls.Add(this.cbComPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.pbCalibration);
            this.Controls.Add(this.pbCamera);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Volumetric";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalibration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker CameraWorker;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.ComboBox cbHandShake;
        private System.Windows.Forms.Label lblHandShake;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox cbDataSize;
        private System.Windows.Forms.Label lblDataSize;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label lblBuadRate;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btConnectControl;
        private System.Windows.Forms.TextBox tbRecvMessage;
        private System.Windows.Forms.Label lblRecvMessage;
        private System.Windows.Forms.Button btnBox;
        private System.Windows.Forms.TextBox tbBoxWidth;
        private System.Windows.Forms.Label lblBoxX;
        public System.Windows.Forms.Label lblBoxZ;
        private System.Windows.Forms.Label lblBoxY;
        public System.Windows.Forms.Label lblBoxArea;
        public System.Windows.Forms.Label lblBoxVolume;
        private System.Windows.Forms.TextBox tbBoxHeight;
        private System.Windows.Forms.TextBox tbBoxDepth;
        private System.Windows.Forms.TextBox tbBoxArea;
        private System.Windows.Forms.TextBox tbBoxVolume;
        public System.Windows.Forms.Label lblCamDistance;
        private System.Windows.Forms.TextBox tbCamDistance;
        private System.Windows.Forms.ComboBox cbCamList;
        private System.Windows.Forms.Label lblCamList;
        private System.Windows.Forms.Button btnCamStart;
        private System.Windows.Forms.Button btnCalibration;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.PictureBox pbCalibration;
        private System.Windows.Forms.TextBox tbCapImg;
        private System.Windows.Forms.Button btnCalbStart;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbThres1;
        private System.Windows.Forms.TextBox tbThres2;
        private System.Windows.Forms.TextBox tbApeture;
    }
}

