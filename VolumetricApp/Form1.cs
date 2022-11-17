using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace VolumetricApp
{
    public partial class MainForm : Form
    {
        private readonly VideoCapture capture;
        Mat frameCapture = new Mat();
        double cameraDistance = 0;

        double[,] cameraArr = { { 508.25560, 0.0, 625.57289 },
                                        { 0.0, 512.10233, 352.19224 },
                                        { 0.0, 0.0, 1.0 } };
        double[] distCoeffsArr = { -0.19628, 0.03741, -0.00029, 0.00048, -0.00305 };
        double[,] newCameraArr = { { 163.77437, 0.0, 784.64884 },
                                              { 0.0, 182.51584, 485.42148 },
                                              { 0.0, 0.0, 1.0 } };
        int[] Roi = { 583, 360, 412, 257 };

        Mat mapX = new Mat();
        Mat mapY = new Mat();

        List<Mat> calibrationImg = new List<Mat>();
        Mat cameraMat = new Mat();
        Mat distCoeffs = new Mat();
        Rect newRoi = new Rect(0, 0, 0, 0);
        Mat newCameraMat = new Mat();

        bool flagCalibration = false;
        bool flagInitial = true;
        
        ///
        public int cannyThres1 = 350;
        public int cannyThres2 = 400;
        public int cannyApeture = 5;
        ///

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

            tbThres1.KeyPress += tbThres1_KeyPress;

            cbCamList.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                capture.Open(i, VideoCaptureAPIs.ANY);
                if (capture.IsOpened())
                {
                    cbCamList.Items.Add(i);
                }
            }

            ///
            tbThres1.Text = Convert.ToString(350);
            tbThres2.Text = Convert.ToString(400);
            tbApeture.Text = Convert.ToString(5);
            ///

            //ClientSize = new System.Drawing.Size(capture.FrameWidth, capture.FrameHeight);
            //ClientSize = new System.Drawing.Size(640, 480);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CameraWorker.CancelAsync();
            capture.Dispose();
        }

        private void btnCamStart_Click(object sender, EventArgs e)
        {
            object itemCam = cbCamList.SelectedItem;


            capture.Open(Convert.ToInt32(itemCam), VideoCaptureAPIs.ANY);
            if (!capture.IsOpened())
            {
                Close();
                return;
            }

            capture.Set(VideoCaptureProperties.FrameWidth, 1280);
            capture.Set(VideoCaptureProperties.FrameHeight, 720);
            CameraWorker.RunWorkerAsync();

            Cv2.InitUndistortRectifyMap(InputArray.Create(cameraArr), InputArray.Create(distCoeffsArr), new Mat(),
                                                  InputArray.Create(newCameraArr), new OpenCvSharp.Size(1280, 720),
                                                  MatType.CV_32FC1, mapX, mapY);
        }

        private void CameraWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var bgWorker = (BackgroundWorker) sender;

            Mat imgBlur2 = new Mat();
            Mat imgCanny = new Mat();

            while (!bgWorker.CancellationPending)
            {
                using (var frameMat = capture.RetrieveMat())
                {
                    Mat frameOut = new Mat();
                    if (flagCalibration)
                    {
                        frameOut = frameMat;
                        frameCapture = frameOut.Clone();
                    }
                    else
                    {
                        if (flagInitial)
                        {
                            Mat frameDistort = new Mat();
                            Cv2.Remap(frameMat, frameDistort, mapX, mapY, InterpolationFlags.Linear);
                            //Cv2.Undistort(frameMat, frameDistort, InputArray.Create(cameraArr),
                            //                   InputArray.Create(distCoeffsArr), InputArray.Create(newCameraArr));
                            Mat frameSubMat = frameDistort.SubMat(new Rect(Roi[0], Roi[1], Roi[2], Roi[3]));
                            Cv2.Resize(frameSubMat, frameOut, new OpenCvSharp.Size(400, 250));
                            frameCapture = frameOut.Clone();
                            ///
                            cannyThres1 = Convert.ToInt32(tbThres1.Text);
                            cannyThres2 = Convert.ToInt32(tbThres2.Text);
                            cannyApeture = Convert.ToInt32(tbApeture.Text);
                            ///
                        }
                        else 
                        {
                            Mat frameDistort = new Mat();
                            Cv2.Undistort(frameMat, frameDistort, cameraMat, distCoeffs, newCameraMat);
                            Mat frameSubMat = frameDistort.SubMat(newRoi);
                            Cv2.Resize(frameSubMat, frameOut, new OpenCvSharp.Size(400, 250));
                            frameCapture = frameOut.Clone();
                        }
                    }
                    ///
                    Cv2.EdgePreservingFilter(frameOut, imgBlur2);
                    Cv2.Canny(imgBlur2, imgCanny, cannyThres1, cannyThres2, cannyApeture, true);
                    ///imgCanny
                    //var frameBitmap = BitmapConverter.ToBitmap(frameOut);
                    ///
                    var frameBitmap = BitmapConverter.ToBitmap(imgCanny);
                    bgWorker.ReportProgress(0, frameBitmap);
                }
                Thread.Sleep(33);
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
                    cameraDistance = Convert.ToDouble(mean / 10000);
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

        private void btnBox_Click(object sender, EventArgs e)
        {
            // H = 53cm
            Mat imgCapture = frameCapture.Clone();
            Mat imgBlur = new Mat();
            Mat imgCanny = new Mat();
            Mat imgMorph = new Mat();

            OpenCvSharp.Point[][] contours;
            HierarchyIndex[] hierarchy;

            // sizeBackground 바닥면 넓이
            // heightBackground 바닥과 카메라까지 높이
            // heightBox tof로 받은 카메라에서 상자까지 거리
            double sizeBackground = 16432.0;
            double heightBackground = 68.0;
            //double distanceBox = double.Parse(tbDistance.Text);
            double distanceBox = cameraDistance;

            double heightBox;
            double widthBox;
            double depthBox;
            double areaBox;
            double volumeBox;

            double areaRect = 0;
            double bestDist = 999999;
            RotatedRect bestRect = new RotatedRect();
            // 
            Cv2.EdgePreservingFilter(imgCapture, imgBlur);
            //threshold1, threshold2, apertureSize
            //Cv2.Canny(imgBlur, imgCanny, 350, 400, 5, true);
            ///
            Cv2.Canny(imgBlur, imgCanny, cannyThres1, cannyThres2, cannyApeture, true);
            ///
            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Cross, new OpenCvSharp.Size(3, 3));
            Cv2.MorphologyEx(imgCanny, imgMorph, MorphTypes.Close, kernel, iterations: 2);
            Cv2.FindContours(imgMorph, out contours, out hierarchy,
                                    RetrievalModes.List, ContourApproximationModes.ApproxNone);

            Point2f imgCenter = new Point2f(400 / 2, 250 / 2);
            double upper_area = 25000;
            double lower_area = 2500;
            foreach (OpenCvSharp.Point[] contour in contours)
            {
                RotatedRect _rect = Cv2.MinAreaRect(contour);
                double _areaRect =  _rect.Size.Width * _rect.Size.Height;
                if (_areaRect < upper_area && _areaRect > lower_area)
                {
                    Point2f[] box = Cv2.BoxPoints(_rect);
                    double distRect = _rect.Center.DistanceTo(imgCenter);
                    if (distRect < bestDist)
                    {
                        bestDist = distRect;
                        bestRect = _rect;
                        areaRect = _areaRect;
                    }
                }
            }
            double ratioBox = areaRect / (imgCapture.Height * imgCapture.Width);
            areaBox = ratioBox * sizeBackground * (distanceBox / heightBackground);
            depthBox = heightBackground - distanceBox;
            volumeBox = areaBox * (depthBox);

            double aspectXBox = bestRect.Size.Width / bestRect.Size.Height;
            widthBox = Math.Sqrt(areaBox * aspectXBox);
            heightBox = areaBox / widthBox;

            distanceBox = Math.Round(distanceBox, 2);
            tbCamDistance.Text = distanceBox.ToString();
            widthBox = Math.Round(widthBox, 2);
            tbBoxWidth.Text = widthBox.ToString();
            heightBox = Math.Round(heightBox, 2);
            tbBoxHeight.Text = heightBox.ToString();
            depthBox = Math.Round(depthBox, 2);
            tbBoxDepth.Text = depthBox.ToString();
            areaBox = Math.Round(areaBox, 2);
            tbBoxArea.Text = areaBox.ToString();
            volumeBox = Math.Round(volumeBox, 2);
            tbBoxVolume.Text = volumeBox.ToString();
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            CriteriaTypes type = CriteriaTypes.Eps | CriteriaTypes.MaxIter;
            TermCriteria criteria = new TermCriteria(type, 30, 0.001);

            List<List<Point3d>> refPoints = new List<List<Point3d>>();
            List<List<Point2f>> tarPoints = new List<List<Point2f>>();
            OpenCvSharp.Size sizeChessBoard = new OpenCvSharp.Size(9, 6);
            int cntImage = calibrationImg.Count();

            List<Point3d> refChessCorners = new List<Point3d>();
            List<Point2f> tarChessCorners = new List<Point2f>();
            for (int i = 0; i < (9 * 6); i++) 
            {
                int x = i % sizeChessBoard.Width;
                int y = i / sizeChessBoard.Width;
                refChessCorners.Add(new Point3d((double) x, (double) y, 0.0));
            }

            for (int i = 0; i < cntImage; i++) 
            {
                Mat imgGray = new Mat();
                Point2f[] drawChessCorners;
                Cv2.CvtColor(calibrationImg[i], imgGray, ColorConversionCodes.BGR2GRAY);
                bool success = Cv2.FindChessboardCorners(imgGray, new OpenCvSharp.Size(9, 6),
                                                                           OutputArray.Create(tarChessCorners));
                if (success) 
                {
                    drawChessCorners = Cv2.CornerSubPix(imgGray, tarChessCorners, new OpenCvSharp.Size(11, 11),
                                                                         new OpenCvSharp.Size(-1, -1), criteria);
                    Cv2.DrawChessboardCorners(imgGray, new OpenCvSharp.Size(9, 6), drawChessCorners, success);
                    refPoints.Add(refChessCorners);
                    tarPoints.Add(tarChessCorners);
                }
            }

            Mat[] rvecs, tvecs;
            double a = Cv2.CalibrateCamera(refPoints as IEnumerable <Mat>, tarPoints as IEnumerable<Mat>,
                                                        new OpenCvSharp.Size(1280, 720), cameraMat, distCoeffs,
                                                        out rvecs, out tvecs);

            newCameraMat = Cv2.GetOptimalNewCameraMatrix(cameraMat, distCoeffs,
                                                                                    new OpenCvSharp.Size(1280, 720), 1,
                                                                                    new OpenCvSharp.Size(1280, 720), out newRoi);

            flagCalibration = false;
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            Mat capImage = frameCapture.Clone();
            calibrationImg.Add(capImage.Clone());
            tbCapImg.Text = calibrationImg.Count.ToString();
            var frameBitmap = BitmapConverter.ToBitmap(capImage);
            pbCalibration.Image?.Dispose();
            pbCalibration.Image = frameBitmap;
        }

        private void btnCalbStart_Click(object sender, EventArgs e)
        {
            flagCalibration = true;
            flagInitial = false;
        }
        ///
        private void tbThres1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbThres2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
        private void tbApeture_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
        ///
    }
}
