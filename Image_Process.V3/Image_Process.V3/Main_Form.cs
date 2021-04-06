using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Diagnostics;
using System.Collections.Concurrent;

namespace Image_Process.V3
{

    public partial class Main_Form : Form
    {
        BackgroundWorker Update_Image;
        Form_Show Show = new Form_Show();
        Form_Histogram Histogram = new Form_Histogram();
        Form_DataGridView DataGridView = new Form_DataGridView();
        Form_Fourier Fourier = new Form_Fourier();
        Form_Test Test = new Form_Test();

        int channel = new int();
        int value_Angle = new int();
        int value_LineAngle = new int();
        int value_ROI = new int();
        Rectangle rect = new Rectangle();
        DataTable dataTable = new DataTable();
        int Mouse_X, Mouse_Y;
        int MeasureCount = 0;
        List<int[]> PointList = new List<int[]>();
        public Main_Form()
        {
            InitializeComponent();
        }
        private void Btn_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            string FileName = null;
            Class_Variable.IMG = null;
            Class_Variable.IMG_Gray = null;
            Class_Variable.IMG_Operating = null;
            Class_Variable.IMG_DoWork = null;
            Class_Variable.IMG_Mat = null;
            if (imageBox2.Image != null)
            {
                imageBox2.Image.Dispose();
                imageBox1.Image.Dispose();
            }



            if (result == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                Class_Variable.IMG = new Mat(FileName, Emgu.CV.CvEnum.ImreadModes.Color);
                Class_Variable.IMG_Mat = Class_Variable.IMG.Split();
                channel = Class_Variable.IMG.ElementSize;
                imageBox1.Image = Class_Variable.IMG;
                if (channel == 1)
                {
                    Class_Variable.IMG_Gray = Class_Variable.IMG_Mat[0];
                }
                else
                {
                    Class_Variable.IMG_Gray = Class_Variable.IMG_Mat[1];
                }

               
                Class_Variable.IMG_Operating = Class_Variable.IMG_Gray.Clone();
                Class_Variable.IMG_DoWork = Class_Variable.IMG_Gray.Clone();
                imageBox2.Image = Class_Variable.IMG_Gray;
                {//panel 致能
                    panel_File.Enabled = true;
                    panel_Binarization.Enabled = true;
                    panel_Filter.Enabled = true;
                    panel_Morphology.Enabled = true;
                    panel_EdgeInspect.Enabled = true;
                    panel_CornerDetector.Enabled = true;
                    panel_Matching.Enabled = true;
                    panel_ROI.Enabled = true;
                }
                btn_result.Enabled = true;
                btn_Histo.Enabled = true;
                btn_ShowData.Enabled = true;
                Update_Image = new BackgroundWorker();
                Update_Image.WorkerReportsProgress = true;
                Update_Image.WorkerSupportsCancellation = true;
                Update_Image.DoWork += new DoWorkEventHandler(Update_Show);
                Update_Image.RunWorkerAsync();
            }
            else
            {
                {//panel 禁能
                    panel_File.Enabled = false;
                    panel_Binarization.Enabled = false;
                    panel_Filter.Enabled = false;
                    panel_Morphology.Enabled = false;
                    panel_EdgeInspect.Enabled = false;
                    panel_CornerDetector.Enabled = false;
                    panel_Matching.Enabled = false;
                    panel_ROI.Enabled = false;
                }
                btn_result.Enabled = false;
                btn_Histo.Enabled = false;
                btn_ShowData.Enabled = false;
            }
        }
        private void Btn_SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|png Image|*.png|tif Image|*.tif";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(save.FileName);
            }
            imageBox2.Image.Save(save.FileName);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Restart_Click(object sender, EventArgs e)
        {
            Class_Variable.IMG_Operating = Class_Variable.IMG_Gray.Clone();
            Class_Variable.IMG_DoWork = Class_Variable.IMG_Gray.Clone();
        }
        private void Btn_result_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> image = new Image<Gray, byte>(new Bitmap(imageBox2.Image.Bitmap));
            Class_Variable.IMG_DoWork = image.Mat;

        }

        #region Binzrization     
        private void Panel_File_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Bar_binary_Scroll(object sender, ScrollEventArgs e)
        {
            int value_threshold = new int();
            value_threshold = bar_binary.Value;
            text_binary.Text = value_threshold.ToString();


            CvInvoke.Threshold(Class_Variable.IMG_Gray, Class_Variable.IMG_Operating, value_threshold, 255, Emgu.CV.CvEnum.ThresholdType.Binary);


            //imageBox2.Image = Class_Variable.IMG_Operating;

        }
        private void Bar_invbinary_Scroll(object sender, ScrollEventArgs e)
        {
            int value_invthreshold = new int();
            value_invthreshold = bar_invbinary.Value;
            text_invbinary.Text = value_invthreshold.ToString();

            CvInvoke.Threshold(Class_Variable.IMG_Gray, Class_Variable.IMG_Operating, value_invthreshold, 255, Emgu.CV.CvEnum.ThresholdType.BinaryInv);
        }
        private void Bar_toZero_Scroll(object sender, ScrollEventArgs e)
        {
            int value_zerothreshold = new int();
            value_zerothreshold = bar_toZero.Value;
            text_toZero.Text = value_zerothreshold.ToString();

            CvInvoke.Threshold(Class_Variable.IMG_Gray, Class_Variable.IMG_Operating, value_zerothreshold, 255, Emgu.CV.CvEnum.ThresholdType.ToZero);
        }
        private void Btn_Horiz_Click(object sender, EventArgs e)
        {
            var Img_HorizProj = Class_Variable.IMG_Operating.Clone();
            int[] array = new int[Img_HorizProj.Height];
            int[] y_histogram = new int[Img_HorizProj.Height];
            List<int[]> MyList = new List<int[]>();
            int index = 0;
            for (int i = 0; i >= -1 * (Img_HorizProj.Height - 1); i--)
            {
                y_histogram[index] = i;
                index++;
            }
            MCvMat mImg = (MCvMat)Marshal.PtrToStructure(Img_HorizProj.Ptr, typeof(MCvMat));
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int height = new int();
            int width = new int();
            var Range_HeightProj = Partitioner.Create(0, Img_HorizProj.Height);
            var Range_WidthProj = Partitioner.Create(0, Img_HorizProj.Width);
            unsafe
            {
               
                byte* ptr = (byte*)mImg.Data.ToPointer();
               
                for (int x = 0; x < Img_HorizProj.Height; x++)
                {
                    height++;
                    for(int y = 0; y < Img_HorizProj.Width; y++)
                    {
                        if (ptr[(x * Img_HorizProj.Width) + y] == 255)
                        {
                            array[x]++;
                            MyList.Add(new int[] { y, x });
                        }
                        width++;
                    }
                    //Parallel.For(0, Img_HorizProj.Width, y =>
                    //{
                    //    if (ptr[(x * Img_HorizProj.Width) + y] == 0)
                    //    {
                    //        array[x]++;
                    //        MyList.Add(new int[] { y, x });
                    //    }
                    //    width++;
                    //});
                }

            }
            sw.Stop();
            TimeSpan ts2 = sw.Elapsed;
            label_SpentTime.Text = ts2.TotalMilliseconds.ToString();
            label_Height.Text = height.ToString();
            label_Width.Text = width.ToString();
            var ChartArea1 = Show.chart1.ChartAreas.First();
            Show.chart1.Series[0].ChartType = SeriesChartType.Bar;
            Show.chart1.Series[0].Color = Color.Black;
            var objSeries1 = Show.chart1.Series.First();
            objSeries1.Points.DataBindXY(y_histogram, array);

            objSeries1.BorderWidth = 5;
            Show.ShowDialog();

            {
                int MaxValue = array.Max();
                int MaxIndex = array.ToList().IndexOf(MaxValue);
                array[MaxIndex] = 0;
                MaxValue = array.Max();
                MaxIndex = array.ToList().IndexOf(MaxValue);

                int LastData = MyList.Count - 1;
                Point p1 = new Point(MyList[0][0], MyList[0][1]);
                Point p2 = new Point(MyList[0][0], MaxIndex);
                Mat DrawImage = new Mat();
                DrawImage = Class_Variable.IMG.Clone();
                CvInvoke.Line(DrawImage, p1, p2, new MCvScalar(0, 0, 255), 2, LineType.AntiAlias);
                Class_Variable.IMG_Operating = DrawImage.Clone();
            }
        }
        private void Btn_Vert_Click(object sender, EventArgs e)
        {
            var Img_VertProj = Class_Variable.IMG_Operating.Clone();
            int[] array = new int[Img_VertProj.Width];
            int[] x_histogram = new int[Img_VertProj.Width];
            int index = 0;
            int height = new int();
            int width = new int();
            List<int[]> MyList = new List<int[]>();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            unsafe
            {
                MCvMat mImg = (MCvMat)Marshal.PtrToStructure(Img_VertProj.Ptr, typeof(MCvMat));
                byte* ptr = (byte*)mImg.Data.ToPointer();
                for (int x = 0; x < Img_VertProj.Width; x++)
                {
                    width++;
                    for(int y = 0; y < Img_VertProj.Width; y++)
                    {
                        if (ptr[(y * Img_VertProj.Width) + x] == 255)
                        {
                            array[x]++;
                            MyList.Add(new int[] { x, y });
                        }
                        height++;
                    }
                    //Parallel.For(0, Img_VertProj.Height, y =>
                    //{
                    //    if (ptr[(y * Img_VertProj.Width) + x] == 0)
                    //    {
                    //        array[x]++;
                    //        MyList.Add(new int[] { x, y });
                    //    }
                    //    height++;
                    //});
                }
            }
            sw.Stop();
            TimeSpan ts2 = sw.Elapsed;
            label_SpentTime.Text = ts2.TotalMilliseconds.ToString();
            label_Width.Text = width.ToString();
            label_Height.Text = height.ToString();
            var ChartArea1 = Show.chart1.ChartAreas.First();
            Show.chart1.Series[0].ChartType = SeriesChartType.Column;
            Show.chart1.Series[0].Color = Color.Black;
            var objSeries1 = Show.chart1.Series.First();
            objSeries1.Points.DataBindXY(x_histogram, array);
            objSeries1.BorderWidth = 5;
            Show.ShowDialog();
            {
                int LastData = MyList.Count - 1;
                Point p1 = new Point(MyList[0][0], MyList[0][1]);
                Point p2 = new Point(MyList[LastData][0], MyList[LastData][1]);
                Mat DrawImage = new Mat();
                DrawImage = Class_Variable.IMG.Clone();
                CvInvoke.Line(DrawImage, p1, p2, new MCvScalar(0, 0, 255), 2, LineType.AntiAlias);
                Class_Variable.IMG_Operating = DrawImage.Clone();
            }
        }
        #endregion
        #region Filter
        private void Numeric_median_ValueChanged(object sender, EventArgs e)
        {
            int value_median = new int();
            value_median = (int)numeric_median.Value;
            var Img = Class_Variable.IMG_Gray.Clone();

            var MedianFilter_Image = Class_Variable.IMG_Gray.Clone();
            try
            {
                Img = Class_Variable.IMG_DoWork.Clone();
            }
            catch
            {
                Img = Class_Variable.IMG_Gray.Clone();
            }
            CvInvoke.MedianBlur(Img, MedianFilter_Image, value_median);
            Class_Variable.IMG_Operating = MedianFilter_Image.Clone();
        }
        private void Numeric_gaussian_ValueChanged(object sender, EventArgs e)
        {
            int value_gaussian = new int();
            value_gaussian = (int)numeric_gaussian.Value;

            var Img = Class_Variable.IMG_Gray.Clone();

            var GaussianFilter_Image = Class_Variable.IMG_Gray.Clone();
            try
            {
                Img = Class_Variable.IMG_DoWork.Clone();
            }
            catch
            {
                Img = Class_Variable.IMG_Gray.Clone();
            }
            CvInvoke.GaussianBlur(Img, GaussianFilter_Image, new Size(value_gaussian, value_gaussian), 3, 3);
            Class_Variable.IMG_Operating = GaussianFilter_Image.Clone();
        }

        private void Numeric_blur_ValueChanged(object sender, EventArgs e)
        {
            int value_filter = new int();
            value_filter = (int)numeric_blur.Value;

            var Img = Class_Variable.IMG_Gray.Clone();

            var BlurFilter_Image = Class_Variable.IMG_Gray.Clone();
            try
            {
                Img = Class_Variable.IMG_DoWork.Clone();
            }
            catch
            {
                Img = Class_Variable.IMG_Gray.Clone();
            }
            CvInvoke.Blur(Img, BlurFilter_Image, new Size(value_filter, value_filter), new Point(-1, -1), Emgu.CV.CvEnum.BorderType.Default);
            Class_Variable.IMG_Operating = BlurFilter_Image.Clone();

        }
        #endregion

        #region Morphology

        private void Numeric_Erosion_ValueChanged(object sender, EventArgs e)
        {
            int value_Ersion = new int();
            value_Ersion = (int)numeric_Erosion.Value;
            Mat element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross,
                          new Size(3, 3), new Point(-1, -1));
            var Img = Class_Variable.IMG_Gray.Clone();

            var Ersion_Image = Class_Variable.IMG_Gray.Clone();
            try
            {
                Img = Class_Variable.IMG_DoWork.Clone();
            }
            catch
            {
                Img = Class_Variable.IMG_Gray.Clone();
            }
            CvInvoke.Erode(Img, Ersion_Image, element, new Point(-1, -1), value_Ersion,
                            Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0, 0, 0));
            Class_Variable.IMG_Operating = Ersion_Image.Clone();
        }
        private void Numeric_Dilate_ValueChanged(object sender, EventArgs e)
        {
            int value_Dilate = new int();
            value_Dilate = (int)numeric_Dilate.Value;
            Mat element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross,
                         new Size(3, 3), new Point(-1, -1));
            var Img = Class_Variable.IMG_Gray.Clone();

            var Dilate_Image = Class_Variable.IMG_Gray.Clone();
            try
            {
                Img = Class_Variable.IMG_DoWork.Clone();
            }
            catch
            {
                Img = Class_Variable.IMG_Gray.Clone();
            }

            CvInvoke.Dilate(Img, Dilate_Image, element, new Point(-1, -1), value_Dilate,
                            Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0, 0, 0));
            Class_Variable.IMG_Operating = Dilate_Image.Clone();

        }

        private void Numeric_Open_ValueChanged(object sender, EventArgs e)
        {
            int value_Open = new int();
            value_Open = (int)numeric_Open.Value;
            Mat element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross,
                          new Size(3, 3), new Point(-1, -1));
            var Img = Class_Variable.IMG_Gray.Clone();

            var Open_Image = Class_Variable.IMG_Gray.Clone();
            try
            {
                Img = Class_Variable.IMG_DoWork.Clone();
            }
            catch
            {
                Img = Class_Variable.IMG_Gray.Clone();
            }
            CvInvoke.MorphologyEx(Img, Open_Image, Emgu.CV.CvEnum.MorphOp.Open, element,
                new Point(-1, -1), value_Open, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0, 0, 0));
            Class_Variable.IMG_Operating = Open_Image.Clone();
        }

        private void Numeric_Close_ValueChanged(object sender, EventArgs e)
        {
            int value_Close = new int();
            value_Close = (int)numeric_Close.Value;
            Mat element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross,
                          new Size(3, 3), new Point(-1, -1));
            var Img = Class_Variable.IMG_Gray.Clone();

            var Close_Image = Class_Variable.IMG_Gray.Clone();
            try
            {
                Img = Class_Variable.IMG_DoWork.Clone();
            }
            catch
            {
                Img = Class_Variable.IMG_Gray.Clone();
            }
            CvInvoke.MorphologyEx(Img, Close_Image, Emgu.CV.CvEnum.MorphOp.Close, element,
                new Point(-1, -1), value_Close, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(0, 0, 0));
            Class_Variable.IMG_Operating = Close_Image.Clone();
        }

        private void Btn_thinning_Click(object sender, EventArgs e)
        {
            StringBuilder X_Y = new StringBuilder();
            
            var Img = Class_Variable.IMG_Gray.Clone();

            var Thinning_Image = Class_Variable.IMG_Gray.Clone();
            try
            {
                Img = Class_Variable.IMG_DoWork.Clone();
            }
            catch
            {
                Img = Class_Variable.IMG_Gray.Clone();
            }
            Emgu.CV.XImgproc.XImgprocInvoke.Thinning(Img, Thinning_Image, Emgu.CV.XImgproc.ThinningTypes.ZhangSuen);
            Class_Variable.IMG_Operating = Thinning_Image.Clone();
            Point[] BorderCoor = new Point[Thinning_Image.Height * Thinning_Image.Width]; 

            #region 計算座標點位置          
            var Test_Image = Thinning_Image.Clone();
            int index = 0;
            int flag = 0;
            int[] array = new int[Test_Image.Height * Test_Image.Width];
            unsafe
            {
                MCvMat mImg = (MCvMat)Marshal.PtrToStructure(Test_Image.Ptr, typeof(MCvMat));
                byte* ptr = (byte*)mImg.Data.ToPointer();
                for (int x = 0; x < Test_Image.Height; x++)
                {
                    for (int y = 0; y < Test_Image.Width; y++)
                    {
                        array[index] = ptr[(x * Test_Image.Width) + y];

                        if (array[index] == 255)
                        {
                            flag++;
                            BorderCoor[flag].X = y;
                            BorderCoor[flag].Y = x;
                            X_Y.AppendFormat("{0}, {1}\r\n", x, y);
                        }
                        index++;
                    }
                }

            }
            Mat Paper = new Mat(Thinning_Image.Height, Thinning_Image.Width, Emgu.CV.CvEnum.DepthType.Cv32F, 3);
            Paper.SetTo(new MCvScalar(255, 255, 255));
            for (int i = 0; i < BorderCoor.Length - 1; i++)
            {
                if (BorderCoor[i].X != 0 && BorderCoor[i].Y != 0 && BorderCoor[i+1].X != 0 && BorderCoor[i+1].Y != 0)
                {
                    CvInvoke.Line(Paper, BorderCoor[i], BorderCoor[i + 1], new MCvScalar(255, 0, 0), 2, LineType.AntiAlias);
                }
               
            }
           // Paper.Save("C://Users//Mony Kao//Desktop//Paper.bmp");


            string DIRNAME = AppDomain.CurrentDomain.BaseDirectory + @"\Data\";
            string FILENAME = DIRNAME + "data.txt";
            if (!Directory.Exists(DIRNAME))
                Directory.CreateDirectory(DIRNAME);

            if (!File.Exists(FILENAME))
            {
                // The File.Create method creates the file and opens a FileStream on the file. You neeed to close it.
                File.Create(FILENAME).Close();
            }
            using (StreamWriter sw = File.AppendText(FILENAME))
            {
                Write_system(X_Y.ToString(), sw);
            }
            #endregion


        }
        private static void Write_system(string logMessage, TextWriter w)
        {          
            w.WriteLine("{0}", logMessage);
        }
        #endregion

        #region Edge Inspect
        private void Btn_contour_Click(object sender, EventArgs e)
        {
            var Img = Class_Variable.IMG_Gray.Clone();

            var Profile_Image = Class_Variable.IMG_Gray.Clone();
            var Contour_Image = Class_Variable.IMG_Gray.Clone();
            try
            {
                Img = Class_Variable.IMG_DoWork.Clone();
            }
            catch
            {
                Img = Class_Variable.IMG_Gray.Clone();
            }
            CvInvoke.Canny(Img, Profile_Image, 20, 180);
            Class_Variable.IMG_Operating = Profile_Image.Clone();

        }

        private void Btn_Houghline_Click(object sender, EventArgs e)
        {
            double Now_interval = new double(); //當前的角度與前一筆的角度差距
            double Compare_interval = new double(); //紀錄要比較的角度差距
            int index = new int();

            int Threshold = value_LineAngle;
            Image<Gray, Byte> Image = new Image<Gray, byte>(new Bitmap(imageBox2.Image.Bitmap));
            Mat Canny_Image = Image.Mat;
            Mat Draw_Image = Class_Variable.IMG.Clone();
            VectorOfPointF lines = new VectorOfPointF();
            //CvInvoke.HoughLines(Canny_Image, lines, 1, Math.PI / value_LineAngle, 75, 0, 0);
            CvInvoke.HoughLines(Canny_Image, lines, 1, Math.PI / 180, Threshold, 0, 0);


            List<KeyValuePair<double, double>> Observe = new List<KeyValuePair<double, double>>();
            //依次在圖中繪製出每條線段
            for (int i = 0; i < lines.Size; i++)
            {
                PointF p = lines[i];
                float rho = p.X; //原點到直線的距離
                float theta = p.Y; //直線的角度
                Observe.Add(new KeyValuePair<double, double>(rho, theta));

                double a = Math.Cos(theta), b = Math.Sin(theta);
                double x0 = rho * a, y0 = rho * b;

                Point pt1 = new Point(), pt2 = new Point();
                pt1.X = (int)Math.Round(x0 - 1000 * b);
                pt1.Y = (int)Math.Round(y0 + 1000 * a);
                pt2.X = (int)Math.Round(x0 + 1000 * b);
                pt2.Y = (int)Math.Round(y0 - 1000 * a);
                //CvInvoke.Circle(Draw_Image, pt1, 10, new MCvScalar(255, 0, 0), 3);
                //CvInvoke.Circle(Draw_Image, pt2, 10, new MCvScalar(0, 255, 0), 3);
                CvInvoke.Line(Draw_Image, pt1, pt2, new MCvScalar(0, 0, 255), 2, LineType.AntiAlias); //LineType.AntiAlias表示抗鋸齒 
            }
            Class_Variable.IMG_Operating = Draw_Image.Clone();
            List<KeyValuePair<double, double>> Observe_sorted = Observe.ToList();
            Observe_sorted.Sort(
                                 delegate (KeyValuePair<double, double> pair1,
                                 KeyValuePair<double, double> pair2)
                                 {
                                     return pair1.Value.CompareTo(pair2.Value);
                                 }
                               );
            for (int i = 0; i < lines.Size; i++)
            {
                if (i == 1)
                {
                    Compare_interval = Math.Abs(Observe_sorted[i].Value - Observe_sorted[i - 1].Value);
                }
                else if (i > 1)
                {
                    Now_interval = Math.Abs(Observe_sorted[i].Value - Observe_sorted[i - 1].Value);
                    if (Now_interval >= Compare_interval)
                    {
                        Compare_interval = Now_interval;
                        index = i;
                    }
                }
            }
            //double[] X1 = new double[index];
            //double[] Y1 = new double[index];
            //double[] X2 = new double[lines.Size - index];
            //double[] Y2 = new double[lines.Size - index];
            //double X1_Average = new double();
            //double Y1_Average = new double();
            //double X2_Average = new double();
            //double Y2_Average = new double();
            ////Observe_sorted[0].Value;
            //for (int i = 0; i < lines.Size; i++)
            //{
            //    if (i < index)
            //    {
            //        X1[i] = Observe_sorted[i].Key;
            //        Y1[i] = Observe_sorted[i].Value;
            //    }
            //    else
            //    {
            //        X2[i - index] = Observe_sorted[i].Key;
            //        Y2[i - index] = Observe_sorted[i].Value;
            //    }
            //}

            //try
            //{
            //    X1_Average = X1[Convert.ToInt32(X1.Length / 2)];
            //    Y1_Average = Y1[Convert.ToInt32(Y1.Length / 2)];
            //    X2_Average = X2[Convert.ToInt32(X2.Length / 2)];
            //    Y2_Average = Y2[Convert.ToInt32(Y2.Length / 2)];



            //    double a_NEW = Math.Cos(Y1_Average), b_NEW = Math.Sin(Y1_Average);
            //    double x0_NEW = X1_Average * a_NEW, y0_NEW = X1_Average * b_NEW;
            //    Point point1_New = new Point(), point2_New = new Point();
            //    point1_New.X = (int)Math.Round(x0_NEW - 10000 * b_NEW);
            //    point1_New.Y = (int)Math.Round(y0_NEW + 10000 * a_NEW);
            //    point2_New.X = (int)Math.Round(x0_NEW + 10000 * b_NEW);
            //    point2_New.Y = (int)Math.Round(y0_NEW - 10000 * a_NEW);

            //    CvInvoke.Line(Draw_Image, point1_New, point2_New, new MCvScalar(0, 0, 255), 2, LineType.AntiAlias); //LineType.AntiAlias表示抗鋸齒 

            //    a_NEW = Math.Cos(Y2_Average);
            //    b_NEW = Math.Sin(Y2_Average);
            //    x0_NEW = X2_Average * a_NEW;
            //    y0_NEW = X2_Average * b_NEW;
            //    point1_New.X = (int)Math.Round(x0_NEW - 10000 * b_NEW);
            //    point1_New.Y = (int)Math.Round(y0_NEW + 10000 * a_NEW);
            //    point2_New.X = (int)Math.Round(x0_NEW + 10000 * b_NEW);
            //    point2_New.Y = (int)Math.Round(y0_NEW - 10000 * a_NEW);

            //    CvInvoke.Line(Draw_Image, point1_New, point2_New, new MCvScalar(0, 0, 255), 2, LineType.AntiAlias); //LineType.AntiAlias表示抗鋸齒 


            //    ////if (lines.Size == 2)
            //    ////{
            //    ////    int[] _Theta = new int[2];
            //    ////    int Theta = new int();

            //    ////    for (int i = 0; i < lines.Size; i++)
            //    ////    {
            //    ////        PointF p = lines[i];
            //    ////        _Theta[i] = 180 - (int)Math.Round(p.Y * 180 / Math.PI);
            //    ////    }
            //    ////    Theta = 360 - (_Theta[0] + _Theta[1]);
            //    ////    if (Theta >= 180)
            //    ////    {
            //    ////        int min = _Theta.Min();
            //    ////        int max = _Theta.Max();
            //    ////        Theta = min + (180 - max);
            //    ////    }
            //    ////}
            //    Observe.Clear();
            //    Class_Variable.IMG_Operating = Draw_Image.Clone();
            //    int Theta1 = (int)Math.Round(Y1_Average * 180 / Math.PI);
            //    int Theta2 = (int)Math.Round(Y2_Average * 180 / Math.PI);
            //    int Theta = 0;
            //    if (Theta1 < 90 && Theta2 < 90)
            //    {
            //        Theta = Theta1 + Theta2;
            //    }
            //    else if (Theta1 >= 90 && Theta2 >= 90)
            //    {
            //        Theta = Math.Abs(360 - (Theta1 + Theta2));
            //    }
            //    else if (Theta1 < 90 || Theta2 < 90)
            //    {
            //        Theta = Math.Abs(Theta1 + Theta2 - 180);
            //    }
            //    else
            //    {
            //        Theta = Theta1 + Theta2;
            //    }



            //    MessageBox.Show("Theta1:" + Theta1.ToString() + " Theta2: " + Theta2.ToString() + " Theta: " + Theta.ToString());
            //}
            //catch
            //{
            //    MessageBox.Show("找不到直線!");
            //}

        }
        private void HScrollBar_LineAngle_Scroll(object sender, ScrollEventArgs e)
        {
            value_LineAngle = hScrollBar_LineAngle.Value;
            textBox_LineAngle.Text = value_LineAngle.ToString();
        }
        private void Btn_HoughTriangle_Click(object sender, EventArgs e)
        {



        }

        private void Btn_FindDot_Click(object sender, EventArgs e)
        {
            Image<Gray, Byte> Canny_Image = new Image<Gray, byte>(new Bitmap(imageBox2.Image.Bitmap));
            Image<Bgr, Byte> Circles_Image = new Image<Bgr, byte>(new Bitmap(imageBox1.Image.Bitmap));
            CircleF[] circles = CvInvoke.HoughCircles(Canny_Image, HoughType.Gradient, 30.0, 10.0, 100.0, 100.0, 5);
            foreach (CircleF circle in circles)
                Circles_Image.Draw(circle, new Bgr(Color.OrangeRed), 6);
            Class_Variable.IMG_Operating = Circles_Image.Mat.Clone();
        }
        private void btn_FindEllipse_Click(object sender, EventArgs e)
        {
            var Img_HorizProj = Class_Variable.IMG_Operating.Clone();
            int[] array_Horz = new int[Img_HorizProj.Height];
            List<int[]> MyList_Horz = new List<int[]>();
            MCvMat mImg = (MCvMat)Marshal.PtrToStructure(Img_HorizProj.Ptr, typeof(MCvMat));
            unsafe
            {

                byte* ptr = (byte*)mImg.Data.ToPointer();

                for (int x = 0; x < Img_HorizProj.Height; x++)
                {
                    for (int y = 0; y < Img_HorizProj.Width; y++)
                    {
                        if (ptr[(x * Img_HorizProj.Width) + y] == 255)
                        {
                            array_Horz[x]++;
                            MyList_Horz.Add(new int[] { y, x });
                        }
                    }

                }

            }
          
            int MaxValue = array_Horz.Max();
            int MaxIndex = array_Horz.ToList().IndexOf(MaxValue);
            MaxValue = array_Horz.Max();
            MaxIndex = array_Horz.ToList().IndexOf(MaxValue);
            Point p1_Horz = new Point(MyList_Horz[0][0], MyList_Horz[0][1]);
            Point p2_Horz = new Point(MyList_Horz[0][0], MaxIndex);


            var Img_VertProj = Class_Variable.IMG_Operating.Clone();
            int[] array_Vert = new int[Img_VertProj.Width];        
            List<int[]> MyList_Vert = new List<int[]>();

            unsafe
            {
                MCvMat mImg_Vert = (MCvMat)Marshal.PtrToStructure(Img_VertProj.Ptr, typeof(MCvMat));
                byte* ptr = (byte*)mImg_Vert.Data.ToPointer();
                for (int x = 0; x < Img_VertProj.Width; x++)
                {
                    for (int y = 0; y < Img_VertProj.Width; y++)
                    {
                        if (ptr[(y * Img_VertProj.Width) + x] == 255)
                        {
                            array_Vert[x]++;
                            MyList_Vert.Add(new int[] { x, y });
                        }
                    }
                
                }
            }
            int LastData_Vert = MyList_Vert.Count - 1;
            Point p1_Vert = new Point(MyList_Vert[0][0], MyList_Vert[0][1]);
            Point p2_Vert = new Point(MyList_Vert[LastData_Vert][0], MyList_Vert[LastData_Vert][1]);
            Mat DrawImage = new Mat();
            DrawImage = Class_Variable.IMG.Clone();
            CvInvoke.Line(DrawImage, p1_Vert, p2_Vert, new MCvScalar(0, 0, 255), 2, LineType.AntiAlias);
            CvInvoke.Line(DrawImage, p1_Horz, p2_Horz, new MCvScalar(0, 0, 255), 2, LineType.AntiAlias);

            
            int Width = Math.Abs((p1_Vert.X) - (p2_Vert.X));
            int Height = Math.Abs((p1_Horz.Y) - (p2_Horz.Y));
            Point Center_ROI = new Point(p1_Vert.X, p1_Horz.Y);
            Point Start_ROI = new Point();
            rect = new Rectangle(Center_ROI, new Size(Width, Height));
            CvInvoke.Rectangle(DrawImage, rect, new MCvScalar(0, 0, 255, 255), 1, LineType.AntiAlias, 0);
            Class_Variable.IMG_Operating = DrawImage.Clone();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Image<Gray, Byte> Gray_Image = new Image<Gray, byte>(new Bitmap(imageBox2.Image.Bitmap));
            Image<Gray, float> sobelY = Gray_Image.Sobel(0, 1, 3);
            Class_Variable.IMG_Operating = sobelY.Mat.Clone();
        }
        #endregion

        #region Corner Detector
        private void Btn_StartX_Click(object sender, EventArgs e)
        {

            var Image = Class_Variable.IMG_DoWork;
            Mat StartX_Image = Image;
            int X_Start = 0, Y_Start = 0;
            int bright = 255;
            unsafe
            {
                MCvMat mImg = (MCvMat)Marshal.PtrToStructure(StartX_Image.Ptr, typeof(MCvMat));
                byte* ptr = (byte*)mImg.Data.ToPointer();
                //for (int x = 0; x <= StartX_Image.Width; x++)
                //{
                //    if (ptr[(x * StartX_Image.Width) + x] >= bright)
                //    {
                //        X_Start = x;
                //        break;
                //    }
                //}
                bool check = false;
                for (int x = 0; x < StartX_Image.Width; x++)
                {
                    for (int y = 0; y < StartX_Image.Height; y++)
                    {
                        if (!check)
                            if (ptr[(x * StartX_Image.Width) + y] == bright)
                            {
                                X_Start = x;
                                Y_Start = y;
                                check = true;
                            }
                    }
                    if (check)
                        break;

                }


            }
            Point cross = new Point(X_Start, Y_Start);
            CvInvoke.Circle(StartX_Image, cross, 12, new MCvScalar(255, 255, 0, 0), 3);
            Class_Variable.IMG_Operating = StartX_Image.Clone();

        }

        private void Btn_End_Click(object sender, EventArgs e)
        {

        }
        private void Btn_FastCorner_Click(object sender, EventArgs e)
        {
            Mat Image = Class_Variable.IMG_DoWork.Clone();
            FastDetector IMG_Corner = new FastDetector(value_Angle); //角點閥值設定
            MKeyPoint[] points = IMG_Corner.Detect(Image);
            Mat IMG_CornerDraw = Class_Variable.IMG.Clone();
            foreach (var point in points)
            {
                CvInvoke.Circle(IMG_CornerDraw, new Point((int)point.Point.X, (int)point.Point.Y), 10, new MCvScalar(0, 0, 255), 3);
                Point cross = new Point((int)point.Point.X, (int)point.Point.Y);
            }


            // CvInvoke.Circle(IMG_CornerDraw, new Point(100, 100), 40, new MCvScalar(0, 0, 255), 3);
            Class_Variable.IMG_Operating = IMG_CornerDraw.Clone();
            //Mat roiFrame = new Mat(IMG_CornerDraw, new Rectangle(600, 100, 400, 300));
            //Test.imageBox1.Image = roiFrame;
            //Test.ShowDialog();
        }
        private void Bar_Angle_Scroll(object sender, ScrollEventArgs e)
        {
            value_Angle = Bar_Angle.Value;
            textBox_Angle.Text = value_Angle.ToString();
        }
        #endregion
        #region Matching
        private void Btn_FD_Click(object sender, EventArgs e)
        {
            Image<Gray, Byte> Image = new Image<Gray, byte>(new Bitmap(imageBox2.Image.Bitmap));
            Mat Data_Image = new Mat();
            Mat Draw_Image = Class_Variable.IMG.Clone();
            Data_Image = Image.Mat;
            int Height = Data_Image.Height;
            int Width = Data_Image.Width;
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(Data_Image, contours, null, Emgu.CV.CvEnum.RetrType.List, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            int count = contours.Size;
            Point[] Corrdinate = new Point[contours[1].Size];//用於存儲輪廓中心點座標


            label_NofContour.Text = contours.Size.ToString();

            Mat Paper = new Mat(Class_Variable.IMG.Height, Class_Variable.IMG.Width, Emgu.CV.CvEnum.DepthType.Cv32F, 3);
            Paper.SetTo(new MCvScalar(255, 255, 255));
            for (int i = 0; i < count; i++)
            {

                using (VectorOfPoint approxContour = new VectorOfPoint())
                {
                    CvInvoke.DrawContours(Paper, contours, i, new MCvScalar(128, 0, 255, 255), 1);
                }

            }
            Class_Variable.IMG_Operating = Paper.Clone();

            double[] m00 = new double[contours.Size];
            double[] m01 = new double[contours.Size];
            double[] m10 = new double[contours.Size];
            Point[] gravity = new Point[contours.Size];// is used to store the contour center point coordinates
            MCvMoments[] moments = new MCvMoments[contours.Size];
            for (int i = 0; i < count; i++)
            {
                moments[i] = CvInvoke.Moments(contours[i], false);

                m00[i] = moments[i].M00;
                m01[i] = moments[i].M01;
                m10[i] = moments[i].M10;
                int x = Convert.ToInt32(m10[i] / m00[i]);//Calculate the current contour center point coordinates
                int y = Convert.ToInt32(m01[i] / m00[i]);
                gravity[i] = new Point(x, y);

            }
            Paper.SetTo(new MCvScalar(255, 255, 255));
            for (int i = 0; i < gravity.Length - 1; i++)
            {
                CvInvoke.Line(Paper, gravity[i], gravity[i+1], new MCvScalar(255, 0, 0), 2, LineType.AntiAlias);
            }
            //Paper.Save("C://Users//Mony Kao//Desktop//Paper.bmp");



        }
        public static double[] DFT(double[] input, int partials = 0)
        {
            int len = input.Length;
            int index = new int();
            double[] cosDFT = new double[len / 2 + 1];
            double[] sinDFT = new double[len / 2 + 1];
            double[] data = new double[len / 2 + 1];
            if (partials == 0)
                partials = len / 2;

            for (int n = 0; n <= partials; n++)
            {
                double cos = 0.0;
                double sin = 0.0;

                for (int i = 0; i < len; i++)
                {
                    cos += input[i] * Math.Cos(2 * Math.PI * n / len * i);
                    sin += input[i] * Math.Sin(2 * Math.PI * n / len * i);
                }

                cosDFT[n] = cos;
                sinDFT[n] = sin;

                //if(n >= 50)
                {
                    data[index] = Math.Round(Math.Sqrt(Math.Pow(cosDFT[n], 2) + Math.Pow(sinDFT[n], 2)));
                    index++;
                }

            }
            // return new Tuple<double[], double[]>(cosDFT, sinDFT);
            return data;
        }
        public static double[] IDFT(double[] cos, double[] sin, int len = 0)
        {
            if (cos.Length != sin.Length) throw new ArgumentException("cos.Length and sin.Length bust match!");

            if (len == 0)
                len = (cos.Length - 1) * 2;

            double[] output = new double[len];

            int partials = sin.Length;
            if (partials > len / 2)
                partials = len / 2;

            for (int n = 0; n <= partials; n++)
            {
                for (int i = 0; i < len; i++)
                {
                    output[i] += Math.Cos(2 * Math.PI * n / len * i) * cos[n];
                    output[i] += Math.Sin(2 * Math.PI * n / len * i) * sin[n];
                }
            }

            return output;
        }
        private void Btn_Fourier_Click(object sender, EventArgs e)
        {
            Image<Gray, float> Image = new Image<Gray, float>(new Bitmap(imageBox2.Image.Bitmap));
            Mat Fourier_Image = new Mat();
            Fourier_Image = Image.Mat;
            int m = CvInvoke.GetOptimalDFTSize(Fourier_Image.Rows);
            int n = CvInvoke.GetOptimalDFTSize(Fourier_Image.Cols);
            Mat padded = new Mat();
            CvInvoke.CopyMakeBorder(Fourier_Image, padded, 0, m - Fourier_Image.Rows, 0, n - Fourier_Image.Cols, BorderType.Constant);
            padded.ConvertTo(padded, DepthType.Cv32F);
            Mat zeroMat = Mat.Zeros(padded.Rows, padded.Cols, DepthType.Cv32F, 1);
            VectorOfMat matVector = new VectorOfMat();
            matVector.Push(padded);
            matVector.Push(zeroMat);
            Mat complexI = new Mat(padded.Size, DepthType.Cv32F, 2);
            CvInvoke.Merge(matVector, complexI);
            Mat fourier = new Mat(padded.Size, DepthType.Cv32F, 2);
            CvInvoke.Dft(complexI, fourier, DxtType.Inverse, complexI.Rows);

            Mat magnitudeImage = Magnitude(fourier);
            magnitudeImage = new Mat(magnitudeImage, new Rectangle(0, 0, magnitudeImage.Cols & -2, magnitudeImage.Rows & -2));
            SwitchQuadrants(ref magnitudeImage);
            CvInvoke.Normalize(magnitudeImage, magnitudeImage, 0, 255, NormType.MinMax, DepthType.Cv8U);




            Fourier.imageBox1.Image = magnitudeImage;
            Fourier.ShowDialog();
        }
        private Mat Magnitude(Mat fftData)
        {
            //傅立葉轉換的實部
            Mat Real = new Mat(fftData.Size, DepthType.Cv32F, 1);
            //傅立葉轉換的虛部
            Mat Imaginary = new Mat(fftData.Size, DepthType.Cv32F, 1);
            VectorOfMat channels = new VectorOfMat();
            CvInvoke.Split(fftData, channels); //將多通道mat分離成幾個單通道mat
            Real = channels.GetOutputArray().GetMat(0);
            Imaginary = channels.GetOutputArray().GetMat(1);
            CvInvoke.Pow(Real, 2.0, Real);
            CvInvoke.Pow(Imaginary, 2.0, Imaginary);
            CvInvoke.Add(Real, Imaginary, Real);
            CvInvoke.Pow(Real, 0.5, Real);
            Mat onesMat = Mat.Ones(Real.Rows, Real.Cols, DepthType.Cv32F, 1);
            CvInvoke.Add(Real, onesMat, Real);
            CvInvoke.Log(Real, Real); //求自然對數
            return Real;
        }
        private void SwitchQuadrants(ref Mat mat)
        {
            int cx = mat.Cols / 2;
            int cy = mat.Rows / 2;
            Mat q0 = new Mat(mat, new Rectangle(0, 0, cx, cy)); //ROI左上區域
            Mat q1 = new Mat(mat, new Rectangle(cx, 0, cx, cy)); //ROI右上區域
            Mat q2 = new Mat(mat, new Rectangle(0, cy, cx, cy)); //ROI左下區域
            Mat q3 = new Mat(mat, new Rectangle(cx, cy, cx, cy)); //ROI右下區域
            Mat temp = new Mat(q0.Size, DepthType.Cv32F, 1);
            //交換象限（左上和右下進行交换）
            q0.CopyTo(temp);
            q3.CopyTo(q0);
            temp.CopyTo(q3);
            //交換象限（右上和左下進行交换）
            q1.CopyTo(temp);
            q2.CopyTo(q1);
            temp.CopyTo(q2);
        }

        #endregion
        void Update_Show(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        imageBox1.Image = Class_Variable.IMG;
                        imageBox2.Image = Class_Variable.IMG_Operating;
                    });
                }
                catch
                {
                    MessageBox.Show("Error!!");
                }
                System.Threading.Thread.Sleep(150);
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Filter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel_EdgeInspect_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Histo_Click(object sender, EventArgs e)
        {
            Image<Gray, Byte> Image = new Image<Gray, byte>(new Bitmap(imageBox2.Image.Bitmap));

            Histogram.histogramBox1.GenerateHistograms(Image[0], 32);
            Histogram.histogramBox1.Refresh();
            Histogram.ShowDialog();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void Text_binary_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel_Binarization_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_ShowData_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            
            Image<Gray, Byte> Image = new Image<Gray, byte>(new Bitmap(imageBox2.Image.Bitmap));
            Mat Data_Image = new Mat();
            dataTable.Clear();
            Data_Image = Image.Mat;
            int rows = Data_Image.Height;
            int cols = Data_Image.Width;
            //DataGridView.dataGridView1.DataSource = null;
            DataGridView.dataGridView1.ColumnCount = cols;
            DataGridView.dataGridView1.RowCount = rows;
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            sw.Reset();
            sw.Start();
            unsafe
            {
                MCvMat mImg = (MCvMat)Marshal.PtrToStructure(Data_Image.Ptr, typeof(MCvMat));
                byte* ptr = (byte*)mImg.Data.ToPointer();

                //for(int i =0; i< rows; i++)
                //{
                //    for (int j = 0; j < cols; j++)
                //    {
                //        val = ptr[0];
                //        DataGridView.dataGridView1[j, i].Value = string.Format("({0},{1}) = {2}", i + 1, j + 1, val);
                //        ptr++;
                //    }
                //}
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {

                        DataGridView.dataGridView1[j, i].Value = string.Format("{0}", ptr[0]);
                        ptr++;
                    }
                }



            }
            sw.Stop();
            var result1 = sw.Elapsed.TotalMilliseconds;



            DataGridView.ShowDialog();
            dataTable.Clear();

            DataGridView.Dispose();
        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }
        private void Bar_RectSize_Scroll(object sender, ScrollEventArgs e)
        {
            value_ROI = bar_RectSize.Value;
            textBox_RectSize.Text = bar_RectSize.Value.ToString();
        }
        private void Btn_ROI_Click(object sender, EventArgs e)
        {
            Mat ROI_Img = new Mat(Class_Variable.IMG, rect);
            Test.imageBox1.Image = ROI_Img;
            Test.ShowDialog();
        }
        private void Btn_Center_Click(object sender, EventArgs e)
        {          
            Mat ROI_Img = new Mat();
            ROI_Img = Class_Variable.IMG.Clone();
            rect = new Rectangle(new Point(ROI_Img.Width/2 - (value_ROI/2), ROI_Img.Height / 2 - (value_ROI / 2)), new Size(value_ROI, value_ROI));
            CvInvoke.Rectangle(ROI_Img, rect, new MCvScalar(0, 0, 255, 255), 10, LineType.AntiAlias, 0);
            Class_Variable.IMG_Operating = ROI_Img.Clone();
        }
        private void Btn_DrawPoint_Click(object sender, EventArgs e)
        {
            Mat Paper = new Mat(imageBox2.Height, imageBox2.Width, Emgu.CV.CvEnum.DepthType.Cv32F, 3);
            Paper.SetTo(new MCvScalar(255, 255, 255));
            Class_Variable.IMG_Operating = Paper;
            //imageBox2.Image = Paper;
        }
        private void ImageBox2_MouseDown(object sender, MouseEventArgs e)
        {
            label_XCoor.Text = e.X.ToString();
            label_YCoor.Text = e.Y.ToString();
            Mouse_X = e.X; //515
            Mouse_Y = e.Y; //172
            
        }
        private void ImageBox2_Click(object sender, EventArgs e)
        {
            if (imageBox2.Image != null)
            {
                Point center = new Point(Mouse_X, Mouse_Y);
                PointList.Add(new int[] { Mouse_X, Mouse_Y });
                MeasureCount++;
                MeasureCount %= 2;
                CvInvoke.Circle(Class_Variable.IMG_Operating, center, 10, new MCvScalar(255, 0, 0), 3);
                if (MeasureCount.Equals(0))
                {
                    Point pt1 = new Point(PointList[0][0], PointList[0][1]);
                    Point pt2 = new Point(PointList[1][0], PointList[1][1]);
                    CvInvoke.Line(imageBox2.Image, pt1, pt2, new MCvScalar(255, 0, 0), 2, LineType.AntiAlias);
                    PointList.Clear();
                    int LengthX = Math.Abs(pt1.X - pt2.X);
                    int LengthY = Math.Abs(pt1.Y - pt2.Y);
                    double LengthHypotenuse = Math.Sqrt(Math.Pow(LengthX, 2) + Math.Pow(LengthY, 2));
                    double Angle;
                    Angle = Math.Acos(LengthY/LengthHypotenuse);
                    Angle = Math.Abs(90 - Angle * (180 / Math.PI));
                    label_Angle.Text = Angle.ToString();
                }
              
            }
        }
        private void Main_Form_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void Panel_ROI_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Label_SpentTime_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Morphology_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        
    }
}
