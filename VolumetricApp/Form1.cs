﻿using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumetricApp
{
    public partial class MainForm : Form
    {
        private readonly VideoCapture capture;
        Bitmap capImage;
        readonly double[,] camaeraMat = { { 496.9596652, 0.0, 605.87821196 },
                                                        { 0.0, 499.37732365, 355.0369373 },
                                                        { 0.0, 0.0, 1.0 } };
        readonly double[] distCoeffs = { -0.23633821, 0.07374086, 0.0005789, -0.0008329, -0.01166726 };
        Mat src = new Mat();


        public MainForm()
        {
            InitializeComponent();
            capture = new VideoCapture();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbComPort.DataSource = SerialPort.GetPortNames();
            cbBaudRate.SelectedIndex = 0;
            cbDataSize.SelectedIndex = 0;
            cbParity.SelectedIndex = 0;
            cbHandShake.SelectedIndex = 0;

            capture.Open(0, VideoCaptureAPIs.ANY);
            if (!capture.IsOpened())
            {
                Close();
                return;
            }
            ClientSize = new System.Drawing.Size(capture.FrameWidth, capture.FrameHeight);
            Cv2.GetOptimalNewCameraMatrix(InputArray.Create(camaeraMat),
                                                           InputArray.Create(distCoeffs),
                                                           src.Size(), 1,
                                                           src.Size(), _);
            CameraWorker.RunWorkerAsync();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CameraWorker.CancelAsync();
            capture.Dispose();
        }

        private void CameraWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var bgWorker = (BackgroundWorker) sender;

            while (!bgWorker.CancellationPending)
            {
                using (var frameMat = capture.RetrieveMat())
                {
                    var frameBitmap = BitmapConverter.ToBitmap(frameMat);
                    bgWorker.ReportProgress(0, frameBitmap);
                    src = frameMat;
                }
                Thread.Sleep(100);
            }
        }

        private void CameraWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var frameBitmap = (Bitmap)e.UserState;
            pbCamera.Image?.Dispose();
            pbCamera.Image = frameBitmap;
        }

        private Boolean IsOpen
        {
            get { return Port.IsOpen; }
            set
            {
                if (value)
                {
                    StringsRecv = "연결 됨";
                    btConnectControl.Text = "연결 끊기";
                    tbRecvMessage.Enabled = true;
                }
                else
                {
                    StringsRecv = "연결 해제됨";
                    btConnectControl.Text = "연결";
                    tbRecvMessage.Enabled = false;
                }
            }
        }

        private SerialPort _Port;
        private SerialPort Port
        {
            get
            {
                if (_Port == null)
                {
                    _Port = new SerialPort();

                    _Port.PortName = "COM1";
                    _Port.BaudRate = 921600;
                    _Port.DataBits = 8;
                    _Port.Parity = Parity.None;
                    _Port.Handshake = Handshake.None;
                    _Port.StopBits = StopBits.One;
                    _Port.Encoding = Encoding.UTF8;

                    _Port.DataReceived += ToFSerialPort_DataReceived;
                }
                return _Port;
            }
        }
        private delegate void DataDelegate(string sData);

        private StringBuilder _StringsRecv;
        private String StringsRecv
        {
            set
            {
                if (_StringsRecv == null)
                    _StringsRecv = new StringBuilder(1024);
                if (_StringsRecv.Length >= (1024 - value.Length))
                    _StringsRecv.Clear();
                _StringsRecv.AppendLine(value);
                tbRecvMessage.AppendText(_StringsRecv.ToString());
                tbRecvMessage.ScrollToCaret();
            }
        }

        private void ToFSerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(5);
            byte[] buffer = new byte[400];
            int len = Port.Read(buffer, 0, 400);

            byte[] frame = new byte[384];
            byte[] dis = new byte[3];
            byte[] tem = { 0 };
            byte[] dummy = new byte[4];
            UInt32[] map = new UInt32[4];

            this.Invoke(new EventHandler(delegate
            {
                if (buffer[0] == 0x57 && buffer[1] == 0x01) 
                {
                    int start = 9;
                    int gap = 6;
                    frame = buffer.Skip(9).Take(393-9).ToArray();

                    // 27
                    dis = frame.Skip(27 * gap).Take(3).ToArray();
                    Array.Copy(dis, 0, dummy, 0, 3);
                    Array.Copy(tem, 0, dummy, 3, 1);
                    map[0] = BitConverter.ToUInt32(dummy, 0);

                    // 28
                    dis = frame.Skip(28 * gap).Take(3).ToArray();
                    Array.Copy(dis, 0, dummy, 0, 3);
                    Array.Copy(tem, 0, dummy, 3, 1);
                    map[1] = BitConverter.ToUInt32(dummy, 0);

                    // 35
                    dis = frame.Skip(35 * gap).Take(3).ToArray();
                    Array.Copy(dis, 0, dummy, 0, 3);
                    Array.Copy(tem, 0, dummy, 3, 1);
                    map[2] = BitConverter.ToUInt32(dummy, 0);

                    // 36
                    dis = frame.Skip(36 * gap).Take(3).ToArray();
                    Array.Copy(dis, 0, dummy, 0, 3);
                    Array.Copy(tem, 0, dummy, 3, 1);
                    map[3] = BitConverter.ToUInt32(dummy, 0);

                    UInt32 mean = (map[0] + map[1] + map[2] + map[3]) / 4;

                    StringsRecv = String.Format("[RECV] {0}", mean / 1000);
                }
            }));
        }

        

        private void btConnectControl_Click(object sender, EventArgs e)
        {
            if (!Port.IsOpen)
            {
                Port.PortName = cbComPort.SelectedItem.ToString();
                Port.BaudRate = Convert.ToInt32(cbBaudRate.SelectedItem);
                Port.DataBits = Convert.ToInt32(cbDataSize.SelectedItem);
                Port.Parity = (Parity)cbParity.SelectedIndex;
                Port.Handshake = (Handshake)cbHandShake.SelectedIndex;

                try
                {
                    Port.Open();
                }
                catch (Exception ex)
                { 
                    StringsRecv = String.Format("[ERR] {0}", ex.Message);
                }
            }
            else
            {
                Port.Close();
            }
            IsOpen = Port.IsOpen;
        }
    }
}
