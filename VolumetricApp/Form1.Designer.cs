
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
            this.timerCamera = new System.Windows.Forms.Timer(this.components);
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
            this.pbCamera.Size = new System.Drawing.Size(642, 397);
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
            this.cbHandShake.Location = new System.Drawing.Point(95, 528);
            this.cbHandShake.Name = "cbHandShake";
            this.cbHandShake.Size = new System.Drawing.Size(103, 23);
            this.cbHandShake.TabIndex = 12;
            // 
            // lblHandShake
            // 
            this.lblHandShake.AutoSize = true;
            this.lblHandShake.Location = new System.Drawing.Point(10, 530);
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
            this.cbParity.Location = new System.Drawing.Point(95, 498);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(103, 23);
            this.cbParity.TabIndex = 13;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(10, 500);
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
            this.cbDataSize.Location = new System.Drawing.Point(95, 469);
            this.cbDataSize.Name = "cbDataSize";
            this.cbDataSize.Size = new System.Drawing.Size(103, 23);
            this.cbDataSize.TabIndex = 14;
            // 
            // lblDataSize
            // 
            this.lblDataSize.AutoSize = true;
            this.lblDataSize.Location = new System.Drawing.Point(10, 472);
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
            this.cbBaudRate.Location = new System.Drawing.Point(95, 441);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(103, 23);
            this.cbBaudRate.TabIndex = 15;
            // 
            // lblBuadRate
            // 
            this.lblBuadRate.AutoSize = true;
            this.lblBuadRate.Location = new System.Drawing.Point(10, 443);
            this.lblBuadRate.Name = "lblBuadRate";
            this.lblBuadRate.Size = new System.Drawing.Size(76, 15);
            this.lblBuadRate.TabIndex = 10;
            this.lblBuadRate.Text = "Baud Rate";
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(95, 412);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(103, 23);
            this.cbComPort.TabIndex = 16;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(10, 415);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(34, 15);
            this.lblPort.TabIndex = 11;
            this.lblPort.Text = "Port";
            // 
            // btConnectControl
            // 
            this.btConnectControl.Location = new System.Drawing.Point(13, 556);
            this.btConnectControl.Name = "btConnectControl";
            this.btConnectControl.Size = new System.Drawing.Size(185, 28);
            this.btConnectControl.TabIndex = 17;
            this.btConnectControl.Text = "Connect";
            this.btConnectControl.UseVisualStyleBackColor = true;
            this.btConnectControl.Click += new System.EventHandler(this.btConnectControl_Click);
            // 
            // tbRecvMessage
            // 
            this.tbRecvMessage.Location = new System.Drawing.Point(220, 437);
            this.tbRecvMessage.Multiline = true;
            this.tbRecvMessage.Name = "tbRecvMessage";
            this.tbRecvMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbRecvMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRecvMessage.Size = new System.Drawing.Size(432, 149);
            this.tbRecvMessage.TabIndex = 19;
            // 
            // lblRecvMessage
            // 
            this.lblRecvMessage.AutoSize = true;
            this.lblRecvMessage.Location = new System.Drawing.Point(218, 415);
            this.lblRecvMessage.Name = "lblRecvMessage";
            this.lblRecvMessage.Size = new System.Drawing.Size(120, 15);
            this.lblRecvMessage.TabIndex = 18;
            this.lblRecvMessage.Text = "ReceiveMessage";
            // 
            // timerCamera
            // 
            this.timerCamera.Tick += new System.EventHandler(this.timerCamera_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 599);
            this.Controls.Add(this.tbRecvMessage);
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
        private System.Windows.Forms.Timer timerCamera;
    }
}

