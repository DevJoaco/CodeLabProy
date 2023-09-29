namespace Proyecto
{
    partial class Transaccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaccion));
            this.btnVolverT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMonedaVT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbClientesT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMonedasT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoCompraT = new System.Windows.Forms.TextBox();
            this.txtMontoVentaT = new System.Windows.Forms.TextBox();
            this.txtMontoT = new System.Windows.Forms.TextBox();
            this.rbVentaT = new System.Windows.Forms.RadioButton();
            this.rbCompraT = new System.Windows.Forms.RadioButton();
            this.btnIngresarT = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverT
            // 
            this.btnVolverT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVolverT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverT.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolverT.Image = global::Proyecto.Properties.Resources.Botonvolveratras1;
            this.btnVolverT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverT.Location = new System.Drawing.Point(859, 4);
            this.btnVolverT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolverT.Name = "btnVolverT";
            this.btnVolverT.Size = new System.Drawing.Size(233, 94);
            this.btnVolverT.TabIndex = 3;
            this.btnVolverT.Text = "Volver";
            this.btnVolverT.UseVisualStyleBackColor = false;
            this.btnVolverT.Click += new System.EventHandler(this.btnVolverT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbMonedaVT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbClientesT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbMonedasT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMontoCompraT);
            this.panel1.Controls.Add(this.txtMontoVentaT);
            this.panel1.Controls.Add(this.txtMontoT);
            this.panel1.Controls.Add(this.rbVentaT);
            this.panel1.Controls.Add(this.rbCompraT);
            this.panel1.Controls.Add(this.btnIngresarT);
            this.panel1.Location = new System.Drawing.Point(293, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 457);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "MONEDA Venta";
            // 
            // cmbMonedaVT
            // 
            this.cmbMonedaVT.FormattingEnabled = true;
            this.cmbMonedaVT.Items.AddRange(new object[] {
            "MONEDA1",
            "MONEDA2",
            "MONEDA3",
            "MONEDA4",
            "MONEDA5"});
            this.cmbMonedaVT.Location = new System.Drawing.Point(200, 159);
            this.cmbMonedaVT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMonedaVT.Name = "cmbMonedaVT";
            this.cmbMonedaVT.Size = new System.Drawing.Size(160, 24);
            this.cmbMonedaVT.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Clientes";
            // 
            // cmbClientesT
            // 
            this.cmbClientesT.FormattingEnabled = true;
            this.cmbClientesT.Location = new System.Drawing.Point(200, 66);
            this.cmbClientesT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClientesT.Name = "cmbClientesT";
            this.cmbClientesT.Size = new System.Drawing.Size(195, 24);
            this.cmbClientesT.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Monto De Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Monto De Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "MONEDA COMPRA";
            // 
            // cmbMonedasT
            // 
            this.cmbMonedasT.FormattingEnabled = true;
            this.cmbMonedasT.Items.AddRange(new object[] {
            "MONEDA1",
            "MONEDA2",
            "MONEDA3",
            "MONEDA4",
            "MONEDA5"});
            this.cmbMonedasT.Location = new System.Drawing.Point(200, 113);
            this.cmbMonedasT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMonedasT.Name = "cmbMonedasT";
            this.cmbMonedasT.Size = new System.Drawing.Size(160, 24);
            this.cmbMonedasT.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "MONTO A CAMBIAR";
            // 
            // txtMontoCompraT
            // 
            this.txtMontoCompraT.Location = new System.Drawing.Point(200, 254);
            this.txtMontoCompraT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontoCompraT.Name = "txtMontoCompraT";
            this.txtMontoCompraT.Size = new System.Drawing.Size(132, 22);
            this.txtMontoCompraT.TabIndex = 5;
            // 
            // txtMontoVentaT
            // 
            this.txtMontoVentaT.Location = new System.Drawing.Point(200, 293);
            this.txtMontoVentaT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontoVentaT.Name = "txtMontoVentaT";
            this.txtMontoVentaT.Size = new System.Drawing.Size(132, 22);
            this.txtMontoVentaT.TabIndex = 4;
            // 
            // txtMontoT
            // 
            this.txtMontoT.Location = new System.Drawing.Point(200, 208);
            this.txtMontoT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontoT.Name = "txtMontoT";
            this.txtMontoT.Size = new System.Drawing.Size(132, 22);
            this.txtMontoT.TabIndex = 3;
            // 
            // rbVentaT
            // 
            this.rbVentaT.AutoSize = true;
            this.rbVentaT.Location = new System.Drawing.Point(377, 335);
            this.rbVentaT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbVentaT.Name = "rbVentaT";
            this.rbVentaT.Size = new System.Drawing.Size(63, 20);
            this.rbVentaT.TabIndex = 2;
            this.rbVentaT.TabStop = true;
            this.rbVentaT.Text = "Venta";
            this.rbVentaT.UseVisualStyleBackColor = true;
            // 
            // rbCompraT
            // 
            this.rbCompraT.AutoSize = true;
            this.rbCompraT.Location = new System.Drawing.Point(95, 335);
            this.rbCompraT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCompraT.Name = "rbCompraT";
            this.rbCompraT.Size = new System.Drawing.Size(76, 20);
            this.rbCompraT.TabIndex = 1;
            this.rbCompraT.TabStop = true;
            this.rbCompraT.Text = "Compra";
            this.rbCompraT.UseVisualStyleBackColor = true;
            // 
            // btnIngresarT
            // 
            this.btnIngresarT.Location = new System.Drawing.Point(217, 394);
            this.btnIngresarT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIngresarT.Name = "btnIngresarT";
            this.btnIngresarT.Size = new System.Drawing.Size(100, 28);
            this.btnIngresarT.TabIndex = 0;
            this.btnIngresarT.Text = "Ingresar";
            this.btnIngresarT.UseVisualStyleBackColor = true;
            this.btnIngresarT.Click += new System.EventHandler(this.btnIngresarT_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Location = new System.Drawing.Point(793, 102);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(35, 462);
            this.panel5.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Location = new System.Drawing.Point(263, 102);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(33, 462);
            this.panel4.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.btnVolverT);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(0, -9);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 87);
            this.panel3.TabIndex = 27;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(420, -46);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(269, 185);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Location = new System.Drawing.Point(0, 76);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1067, 31);
            this.panel6.TabIndex = 26;
            // 
            // Transaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaccion";
            this.Load += new System.EventHandler(this.Transaccion_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolverT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMonedasT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontoCompraT;
        private System.Windows.Forms.TextBox txtMontoVentaT;
        private System.Windows.Forms.TextBox txtMontoT;
        private System.Windows.Forms.RadioButton rbVentaT;
        private System.Windows.Forms.RadioButton rbCompraT;
        private System.Windows.Forms.Button btnIngresarT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbClientesT;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMonedaVT;
    }
}