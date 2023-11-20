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
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Volver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMontoVG = new System.Windows.Forms.TextBox();
            this.txtMontoCG = new System.Windows.Forms.TextBox();
            this.cmbTipoGrafico = new System.Windows.Forms.ComboBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartGanancias12)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartGanancias12
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGanancias12.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGanancias12.Legends.Add(legend1);
            this.chartGanancias12.Location = new System.Drawing.Point(25, 98);
            this.chartGanancias12.Name = "chartGanancias12";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Blue;
            series1.LabelForeColor = System.Drawing.Color.AliceBlue;
            series1.Legend = "Legend1";
            series1.Name = "Ganancias";
            this.chartGanancias12.Series.Add(series1);
            this.chartGanancias12.Size = new System.Drawing.Size(653, 371);
            this.chartGanancias12.TabIndex = 0;
            this.chartGanancias12.Text = "chart1";
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPrestamo.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPrestamo.Location = new System.Drawing.Point(17, 41);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(143, 45);
            this.btnPrestamo.TabIndex = 1;
            this.btnPrestamo.Text = "PRESTAMOS";
            this.btnPrestamo.UseVisualStyleBackColor = false;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click_1);
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCompra.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCompra.Location = new System.Drawing.Point(20, 221);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(143, 45);
            this.btnCompra.TabIndex = 2;
            this.btnCompra.Text = "COMPRAS";
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click_1);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.CadetBlue;
            this.btnVenta.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnVenta.Location = new System.Drawing.Point(20, 289);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(143, 45);
            this.btnVenta.TabIndex = 3;
            this.btnVenta.Text = "VENTAS";
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click_1);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(239, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 18);
            this.Label1.TabIndex = 4;
            // 
            // Volver
            // 
            this.Volver.BackColor = System.Drawing.Color.CadetBlue;
            this.Volver.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Volver.Location = new System.Drawing.Point(720, 25);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(143, 45);
            this.Volver.TabIndex = 5;
            this.Volver.Text = "VOLVER";
            this.Volver.UseVisualStyleBackColor = false;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.txtMontoVG);
            this.panel1.Controls.Add(this.txtMontoCG);
            this.panel1.Controls.Add(this.cmbTipoGrafico);
            this.panel1.Controls.Add(this.lblSalida);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.Volver);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 91);
            this.panel1.TabIndex = 6;
            // 
            // txtMontoVG
            // 
            this.txtMontoVG.Location = new System.Drawing.Point(288, 0);
            this.txtMontoVG.Name = "txtMontoVG";
            this.txtMontoVG.Size = new System.Drawing.Size(100, 20);
            this.txtMontoVG.TabIndex = 26;
            this.txtMontoVG.Visible = false;
            // 
            // txtMontoCG
            // 
            this.txtMontoCG.Location = new System.Drawing.Point(182, 0);
            this.txtMontoCG.Name = "txtMontoCG";
            this.txtMontoCG.Size = new System.Drawing.Size(100, 20);
            this.txtMontoCG.TabIndex = 25;
            this.txtMontoCG.Visible = false;
            // 
            // cmbTipoGrafico
            // 
            this.cmbTipoGrafico.FormattingEnabled = true;
            this.cmbTipoGrafico.Location = new System.Drawing.Point(572, 38);
            this.cmbTipoGrafico.Name = "cmbTipoGrafico";
            this.cmbTipoGrafico.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoGrafico.TabIndex = 4;
            this.cmbTipoGrafico.SelectedIndexChanged += new System.EventHandler(this.cmbTipoGrafico_SelectedIndexChanged);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.Location = new System.Drawing.Point(199, 29);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(333, 27);
            this.lblSalida.TabIndex = 24;
            this.lblSalida.Text = "REGISTROS DE GANANCIAS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-25, -31);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(202, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(677, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 437);
            this.panel4.TabIndex = 38;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel8.Location = new System.Drawing.Point(0, 79);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(876, 26);
            this.panel8.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(27, 403);
            this.panel2.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(25, 471);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 27);
            this.panel3.TabIndex = 53;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.btnPrestamo);
            this.panel5.Controls.Add(this.btnVenta);
            this.panel5.Controls.Add(this.btnCompra);
            this.panel5.Location = new System.Drawing.Point(703, 111);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 358);
            this.panel5.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "TRANSACCIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "PRESTAMOS";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Location = new System.Drawing.Point(0, 146);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(173, 26);
            this.panel6.TabIndex = 52;
            // 
            // frmGraficas
            // 
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(875, 497);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.chartGanancias12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGraficas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmGraficas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGanancias12)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGanancias;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGanancias12;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.ComboBox cmbTipoGrafico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoVG;
        private System.Windows.Forms.TextBox txtMontoCG;
    }
}