
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
            this.tbDistance = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
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
            this.pbCamera.Location = new System.Drawing.Point(10, 10);
            this.pbCamera.Margin = new System.Windows.Forms.Padding(2);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(320, 240);
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
            this.cbHandShake.Location = new System.Drawing.Point(95, 375);
            this.cbHandShake.Name = "cbHandShake";
            this.cbHandShake.Size = new System.Drawing.Size(103, 23);
            this.cbHandShake.TabIndex = 12;
            // 
            // lblHandShake
            // 
            this.lblHandShake.AutoSize = true;
            this.lblHandShake.Location = new System.Drawing.Point(10, 377);
            this.lblHandShake.Name = "lblHandShake";
            this.lblHandShake.Size = new System.Drawing.Size(80, 15);
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
            this.cbParity.Location = new System.Drawing.Point(95, 345);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(103, 23);
            this.cbParity.TabIndex = 13;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(10, 347);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(44, 15);
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
            this.cbDataSize.Location = new System.Drawing.Point(95, 316);
            this.cbDataSize.Name = "cbDataSize";
            this.cbDataSize.Size = new System.Drawing.Size(103, 23);
            this.cbDataSize.TabIndex = 14;
            // 
            // lblDataSize
            // 
            this.lblDataSize.AutoSize = true;
            this.lblDataSize.Location = new System.Drawing.Point(10, 319);
            this.lblDataSize.Name = "lblDataSize";
            this.lblDataSize.Size = new System.Drawing.Size(71, 15);
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
            this.cbBaudRate.Location = new System.Drawing.Point(95, 288);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(103, 23);
            this.cbBaudRate.TabIndex = 15;
            // 
            // lblBuadRate
            // 
            this.lblBuadRate.AutoSize = true;
            this.lblBuadRate.Location = new System.Drawing.Point(10, 290);
            this.lblBuadRate.Name = "lblBuadRate";
            this.lblBuadRate.Size = new System.Drawing.Size(76, 15);
            this.lblBuadRate.TabIndex = 10;
            this.lblBuadRate.Text = "Baud Rate";
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(95, 259);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(103, 23);
            this.cbComPort.TabIndex = 16;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(10, 262);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(34, 15);
            this.lblPort.TabIndex = 11;
            this.lblPort.Text = "Port";
            // 
            // btConnectControl
            // 
            this.btConnectControl.Location = new System.Drawing.Point(13, 403);
            this.btConnectControl.Name = "btConnectControl";
            this.btConnectControl.Size = new System.Drawing.Size(185, 28);
            this.btConnectControl.TabIndex = 17;
            this.btConnectControl.Text = "Connect";
            this.btConnectControl.UseVisualStyleBackColor = true;
            this.btConnectControl.Click += new System.EventHandler(this.btConnectControl_Click);
            // 
            // tbRecvMessage
            // 
            this.tbRecvMessage.Location = new System.Drawing.Point(220, 284);
            this.tbRecvMessage.Multiline = true;
            this.tbRecvMessage.Name = "tbRecvMessage";
            this.tbRecvMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbRecvMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRecvMessage.Size = new System.Drawing.Size(359, 149);
            this.tbRecvMessage.TabIndex = 19;
            // 
            // lblRecvMessage
            // 
            this.lblRecvMessage.AutoSize = true;
            this.lblRecvMessage.Location = new System.Drawing.Point(218, 262);
            this.lblRecvMessage.Name = "lblRecvMessage";
            this.lblRecvMessage.Size = new System.Drawing.Size(120, 15);
            this.lblRecvMessage.TabIndex = 18;
            this.lblRecvMessage.Text = "ReceiveMessage";
            // 
            // btnBox
            // 
            this.btnBox.Location = new System.Drawing.Point(335, 12);
            this.btnBox.Name = "btnBox";
            this.btnBox.Size = new System.Drawing.Size(67, 162);
            this.btnBox.TabIndex = 20;
            this.btnBox.Text = "Volume";
            this.btnBox.UseVisualStyleBackColor = true;
            this.btnBox.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // tbBoxWidth
            // 
            this.tbBoxWidth.Location = new System.Drawing.Point(512, 16);
            this.tbBoxWidth.Name = "tbBoxWidth";
            this.tbBoxWidth.ReadOnly = true;
            this.tbBoxWidth.Size = new System.Drawing.Size(67, 25);
            this.tbBoxWidth.TabIndex = 21;
            // 
            // lblBoxX
            // 
            this.lblBoxX.AutoSize = true;
            this.lblBoxX.Location = new System.Drawing.Point(418, 19);
            this.lblBoxX.Name = "lblBoxX";
            this.lblBoxX.Size = new System.Drawing.Size(77, 15);
            this.lblBoxX.TabIndex = 18;
            this.lblBoxX.Text = "Box Width";
            // 
            // lblBoxZ
            // 
            this.lblBoxZ.AutoSize = true;
            this.lblBoxZ.Location = new System.Drawing.Point(417, 89);
            this.lblBoxZ.Name = "lblBoxZ";
            this.lblBoxZ.Size = new System.Drawing.Size(78, 15);
            this.lblBoxZ.TabIndex = 18;
            this.lblBoxZ.Text = "Box Depth";
            // 
            // lblBoxY
            // 
            this.lblBoxY.AutoSize = true;
            this.lblBoxY.Location = new System.Drawing.Point(418, 55);
            this.lblBoxY.Name = "lblBoxY";
            this.lblBoxY.Size = new System.Drawing.Size(81, 15);
            this.lblBoxY.TabIndex = 18;
            this.lblBoxY.Text = "Box Heigth";
            // 
            // lblBoxArea
            // 
            this.lblBoxArea.AutoSize = true;
            this.lblBoxArea.Location = new System.Drawing.Point(417, 121);
            this.lblBoxArea.Name = "lblBoxArea";
            this.lblBoxArea.Size = new System.Drawing.Size(69, 15);
            this.lblBoxArea.TabIndex = 18;
            this.lblBoxArea.Text = "Box Area";
            // 
            // lblBoxVolume
            // 
            this.lblBoxVolume.AutoSize = true;
            this.lblBoxVolume.Location = new System.Drawing.Point(418, 152);
            this.lblBoxVolume.Name = "lblBoxVolume";
            this.lblBoxVolume.Size = new System.Drawing.Size(87, 15);
            this.lblBoxVolume.TabIndex = 18;
            this.lblBoxVolume.Text = "Box Volume";
            // 
            // tbBoxHeight
            // 
            this.tbBoxHeight.Location = new System.Drawing.Point(512, 52);
            this.tbBoxHeight.Name = "tbBoxHeight";
            this.tbBoxHeight.ReadOnly = true;
            this.tbBoxHeight.Size = new System.Drawing.Size(67, 25);
            this.tbBoxHeight.TabIndex = 21;
            // 
            // tbBoxDepth
            // 
            this.tbBoxDepth.Location = new System.Drawing.Point(512, 86);
            this.tbBoxDepth.Name = "tbBoxDepth";
            this.tbBoxDepth.ReadOnly = true;
            this.tbBoxDepth.Size = new System.Drawing.Size(67, 25);
            this.tbBoxDepth.TabIndex = 21;
            // 
            // tbBoxArea
            // 
            this.tbBoxArea.Location = new System.Drawing.Point(512, 118);
            this.tbBoxArea.Name = "tbBoxArea";
            this.tbBoxArea.ReadOnly = true;
            this.tbBoxArea.Size = new System.Drawing.Size(67, 25);
            this.tbBoxArea.TabIndex = 21;
            // 
            // tbBoxVolume
            // 
            this.tbBoxVolume.Location = new System.Drawing.Point(512, 149);
            this.tbBoxVolume.Name = "tbBoxVolume";
            this.tbBoxVolume.ReadOnly = true;
            this.tbBoxVolume.Size = new System.Drawing.Size(67, 25);
            this.tbBoxVolume.TabIndex = 21;
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(335, 180);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(100, 25);
            this.tbDistance.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 446);
            this.Controls.Add(this.tbDistance);
            this.Controls.Add(this.tbBoxVolume);
            this.Controls.Add(this.tbBoxArea);
            this.Controls.Add(this.tbBoxDepth);
            this.Controls.Add(this.tbBoxHeight);
            this.Controls.Add(this.tbBoxWidth);
            this.Controls.Add(this.btnBox);
            this.Controls.Add(this.tbRecvMessage);
            this.Controls.Add(this.lblBoxY);
            this.Controls.Add(this.lblBoxVolume);
            this.Controls.Add(this.lblBoxArea);
            this.Controls.Add(this.lblBoxZ);
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
            this.Controls.Add(this.pbCamera);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Volumetric";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
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
        private System.Windows.Forms.TextBox tbDistance;
    }
}

