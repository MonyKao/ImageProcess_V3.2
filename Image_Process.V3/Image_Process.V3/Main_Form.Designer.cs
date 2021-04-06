namespace Image_Process.V3
{
    partial class Main_Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_File = new System.Windows.Forms.Panel();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btn_SaveFile = new System.Windows.Forms.Button();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_Binarization = new System.Windows.Forms.Panel();
            this.btn_Vert = new System.Windows.Forms.Button();
            this.btn_Horiz = new System.Windows.Forms.Button();
            this.text_toZero = new System.Windows.Forms.TextBox();
            this.text_invbinary = new System.Windows.Forms.TextBox();
            this.text_binary = new System.Windows.Forms.TextBox();
            this.bar_toZero = new System.Windows.Forms.HScrollBar();
            this.label8 = new System.Windows.Forms.Label();
            this.bar_invbinary = new System.Windows.Forms.HScrollBar();
            this.label7 = new System.Windows.Forms.Label();
            this.bar_binary = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel_Filter = new System.Windows.Forms.Panel();
            this.numeric_blur = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numeric_gaussian = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numeric_median = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel_Morphology = new System.Windows.Forms.Panel();
            this.btn_thinning = new System.Windows.Forms.Button();
            this.numeric_Close = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numeric_Open = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numeric_Dilate = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numeric_Erosion = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel_EdgeInspect = new System.Windows.Forms.Panel();
            this.textBox_LineAngle = new System.Windows.Forms.TextBox();
            this.hScrollBar_LineAngle = new System.Windows.Forms.HScrollBar();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_FindEllipse = new System.Windows.Forms.Button();
            this.btn_FindDot = new System.Windows.Forms.Button();
            this.btn_HoughTriangle = new System.Windows.Forms.Button();
            this.btn_Houghline = new System.Windows.Forms.Button();
            this.btn_contour = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel_CornerDetector = new System.Windows.Forms.Panel();
            this.textBox_Angle = new System.Windows.Forms.TextBox();
            this.Bar_Angle = new System.Windows.Forms.HScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_FastCorner = new System.Windows.Forms.Button();
            this.btn_End = new System.Windows.Forms.Button();
            this.btn_StartX = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.panel_Matching = new System.Windows.Forms.Panel();
            this.btn_Fourier = new System.Windows.Forms.Button();
            this.label_NofContour = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_FD = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.panel_ROI = new System.Windows.Forms.Panel();
            this.btn_ROI = new System.Windows.Forms.Button();
            this.textBox_RectSize = new System.Windows.Forms.TextBox();
            this.bar_RectSize = new System.Windows.Forms.HScrollBar();
            this.btn_Center = new System.Windows.Forms.Button();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label_Angle = new System.Windows.Forms.Label();
            this.label_YCoor = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label_XCoor = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_DrawPoint = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_Histo = new System.Windows.Forms.Button();
            this.btn_ShowData = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label_SpentTime = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label_Width = new System.Windows.Forms.Label();
            this.label_Height = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_File.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_Binarization.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_blur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_gaussian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_median)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel_Morphology.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Dilate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Erosion)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panel_EdgeInspect.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel_CornerDetector.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel_Matching.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.panel_ROI.SuspendLayout();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1236, 128);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel_File);
            this.tabPage1.Controls.Add(this.btn_OpenFile);
            this.tabPage1.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1228, 96);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel_File
            // 
            this.panel_File.Controls.Add(this.btn_Restart);
            this.panel_File.Controls.Add(this.btn_SaveFile);
            this.panel_File.Enabled = false;
            this.panel_File.Location = new System.Drawing.Point(160, 3);
            this.panel_File.Name = "panel_File";
            this.panel_File.Size = new System.Drawing.Size(1062, 87);
            this.panel_File.TabIndex = 2;
            this.panel_File.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_File_Paint);
            // 
            // btn_Restart
            // 
            this.btn_Restart.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Restart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Restart.Location = new System.Drawing.Point(171, 20);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(144, 52);
            this.btn_Restart.TabIndex = 22;
            this.btn_Restart.Text = "Refresh";
            this.btn_Restart.UseVisualStyleBackColor = false;
            this.btn_Restart.Click += new System.EventHandler(this.Btn_Restart_Click);
            // 
            // btn_SaveFile
            // 
            this.btn_SaveFile.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_SaveFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_SaveFile.Location = new System.Drawing.Point(12, 20);
            this.btn_SaveFile.Name = "btn_SaveFile";
            this.btn_SaveFile.Size = new System.Drawing.Size(144, 52);
            this.btn_SaveFile.TabIndex = 21;
            this.btn_SaveFile.Text = "Save File";
            this.btn_SaveFile.UseVisualStyleBackColor = false;
            this.btn_SaveFile.Click += new System.EventHandler(this.Btn_SaveFile_Click);
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_OpenFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_OpenFile.Location = new System.Drawing.Point(9, 22);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(144, 52);
            this.btn_OpenFile.TabIndex = 1;
            this.btn_OpenFile.Text = "Open File";
            this.btn_OpenFile.UseVisualStyleBackColor = false;
            this.btn_OpenFile.Click += new System.EventHandler(this.Btn_OpenFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel_Binarization);
            this.tabPage2.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1228, 96);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Binarization";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel_Binarization
            // 
            this.panel_Binarization.Controls.Add(this.btn_Vert);
            this.panel_Binarization.Controls.Add(this.btn_Horiz);
            this.panel_Binarization.Controls.Add(this.text_toZero);
            this.panel_Binarization.Controls.Add(this.text_invbinary);
            this.panel_Binarization.Controls.Add(this.text_binary);
            this.panel_Binarization.Controls.Add(this.bar_toZero);
            this.panel_Binarization.Controls.Add(this.label8);
            this.panel_Binarization.Controls.Add(this.bar_invbinary);
            this.panel_Binarization.Controls.Add(this.label7);
            this.panel_Binarization.Controls.Add(this.bar_binary);
            this.panel_Binarization.Controls.Add(this.label6);
            this.panel_Binarization.Enabled = false;
            this.panel_Binarization.Location = new System.Drawing.Point(3, 3);
            this.panel_Binarization.Name = "panel_Binarization";
            this.panel_Binarization.Size = new System.Drawing.Size(1222, 87);
            this.panel_Binarization.TabIndex = 0;
            this.panel_Binarization.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Binarization_Paint);
            // 
            // btn_Vert
            // 
            this.btn_Vert.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Vert.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Vert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Vert.Location = new System.Drawing.Point(1066, 21);
            this.btn_Vert.Name = "btn_Vert";
            this.btn_Vert.Size = new System.Drawing.Size(148, 46);
            this.btn_Vert.TabIndex = 34;
            this.btn_Vert.Text = "Vert. Proj.";
            this.btn_Vert.UseVisualStyleBackColor = false;
            this.btn_Vert.Click += new System.EventHandler(this.Btn_Vert_Click);
            // 
            // btn_Horiz
            // 
            this.btn_Horiz.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Horiz.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Horiz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Horiz.Location = new System.Drawing.Point(902, 21);
            this.btn_Horiz.Name = "btn_Horiz";
            this.btn_Horiz.Size = new System.Drawing.Size(148, 46);
            this.btn_Horiz.TabIndex = 33;
            this.btn_Horiz.Text = "Horiz. Proj.";
            this.btn_Horiz.UseVisualStyleBackColor = false;
            this.btn_Horiz.Click += new System.EventHandler(this.Btn_Horiz_Click);
            // 
            // text_toZero
            // 
            this.text_toZero.Location = new System.Drawing.Point(814, 27);
            this.text_toZero.Name = "text_toZero";
            this.text_toZero.Size = new System.Drawing.Size(55, 37);
            this.text_toZero.TabIndex = 30;
            this.text_toZero.Text = "0";
            // 
            // text_invbinary
            // 
            this.text_invbinary.Location = new System.Drawing.Point(532, 28);
            this.text_invbinary.Name = "text_invbinary";
            this.text_invbinary.Size = new System.Drawing.Size(55, 37);
            this.text_invbinary.TabIndex = 27;
            this.text_invbinary.Text = "0";
            // 
            // text_binary
            // 
            this.text_binary.Location = new System.Drawing.Point(224, 28);
            this.text_binary.Name = "text_binary";
            this.text_binary.Size = new System.Drawing.Size(55, 37);
            this.text_binary.TabIndex = 24;
            this.text_binary.Text = "0";
            this.text_binary.TextChanged += new System.EventHandler(this.Text_binary_TextChanged);
            // 
            // bar_toZero
            // 
            this.bar_toZero.Location = new System.Drawing.Point(680, 32);
            this.bar_toZero.Maximum = 264;
            this.bar_toZero.Name = "bar_toZero";
            this.bar_toZero.Size = new System.Drawing.Size(132, 22);
            this.bar_toZero.TabIndex = 31;
            this.bar_toZero.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar_toZero_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(586, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 28);
            this.label8.TabIndex = 32;
            this.label8.Text = "ToZero";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // bar_invbinary
            // 
            this.bar_invbinary.Location = new System.Drawing.Point(398, 32);
            this.bar_invbinary.Maximum = 264;
            this.bar_invbinary.Name = "bar_invbinary";
            this.bar_invbinary.Size = new System.Drawing.Size(132, 22);
            this.bar_invbinary.TabIndex = 28;
            this.bar_invbinary.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar_invbinary_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(280, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 28);
            this.label7.TabIndex = 29;
            this.label7.Text = "Inv. Binary";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // bar_binary
            // 
            this.bar_binary.Location = new System.Drawing.Point(88, 32);
            this.bar_binary.Maximum = 264;
            this.bar_binary.Name = "bar_binary";
            this.bar_binary.Size = new System.Drawing.Size(132, 22);
            this.bar_binary.TabIndex = 25;
            this.bar_binary.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar_binary_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(8, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Binary";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel_Filter);
            this.tabPage3.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1228, 96);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Filter";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel_Filter
            // 
            this.panel_Filter.Controls.Add(this.numeric_blur);
            this.panel_Filter.Controls.Add(this.label11);
            this.panel_Filter.Controls.Add(this.numeric_gaussian);
            this.panel_Filter.Controls.Add(this.label10);
            this.panel_Filter.Controls.Add(this.numeric_median);
            this.panel_Filter.Controls.Add(this.label9);
            this.panel_Filter.Enabled = false;
            this.panel_Filter.Location = new System.Drawing.Point(3, 3);
            this.panel_Filter.Name = "panel_Filter";
            this.panel_Filter.Size = new System.Drawing.Size(1226, 93);
            this.panel_Filter.TabIndex = 0;
            this.panel_Filter.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Filter_Paint);
            // 
            // numeric_blur
            // 
            this.numeric_blur.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_blur.Location = new System.Drawing.Point(422, 44);
            this.numeric_blur.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numeric_blur.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numeric_blur.Name = "numeric_blur";
            this.numeric_blur.Size = new System.Drawing.Size(120, 37);
            this.numeric_blur.TabIndex = 28;
            this.numeric_blur.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numeric_blur.ValueChanged += new System.EventHandler(this.Numeric_blur_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(362, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 23);
            this.label11.TabIndex = 27;
            this.label11.Text = "Normal Filter";
            // 
            // numeric_gaussian
            // 
            this.numeric_gaussian.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_gaussian.Location = new System.Drawing.Point(218, 44);
            this.numeric_gaussian.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numeric_gaussian.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_gaussian.Name = "numeric_gaussian";
            this.numeric_gaussian.Size = new System.Drawing.Size(120, 37);
            this.numeric_gaussian.TabIndex = 26;
            this.numeric_gaussian.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_gaussian.ValueChanged += new System.EventHandler(this.Numeric_gaussian_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(164, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Gaussian Filter";
            // 
            // numeric_median
            // 
            this.numeric_median.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_median.Location = new System.Drawing.Point(34, 44);
            this.numeric_median.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numeric_median.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_median.Name = "numeric_median";
            this.numeric_median.Size = new System.Drawing.Size(120, 37);
            this.numeric_median.TabIndex = 24;
            this.numeric_median.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_median.ValueChanged += new System.EventHandler(this.Numeric_median_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(4, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Mean Filter";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel_Morphology);
            this.tabPage4.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1228, 96);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Morphology";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel_Morphology
            // 
            this.panel_Morphology.Controls.Add(this.btn_thinning);
            this.panel_Morphology.Controls.Add(this.numeric_Close);
            this.panel_Morphology.Controls.Add(this.label15);
            this.panel_Morphology.Controls.Add(this.numeric_Open);
            this.panel_Morphology.Controls.Add(this.label14);
            this.panel_Morphology.Controls.Add(this.numeric_Dilate);
            this.panel_Morphology.Controls.Add(this.label13);
            this.panel_Morphology.Controls.Add(this.numeric_Erosion);
            this.panel_Morphology.Controls.Add(this.label12);
            this.panel_Morphology.Enabled = false;
            this.panel_Morphology.Location = new System.Drawing.Point(6, 3);
            this.panel_Morphology.Name = "panel_Morphology";
            this.panel_Morphology.Size = new System.Drawing.Size(1214, 90);
            this.panel_Morphology.TabIndex = 0;
            this.panel_Morphology.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Morphology_Paint);
            // 
            // btn_thinning
            // 
            this.btn_thinning.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_thinning.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_thinning.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_thinning.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thinning.Location = new System.Drawing.Point(556, 22);
            this.btn_thinning.Name = "btn_thinning";
            this.btn_thinning.Size = new System.Drawing.Size(142, 45);
            this.btn_thinning.TabIndex = 37;
            this.btn_thinning.Text = "Skeleton";
            this.btn_thinning.UseVisualStyleBackColor = false;
            this.btn_thinning.Click += new System.EventHandler(this.Btn_thinning_Click);
            // 
            // numeric_Close
            // 
            this.numeric_Close.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_Close.Location = new System.Drawing.Point(418, 34);
            this.numeric_Close.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numeric_Close.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Close.Name = "numeric_Close";
            this.numeric_Close.Size = new System.Drawing.Size(120, 37);
            this.numeric_Close.TabIndex = 36;
            this.numeric_Close.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Close.ValueChanged += new System.EventHandler(this.Numeric_Close_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(398, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 23);
            this.label15.TabIndex = 35;
            this.label15.Text = "Close";
            // 
            // numeric_Open
            // 
            this.numeric_Open.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_Open.Location = new System.Drawing.Point(284, 34);
            this.numeric_Open.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numeric_Open.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Open.Name = "numeric_Open";
            this.numeric_Open.Size = new System.Drawing.Size(120, 37);
            this.numeric_Open.TabIndex = 34;
            this.numeric_Open.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Open.ValueChanged += new System.EventHandler(this.Numeric_Open_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(262, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 23);
            this.label14.TabIndex = 33;
            this.label14.Text = "Open";
            // 
            // numeric_Dilate
            // 
            this.numeric_Dilate.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_Dilate.Location = new System.Drawing.Point(154, 34);
            this.numeric_Dilate.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numeric_Dilate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Dilate.Name = "numeric_Dilate";
            this.numeric_Dilate.Size = new System.Drawing.Size(120, 37);
            this.numeric_Dilate.TabIndex = 32;
            this.numeric_Dilate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Dilate.ValueChanged += new System.EventHandler(this.Numeric_Dilate_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(134, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 23);
            this.label13.TabIndex = 31;
            this.label13.Text = "Dilate";
            // 
            // numeric_Erosion
            // 
            this.numeric_Erosion.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_Erosion.Location = new System.Drawing.Point(24, 34);
            this.numeric_Erosion.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.numeric_Erosion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Erosion.Name = "numeric_Erosion";
            this.numeric_Erosion.Size = new System.Drawing.Size(120, 37);
            this.numeric_Erosion.TabIndex = 30;
            this.numeric_Erosion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Erosion.ValueChanged += new System.EventHandler(this.Numeric_Erosion_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 23);
            this.label12.TabIndex = 29;
            this.label12.Text = "Ersion";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel_EdgeInspect);
            this.tabPage5.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1228, 96);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Edge Inspect";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel_EdgeInspect
            // 
            this.panel_EdgeInspect.Controls.Add(this.textBox_LineAngle);
            this.panel_EdgeInspect.Controls.Add(this.hScrollBar_LineAngle);
            this.panel_EdgeInspect.Controls.Add(this.label5);
            this.panel_EdgeInspect.Controls.Add(this.button2);
            this.panel_EdgeInspect.Controls.Add(this.btn_FindEllipse);
            this.panel_EdgeInspect.Controls.Add(this.btn_FindDot);
            this.panel_EdgeInspect.Controls.Add(this.btn_HoughTriangle);
            this.panel_EdgeInspect.Controls.Add(this.btn_Houghline);
            this.panel_EdgeInspect.Controls.Add(this.btn_contour);
            this.panel_EdgeInspect.Enabled = false;
            this.panel_EdgeInspect.Location = new System.Drawing.Point(6, 3);
            this.panel_EdgeInspect.Name = "panel_EdgeInspect";
            this.panel_EdgeInspect.Size = new System.Drawing.Size(1216, 90);
            this.panel_EdgeInspect.TabIndex = 0;
            this.panel_EdgeInspect.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_EdgeInspect_Paint);
            // 
            // textBox_LineAngle
            // 
            this.textBox_LineAngle.Location = new System.Drawing.Point(1148, 40);
            this.textBox_LineAngle.Name = "textBox_LineAngle";
            this.textBox_LineAngle.Size = new System.Drawing.Size(64, 37);
            this.textBox_LineAngle.TabIndex = 36;
            this.textBox_LineAngle.Text = "0";
            // 
            // hScrollBar_LineAngle
            // 
            this.hScrollBar_LineAngle.Location = new System.Drawing.Point(976, 50);
            this.hScrollBar_LineAngle.Maximum = 1000;
            this.hScrollBar_LineAngle.Name = "hScrollBar_LineAngle";
            this.hScrollBar_LineAngle.Size = new System.Drawing.Size(165, 22);
            this.hScrollBar_LineAngle.TabIndex = 35;
            this.hScrollBar_LineAngle.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar_LineAngle_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(974, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 30);
            this.label5.TabIndex = 34;
            this.label5.Text = "Threshold";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(669, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 45);
            this.button2.TabIndex = 26;
            this.button2.Text = "Sobel Y";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btn_FindEllipse
            // 
            this.btn_FindEllipse.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_FindEllipse.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_FindEllipse.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_FindEllipse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_FindEllipse.Location = new System.Drawing.Point(519, 24);
            this.btn_FindEllipse.Name = "btn_FindEllipse";
            this.btn_FindEllipse.Size = new System.Drawing.Size(144, 45);
            this.btn_FindEllipse.TabIndex = 25;
            this.btn_FindEllipse.Text = "Find Ellipse";
            this.btn_FindEllipse.UseVisualStyleBackColor = false;
            this.btn_FindEllipse.Click += new System.EventHandler(this.btn_FindEllipse_Click);
            // 
            // btn_FindDot
            // 
            this.btn_FindDot.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_FindDot.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_FindDot.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_FindDot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_FindDot.Location = new System.Drawing.Point(322, 24);
            this.btn_FindDot.Name = "btn_FindDot";
            this.btn_FindDot.Size = new System.Drawing.Size(190, 45);
            this.btn_FindDot.TabIndex = 24;
            this.btn_FindDot.Text = "Hough Circle";
            this.btn_FindDot.UseVisualStyleBackColor = false;
            this.btn_FindDot.Click += new System.EventHandler(this.Btn_FindDot_Click);
            // 
            // btn_HoughTriangle
            // 
            this.btn_HoughTriangle.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_HoughTriangle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_HoughTriangle.Enabled = false;
            this.btn_HoughTriangle.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_HoughTriangle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_HoughTriangle.Location = new System.Drawing.Point(128, 24);
            this.btn_HoughTriangle.Name = "btn_HoughTriangle";
            this.btn_HoughTriangle.Size = new System.Drawing.Size(190, 45);
            this.btn_HoughTriangle.TabIndex = 23;
            this.btn_HoughTriangle.Text = "Hough Triangle";
            this.btn_HoughTriangle.UseVisualStyleBackColor = false;
            this.btn_HoughTriangle.Click += new System.EventHandler(this.Btn_HoughTriangle_Click);
            // 
            // btn_Houghline
            // 
            this.btn_Houghline.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Houghline.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_Houghline.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Houghline.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Houghline.Location = new System.Drawing.Point(819, 24);
            this.btn_Houghline.Name = "btn_Houghline";
            this.btn_Houghline.Size = new System.Drawing.Size(148, 45);
            this.btn_Houghline.TabIndex = 22;
            this.btn_Houghline.Text = "Hough Line";
            this.btn_Houghline.UseVisualStyleBackColor = false;
            this.btn_Houghline.Click += new System.EventHandler(this.Btn_Houghline_Click);
            // 
            // btn_contour
            // 
            this.btn_contour.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_contour.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_contour.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_contour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_contour.Location = new System.Drawing.Point(16, 24);
            this.btn_contour.Name = "btn_contour";
            this.btn_contour.Size = new System.Drawing.Size(106, 45);
            this.btn_contour.TabIndex = 21;
            this.btn_contour.Text = "Canny";
            this.btn_contour.UseVisualStyleBackColor = false;
            this.btn_contour.Click += new System.EventHandler(this.Btn_contour_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.panel_CornerDetector);
            this.tabPage6.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1228, 96);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Corner Detector";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // panel_CornerDetector
            // 
            this.panel_CornerDetector.Controls.Add(this.textBox_Angle);
            this.panel_CornerDetector.Controls.Add(this.Bar_Angle);
            this.panel_CornerDetector.Controls.Add(this.label4);
            this.panel_CornerDetector.Controls.Add(this.btn_FastCorner);
            this.panel_CornerDetector.Controls.Add(this.btn_End);
            this.panel_CornerDetector.Controls.Add(this.btn_StartX);
            this.panel_CornerDetector.Enabled = false;
            this.panel_CornerDetector.Location = new System.Drawing.Point(2, 3);
            this.panel_CornerDetector.Name = "panel_CornerDetector";
            this.panel_CornerDetector.Size = new System.Drawing.Size(1216, 93);
            this.panel_CornerDetector.TabIndex = 0;
            // 
            // textBox_Angle
            // 
            this.textBox_Angle.Location = new System.Drawing.Point(1136, 33);
            this.textBox_Angle.Name = "textBox_Angle";
            this.textBox_Angle.Size = new System.Drawing.Size(64, 37);
            this.textBox_Angle.TabIndex = 33;
            this.textBox_Angle.Text = "0";
            // 
            // Bar_Angle
            // 
            this.Bar_Angle.Location = new System.Drawing.Point(956, 39);
            this.Bar_Angle.Maximum = 1000;
            this.Bar_Angle.Name = "Bar_Angle";
            this.Bar_Angle.Size = new System.Drawing.Size(165, 22);
            this.Bar_Angle.TabIndex = 32;
            this.Bar_Angle.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar_Angle_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(866, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 30);
            this.label4.TabIndex = 31;
            this.label4.Text = "Angle";
            // 
            // btn_FastCorner
            // 
            this.btn_FastCorner.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_FastCorner.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_FastCorner.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_FastCorner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_FastCorner.Location = new System.Drawing.Point(321, 26);
            this.btn_FastCorner.Name = "btn_FastCorner";
            this.btn_FastCorner.Size = new System.Drawing.Size(254, 45);
            this.btn_FastCorner.TabIndex = 29;
            this.btn_FastCorner.Text = "Fast Corner Detector";
            this.btn_FastCorner.UseVisualStyleBackColor = false;
            this.btn_FastCorner.Click += new System.EventHandler(this.Btn_FastCorner_Click);
            // 
            // btn_End
            // 
            this.btn_End.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_End.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_End.Enabled = false;
            this.btn_End.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_End.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_End.Location = new System.Drawing.Point(171, 26);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(144, 45);
            this.btn_End.TabIndex = 28;
            this.btn_End.Text = "Find End";
            this.btn_End.UseVisualStyleBackColor = false;
            this.btn_End.Click += new System.EventHandler(this.Btn_End_Click);
            // 
            // btn_StartX
            // 
            this.btn_StartX.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_StartX.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_StartX.Enabled = false;
            this.btn_StartX.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_StartX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_StartX.Location = new System.Drawing.Point(9, 26);
            this.btn_StartX.Name = "btn_StartX";
            this.btn_StartX.Size = new System.Drawing.Size(156, 45);
            this.btn_StartX.TabIndex = 27;
            this.btn_StartX.Text = "Find Start";
            this.btn_StartX.UseVisualStyleBackColor = false;
            this.btn_StartX.Click += new System.EventHandler(this.Btn_StartX_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.panel_Matching);
            this.tabPage7.Location = new System.Drawing.Point(4, 28);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1228, 96);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Matching";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // panel_Matching
            // 
            this.panel_Matching.Controls.Add(this.btn_Fourier);
            this.panel_Matching.Controls.Add(this.label_NofContour);
            this.panel_Matching.Controls.Add(this.label16);
            this.panel_Matching.Controls.Add(this.btn_FD);
            this.panel_Matching.Enabled = false;
            this.panel_Matching.Location = new System.Drawing.Point(6, 6);
            this.panel_Matching.Name = "panel_Matching";
            this.panel_Matching.Size = new System.Drawing.Size(1220, 87);
            this.panel_Matching.TabIndex = 0;
            // 
            // btn_Fourier
            // 
            this.btn_Fourier.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Fourier.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_Fourier.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Fourier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Fourier.Location = new System.Drawing.Point(410, 20);
            this.btn_Fourier.Name = "btn_Fourier";
            this.btn_Fourier.Size = new System.Drawing.Size(250, 52);
            this.btn_Fourier.TabIndex = 31;
            this.btn_Fourier.Text = "Fourier Descriptor";
            this.btn_Fourier.UseVisualStyleBackColor = false;
            this.btn_Fourier.Click += new System.EventHandler(this.Btn_Fourier_Click);
            // 
            // label_NofContour
            // 
            this.label_NofContour.AutoSize = true;
            this.label_NofContour.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_NofContour.Location = new System.Drawing.Point(380, 45);
            this.label_NofContour.Name = "label_NofContour";
            this.label_NofContour.Size = new System.Drawing.Size(25, 28);
            this.label_NofContour.TabIndex = 30;
            this.label_NofContour.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(147, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(226, 28);
            this.label16.TabIndex = 29;
            this.label16.Text = "Numbers of contour:";
            this.label16.Click += new System.EventHandler(this.Label16_Click);
            // 
            // btn_FD
            // 
            this.btn_FD.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_FD.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_FD.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_FD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_FD.Location = new System.Drawing.Point(15, 20);
            this.btn_FD.Name = "btn_FD";
            this.btn_FD.Size = new System.Drawing.Size(126, 52);
            this.btn_FD.TabIndex = 28;
            this.btn_FD.Text = "Contour";
            this.btn_FD.UseVisualStyleBackColor = false;
            this.btn_FD.Click += new System.EventHandler(this.Btn_FD_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.panel_ROI);
            this.tabPage8.Location = new System.Drawing.Point(4, 28);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1228, 96);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "ROI";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // panel_ROI
            // 
            this.panel_ROI.Controls.Add(this.btn_ROI);
            this.panel_ROI.Controls.Add(this.textBox_RectSize);
            this.panel_ROI.Controls.Add(this.bar_RectSize);
            this.panel_ROI.Controls.Add(this.btn_Center);
            this.panel_ROI.Enabled = false;
            this.panel_ROI.Location = new System.Drawing.Point(3, 3);
            this.panel_ROI.Name = "panel_ROI";
            this.panel_ROI.Size = new System.Drawing.Size(1220, 90);
            this.panel_ROI.TabIndex = 0;
            this.panel_ROI.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_ROI_Paint);
            // 
            // btn_ROI
            // 
            this.btn_ROI.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ROI.Location = new System.Drawing.Point(6, 20);
            this.btn_ROI.Name = "btn_ROI";
            this.btn_ROI.Size = new System.Drawing.Size(126, 52);
            this.btn_ROI.TabIndex = 26;
            this.btn_ROI.Text = "Cut";
            this.btn_ROI.UseVisualStyleBackColor = true;
            this.btn_ROI.Click += new System.EventHandler(this.Btn_ROI_Click);
            // 
            // textBox_RectSize
            // 
            this.textBox_RectSize.Location = new System.Drawing.Point(1154, 28);
            this.textBox_RectSize.Name = "textBox_RectSize";
            this.textBox_RectSize.Size = new System.Drawing.Size(55, 29);
            this.textBox_RectSize.TabIndex = 25;
            this.textBox_RectSize.Text = "0";
            // 
            // bar_RectSize
            // 
            this.bar_RectSize.Location = new System.Drawing.Point(906, 24);
            this.bar_RectSize.Maximum = 900;
            this.bar_RectSize.Minimum = 100;
            this.bar_RectSize.Name = "bar_RectSize";
            this.bar_RectSize.Size = new System.Drawing.Size(218, 26);
            this.bar_RectSize.TabIndex = 1;
            this.bar_RectSize.Value = 100;
            this.bar_RectSize.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar_RectSize_Scroll);
            // 
            // btn_Center
            // 
            this.btn_Center.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Center.Location = new System.Drawing.Point(754, 20);
            this.btn_Center.Name = "btn_Center";
            this.btn_Center.Size = new System.Drawing.Size(126, 52);
            this.btn_Center.TabIndex = 0;
            this.btn_Center.Text = "Center";
            this.btn_Center.UseVisualStyleBackColor = true;
            this.btn_Center.Click += new System.EventHandler(this.Btn_Center_Click);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.label22);
            this.tabPage9.Controls.Add(this.label_Angle);
            this.tabPage9.Controls.Add(this.label_YCoor);
            this.tabPage9.Controls.Add(this.label23);
            this.tabPage9.Controls.Add(this.label_XCoor);
            this.tabPage9.Controls.Add(this.label21);
            this.tabPage9.Controls.Add(this.btn_DrawPoint);
            this.tabPage9.Location = new System.Drawing.Point(4, 28);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1228, 96);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Draw Point";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label22.Location = new System.Drawing.Point(381, 47);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(105, 28);
            this.label22.TabIndex = 6;
            this.label22.Text = "直線角度:";
            // 
            // label_Angle
            // 
            this.label_Angle.AutoSize = true;
            this.label_Angle.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Angle.Location = new System.Drawing.Point(502, 47);
            this.label_Angle.Name = "label_Angle";
            this.label_Angle.Size = new System.Drawing.Size(22, 28);
            this.label_Angle.TabIndex = 5;
            this.label_Angle.Text = "*";
            // 
            // label_YCoor
            // 
            this.label_YCoor.AutoSize = true;
            this.label_YCoor.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_YCoor.Location = new System.Drawing.Point(283, 40);
            this.label_YCoor.Name = "label_YCoor";
            this.label_YCoor.Size = new System.Drawing.Size(18, 23);
            this.label_YCoor.TabIndex = 4;
            this.label_YCoor.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label23.Location = new System.Drawing.Point(252, 40);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 23);
            this.label23.TabIndex = 3;
            this.label23.Text = "Y:";
            // 
            // label_XCoor
            // 
            this.label_XCoor.AutoSize = true;
            this.label_XCoor.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_XCoor.Location = new System.Drawing.Point(182, 40);
            this.label_XCoor.Name = "label_XCoor";
            this.label_XCoor.Size = new System.Drawing.Size(18, 23);
            this.label_XCoor.TabIndex = 2;
            this.label_XCoor.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label21.Location = new System.Drawing.Point(151, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 23);
            this.label21.TabIndex = 1;
            this.label21.Text = "X:";
            // 
            // btn_DrawPoint
            // 
            this.btn_DrawPoint.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_DrawPoint.Location = new System.Drawing.Point(9, 23);
            this.btn_DrawPoint.Name = "btn_DrawPoint";
            this.btn_DrawPoint.Size = new System.Drawing.Size(126, 52);
            this.btn_DrawPoint.TabIndex = 0;
            this.btn_DrawPoint.Text = "Draw Point";
            this.btn_DrawPoint.UseVisualStyleBackColor = true;
            this.btn_DrawPoint.Click += new System.EventHandler(this.Btn_DrawPoint_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.imageBox1.Location = new System.Drawing.Point(8, 136);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(600, 600);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.imageBox2.Location = new System.Drawing.Point(628, 136);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(600, 600);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox2.TabIndex = 3;
            this.imageBox2.TabStop = false;
            this.imageBox2.Click += new System.EventHandler(this.ImageBox2_Click);
            this.imageBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageBox2_MouseDown);
            this.imageBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImageBox2_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(818, 778);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Processing Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(196, 778);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Original Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(10, 868);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Author: Mony Kao";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1166, 807);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(63, 88);
            this.exit.TabIndex = 11;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btn_result
            // 
            this.btn_result.Enabled = false;
            this.btn_result.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_result.Location = new System.Drawing.Point(628, 776);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(154, 50);
            this.btn_result.TabIndex = 29;
            this.btn_result.Text = "Use Result";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.Btn_result_Click);
            // 
            // btn_Histo
            // 
            this.btn_Histo.Enabled = false;
            this.btn_Histo.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Histo.Location = new System.Drawing.Point(243, 846);
            this.btn_Histo.Name = "btn_Histo";
            this.btn_Histo.Size = new System.Drawing.Size(230, 50);
            this.btn_Histo.TabIndex = 30;
            this.btn_Histo.Text = "Show Histogram";
            this.btn_Histo.UseVisualStyleBackColor = true;
            this.btn_Histo.Click += new System.EventHandler(this.Btn_Histo_Click);
            // 
            // btn_ShowData
            // 
            this.btn_ShowData.Enabled = false;
            this.btn_ShowData.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ShowData.Location = new System.Drawing.Point(478, 846);
            this.btn_ShowData.Name = "btn_ShowData";
            this.btn_ShowData.Size = new System.Drawing.Size(230, 50);
            this.btn_ShowData.TabIndex = 31;
            this.btn_ShowData.Text = "Show Data";
            this.btn_ShowData.UseVisualStyleBackColor = true;
            this.btn_ShowData.Click += new System.EventHandler(this.Btn_ShowData_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(1007, 833);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 29);
            this.label18.TabIndex = 34;
            this.label18.Text = "ms";
            this.label18.Click += new System.EventHandler(this.Label18_Click);
            // 
            // label_SpentTime
            // 
            this.label_SpentTime.AutoSize = true;
            this.label_SpentTime.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_SpentTime.Location = new System.Drawing.Point(885, 833);
            this.label_SpentTime.Name = "label_SpentTime";
            this.label_SpentTime.Size = new System.Drawing.Size(23, 29);
            this.label_SpentTime.TabIndex = 33;
            this.label_SpentTime.Text = "*";
            this.label_SpentTime.Click += new System.EventHandler(this.Label_SpentTime_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(714, 833);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 29);
            this.label17.TabIndex = 32;
            this.label17.Text = "Running Time:";
            this.label17.Click += new System.EventHandler(this.Label17_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(714, 868);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 29);
            this.label19.TabIndex = 35;
            this.label19.Text = "Width:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(927, 868);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 29);
            this.label20.TabIndex = 36;
            this.label20.Text = "Height:";
            // 
            // label_Width
            // 
            this.label_Width.AutoSize = true;
            this.label_Width.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Width.Location = new System.Drawing.Point(798, 871);
            this.label_Width.Name = "label_Width";
            this.label_Width.Size = new System.Drawing.Size(23, 29);
            this.label_Width.TabIndex = 37;
            this.label_Width.Text = "*";
            // 
            // label_Height
            // 
            this.label_Height.AutoSize = true;
            this.label_Height.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Height.Location = new System.Drawing.Point(1025, 871);
            this.label_Height.Name = "label_Height";
            this.label_Height.Size = new System.Drawing.Size(23, 29);
            this.label_Height.TabIndex = 38;
            this.label_Height.Text = "*";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 904);
            this.Controls.Add(this.label_Height);
            this.Controls.Add(this.label_Width);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label_SpentTime);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_ShowData);
            this.Controls.Add(this.btn_Histo);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main_Form";
            this.Text = "Image Process.V3";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_Form_MouseClick);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel_File.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel_Binarization.ResumeLayout(false);
            this.panel_Binarization.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel_Filter.ResumeLayout(false);
            this.panel_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_blur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_gaussian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_median)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel_Morphology.ResumeLayout(false);
            this.panel_Morphology.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Dilate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Erosion)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.panel_EdgeInspect.ResumeLayout(false);
            this.panel_EdgeInspect.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.panel_CornerDetector.ResumeLayout(false);
            this.panel_CornerDetector.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.panel_Matching.ResumeLayout(false);
            this.panel_Matching.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.panel_ROI.ResumeLayout(false);
            this.panel_ROI.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_File;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Button btn_SaveFile;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel_Binarization;
        private System.Windows.Forms.TextBox text_toZero;
        private System.Windows.Forms.TextBox text_invbinary;
        private System.Windows.Forms.TextBox text_binary;
        private System.Windows.Forms.HScrollBar bar_toZero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.HScrollBar bar_invbinary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.HScrollBar bar_binary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Vert;
        private System.Windows.Forms.Button btn_Horiz;
        private System.Windows.Forms.Panel panel_Filter;
        private System.Windows.Forms.NumericUpDown numeric_blur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numeric_gaussian;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numeric_median;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Panel panel_Morphology;
        private System.Windows.Forms.Button btn_thinning;
        private System.Windows.Forms.NumericUpDown numeric_Close;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numeric_Open;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numeric_Dilate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numeric_Erosion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel_EdgeInspect;
        private System.Windows.Forms.Button btn_FindDot;
        private System.Windows.Forms.Button btn_HoughTriangle;
        private System.Windows.Forms.Button btn_Houghline;
        private System.Windows.Forms.Button btn_contour;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_FindEllipse;
        private System.Windows.Forms.Button btn_Histo;
        private System.Windows.Forms.Panel panel_CornerDetector;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.Button btn_StartX;
        private System.Windows.Forms.Button btn_FastCorner;
        private System.Windows.Forms.TextBox textBox_Angle;
        private System.Windows.Forms.HScrollBar Bar_Angle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_LineAngle;
        private System.Windows.Forms.HScrollBar hScrollBar_LineAngle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ShowData;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Panel panel_Matching;
        private System.Windows.Forms.Button btn_FD;
        private System.Windows.Forms.Label label_NofContour;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_Fourier;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Panel panel_ROI;
        private System.Windows.Forms.Button btn_Center;
        private System.Windows.Forms.TextBox textBox_RectSize;
        private System.Windows.Forms.HScrollBar bar_RectSize;
        private System.Windows.Forms.Button btn_ROI;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label_SpentTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label_Width;
        private System.Windows.Forms.Label label_Height;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button btn_DrawPoint;
        private System.Windows.Forms.Label label_YCoor;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label_XCoor;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label_Angle;
        private System.Windows.Forms.Label label22;
    }
}

