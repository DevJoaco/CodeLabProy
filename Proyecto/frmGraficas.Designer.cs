namespace Proyecto
{
    partial class frmGraficas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraficas));
            this.chartGanancias12 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartGanancias12)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGanancias12
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGanancias12.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGanancias12.Legends.Add(legend1);
            this.chartGanancias12.Location = new System.Drawing.Point(128, 32);
            this.chartGanancias12.Name = "chartGanancias12";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGanancias12.Series.Add(series1);
            this.chartGanancias12.Size = new System.Drawing.Size(552, 300);
            this.chartGanancias12.TabIndex = 0;
            this.chartGanancias12.Text = "chart1";
            // 
            // frmGraficas
            // 
            this.ClientSize = new System.Drawing.Size(820, 397);
            this.Controls.Add(this.chartGanancias12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGraficas";
            ((System.ComponentModel.ISupportInitialize)(this.chartGanancias12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGanancias;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGanancias12;
    }
}