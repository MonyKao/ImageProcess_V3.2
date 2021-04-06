namespace Image_Process.V3
{
    partial class Form_Histogram
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
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.SuspendLayout();
            // 
            // histogramBox1
            // 
            this.histogramBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.histogramBox1.Location = new System.Drawing.Point(0, 1);
            this.histogramBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(893, 694);
            this.histogramBox1.TabIndex = 0;
            // 
            // Form_Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 699);
            this.Controls.Add(this.histogramBox1);
            this.Name = "Form_Histogram";
            this.Text = "Form_Histogram";
            this.ResumeLayout(false);

        }

        #endregion

        public Emgu.CV.UI.HistogramBox histogramBox1;
    }
}