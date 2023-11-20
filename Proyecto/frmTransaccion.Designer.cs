namespace Proyecto
{
    partial class frmTransaccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaccion));
            this.btnVolverT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtComprobar = new System.Windows.Forms.TextBox();
            this.txtArbitrajeV = new System.Windows.Forms.TextBox();
            this.txtArbitrajeC = new System.Windows.Forms.TextBox();
            this.pVenta = new System.Windows.Forms.Panel();
            this.rbVentaT = new System.Windows.Forms.RadioButton();
            this.pCompra = new System.Windows.Forms.Panel();
            this.rbCompraT = new System.Windows.Forms.RadioButton();
            this.txtMontoVentaM = new System.Windows.Forms.TextBox();
            this.txtMontoCompraM = new System.Windows.Forms.TextBox();
            this.lblCotizacionWeb = new System.Windows.Forms.Label();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.lblMonedaDoy = new System.Windows.Forms.Label();
            this.lblMonedaRecibo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblValorTransaccion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClienteRecibe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbModoAM = new System.Windows.Forms.ComboBox();
            this.cmbMonedaVT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbClientesT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMonedasT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoCompraT = new System.Windows.Forms.TextBox();
            this.txtMontoVentaT = new System.Windows.Forms.TextBox();
            this.txtMontoT = new System.Windows.Forms.TextBox();
            this.btnIngresarT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pVenta.SuspendLayout();
            this.pCompra.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverT
            // 
            this.btnVolverT.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVolverT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverT.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolverT.Image = global::Proyecto.Properties.Resources.Botonvolveratras1;
            this.btnVolverT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverT.Location = new System.Drawing.Point(644, 3);
            this.btnVolverT.Name = "btnVolverT";
            this.btnVolverT.Size = new System.Drawing.Size(175, 76);
            this.btnVolverT.TabIndex = 3;
            this.btnVolverT.Text = "Volver";
            this.btnVolverT.UseVisualStyleBackColor = false;
            this.btnVolverT.Click += new System.EventHandler(this.btnVolverT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtComprobar);
            this.panel1.Controls.Add(this.txtArbitrajeV);
            this.panel1.Controls.Add(this.txtArbitrajeC);
            this.panel1.Controls.Add(this.pVenta);
            this.panel1.Controls.Add(this.pCompra);
            this.panel1.Controls.Add(this.txtMontoVentaM);
            this.panel1.Controls.Add(this.txtMontoCompraM);
            this.panel1.Controls.Add(this.lblCotizacionWeb);
            this.panel1.Controls.Add(this.txtGanancia);
            this.panel1.Controls.Add(this.lblMonedaDoy);
            this.panel1.Controls.Add(this.lblMonedaRecibo);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblMoneda);
            this.panel1.Controls.Add(this.lblValorTransaccion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtClienteRecibe);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbModoAM);
            this.panel1.Controls.Add(this.cmbMonedaVT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbClientesT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbMonedasT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMontoCompraT);
            this.panel1.Controls.Add(this.txtMontoVentaT);
            this.panel1.Controls.Add(this.txtMontoT);
            this.panel1.Controls.Add(this.btnIngresarT);
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 434);
            this.panel1.TabIndex = 2;
            
            // 
            // txtComprobar
            // 
            this.txtComprobar.Location = new System.Drawing.Point(722, 47);
            this.txtComprobar.Margin = new System.Windows.Forms.Padding(2);
            this.txtComprobar.Name = "txtComprobar";
            this.txtComprobar.Size = new System.Drawing.Size(48, 20);
            this.txtComprobar.TabIndex = 41;
            this.txtComprobar.Visible = false;
            // 
            // txtArbitrajeV
            // 
            this.txtArbitrajeV.Location = new System.Drawing.Point(722, 25);
            this.txtArbitrajeV.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbitrajeV.Name = "txtArbitrajeV";
            this.txtArbitrajeV.Size = new System.Drawing.Size(48, 20);
            this.txtArbitrajeV.TabIndex = 40;
            this.txtArbitrajeV.Visible = false;
            // 
            // txtArbitrajeC
            // 
            this.txtArbitrajeC.Location = new System.Drawing.Point(722, 2);
            this.txtArbitrajeC.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbitrajeC.Name = "txtArbitrajeC";
            this.txtArbitrajeC.Size = new System.Drawing.Size(48, 20);
            this.txtArbitrajeC.TabIndex = 39;
            this.txtArbitrajeC.Visible = false;
            // 
            // pVenta
            // 
            this.pVenta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pVenta.Controls.Add(this.rbVentaT);
            this.pVenta.Location = new System.Drawing.Point(31, 67);
            this.pVenta.Margin = new System.Windows.Forms.Padding(2);
            this.pVenta.Name = "pVenta";
            this.pVenta.Size = new System.Drawing.Size(118, 54);
            this.pVenta.TabIndex = 37;
            // 
            // rbVentaT
            // 
            this.rbVentaT.AutoSize = true;
            this.rbVentaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVentaT.Location = new System.Drawing.Point(15, 15);
            this.rbVentaT.Name = "rbVentaT";
            this.rbVentaT.Size = new System.Drawing.Size(87, 30);
            this.rbVentaT.TabIndex = 21;
            this.rbVentaT.Text = "Venta";
            this.rbVentaT.UseVisualStyleBackColor = true;
            this.rbVentaT.CheckedChanged += new System.EventHandler(this.rbVentaT_CheckedChanged);
            // 
            // pCompra
            // 
            this.pCompra.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pCompra.Controls.Add(this.rbCompraT);
            this.pCompra.Location = new System.Drawing.Point(31, 5);
            this.pCompra.Margin = new System.Windows.Forms.Padding(2);
            this.pCompra.Name = "pCompra";
            this.pCompra.Size = new System.Drawing.Size(118, 49);
            this.pCompra.TabIndex = 36;
            // 
            // rbCompraT
            // 
            this.rbCompraT.AutoSize = true;
            this.rbCompraT.Checked = true;
            this.rbCompraT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCompraT.Location = new System.Drawing.Point(3, 12);
            this.rbCompraT.Name = "rbCompraT";
            this.rbCompraT.Size = new System.Drawing.Size(100, 29);
            this.rbCompraT.TabIndex = 1;
            this.rbCompraT.TabStop = true;
            this.rbCompraT.Text = "Compra";
            this.rbCompraT.UseVisualStyleBackColor = true;
            this.rbCompraT.CheckedChanged += new System.EventHandler(this.rbCompraT_CheckedChanged);
            // 
            // txtMontoVentaM
            // 
            this.txtMontoVentaM.Location = new System.Drawing.Point(184, 258);
            this.txtMontoVentaM.Margin = new System.Windows.Forms.Padding(2);
            this.txtMontoVentaM.Name = "txtMontoVentaM";
            this.txtMontoVentaM.Size = new System.Drawing.Size(147, 20);
            this.txtMontoVentaM.TabIndex = 35;
            this.txtMontoVentaM.Visible = false;
            // 
            // txtMontoCompraM
            // 
            this.txtMontoCompraM.Location = new System.Drawing.Point(184, 124);
            this.txtMontoCompraM.Margin = new System.Windows.Forms.Padding(2);
            this.txtMontoCompraM.Name = "txtMontoCompraM";
            this.txtMontoCompraM.Size = new System.Drawing.Size(147, 20);
            this.txtMontoCompraM.TabIndex = 34;
            this.txtMontoCompraM.Visible = false;
            // 
            // lblCotizacionWeb
            // 
            this.lblCotizacionWeb.AutoSize = true;
            this.lblCotizacionWeb.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacionWeb.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCotizacionWeb.Location = new System.Drawing.Point(376, 301);
            this.lblCotizacionWeb.Name = "lblCotizacionWeb";
            this.lblCotizacionWeb.Size = new System.Drawing.Size(185, 16);
            this.lblCotizacionWeb.TabIndex = 23;
            this.lblCotizacionWeb.Text = "Actualizar Cotizaciones.\r\n";
            this.lblCotizacionWeb.Click += new System.EventHandler(this.lblCotizacionWeb_Click);
            this.lblCotizacionWeb.MouseLeave += new System.EventHandler(this.lblCotizacionWeb_MouseLeave);
            this.lblCotizacionWeb.MouseHover += new System.EventHandler(this.lblCotizacionWeb_MouseHover);
            // 
            // txtGanancia
            // 
            this.txtGanancia.Location = new System.Drawing.Point(659, 85);
            this.txtGanancia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(65, 20);
            this.txtGanancia.TabIndex = 33;
            // 
            // lblMonedaDoy
            // 
            this.lblMonedaDoy.AutoSize = true;
            this.lblMonedaDoy.Location = new System.Drawing.Point(352, 201);
            this.lblMonedaDoy.Name = "lblMonedaDoy";
            this.lblMonedaDoy.Size = new System.Drawing.Size(10, 13);
            this.lblMonedaDoy.TabIndex = 32;
            this.lblMonedaDoy.Text = "-";
            // 
            // lblMonedaRecibo
            // 
            this.lblMonedaRecibo.AutoSize = true;
            this.lblMonedaRecibo.Location = new System.Drawing.Point(352, 110);
            this.lblMonedaRecibo.Name = "lblMonedaRecibo";
            this.lblMonedaRecibo.Size = new System.Drawing.Size(10, 13);
            this.lblMonedaRecibo.TabIndex = 31;
            this.lblMonedaRecibo.Text = "-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Location = new System.Drawing.Point(3, 396);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(784, 32);
            this.panel5.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Location = new System.Drawing.Point(-1, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 439);
            this.panel4.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(773, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 435);
            this.panel2.TabIndex = 27;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblMoneda.Location = new System.Drawing.Point(201, 14);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(108, 16);
            this.lblMoneda.TabIndex = 22;
            this.lblMoneda.Text = "Moneda Compra";
            // 
            // lblValorTransaccion
            // 
            this.lblValorTransaccion.AutoSize = true;
            this.lblValorTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblValorTransaccion.Location = new System.Drawing.Point(201, 215);
            this.lblValorTransaccion.Name = "lblValorTransaccion";
            this.lblValorTransaccion.Size = new System.Drawing.Size(120, 16);
            this.lblValorTransaccion.TabIndex = 20;
            this.lblValorTransaccion.Text = " Valor Transaccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(422, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cliente Recibe";
            // 
            // txtClienteRecibe
            // 
            this.txtClienteRecibe.Location = new System.Drawing.Point(395, 198);
            this.txtClienteRecibe.Name = "txtClienteRecibe";
            this.txtClienteRecibe.Size = new System.Drawing.Size(147, 20);
            this.txtClienteRecibe.TabIndex = 18;
            this.txtClienteRecibe.TextChanged += new System.EventHandler(this.txtClienteRecibe_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(193, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Moneda Transaccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(568, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Manual  |  Automatica";
            // 
            // cmbModoAM
            // 
            this.cmbModoAM.FormattingEnabled = true;
            this.cmbModoAM.Items.AddRange(new object[] {
            "Manual",
            "Automatico"});
            this.cmbModoAM.Location = new System.Drawing.Point(594, 367);
            this.cmbModoAM.Name = "cmbModoAM";
            this.cmbModoAM.Size = new System.Drawing.Size(147, 21);
            this.cmbModoAM.TabIndex = 15;
            this.cmbModoAM.SelectedIndexChanged += new System.EventHandler(this.cmbModoAM_SelectedIndexChanged);
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
            this.cmbMonedaVT.Location = new System.Drawing.Point(184, 34);
            this.cmbMonedaVT.Name = "cmbMonedaVT";
            this.cmbMonedaVT.Size = new System.Drawing.Size(147, 21);
            this.cmbMonedaVT.TabIndex = 13;
            this.cmbMonedaVT.SelectedIndexChanged += new System.EventHandler(this.cmbMonedasVT_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(445, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cliente";
            // 
            // cmbClientesT
            // 
            this.cmbClientesT.FormattingEnabled = true;
            this.cmbClientesT.Items.AddRange(new object[] {
            "Manual",
            "Automatica"});
            this.cmbClientesT.Location = new System.Drawing.Point(395, 34);
            this.cmbClientesT.Name = "cmbClientesT";
            this.cmbClientesT.Size = new System.Drawing.Size(147, 21);
            this.cmbClientesT.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(193, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cotizacion Moneda";
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
            this.cmbMonedasT.Location = new System.Drawing.Point(184, 186);
            this.cmbMonedasT.Name = "cmbMonedasT";
            this.cmbMonedasT.Size = new System.Drawing.Size(147, 21);
            this.cmbMonedasT.TabIndex = 7;
            this.cmbMonedasT.SelectedIndexChanged += new System.EventHandler(this.cmbMonedasT_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(422, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Agencia Recibe";
            // 
            // txtMontoCompraT
            // 
            this.txtMontoCompraT.Location = new System.Drawing.Point(184, 235);
            this.txtMontoCompraT.Name = "txtMontoCompraT";
            this.txtMontoCompraT.Size = new System.Drawing.Size(147, 20);
            this.txtMontoCompraT.TabIndex = 5;
            // 
            // txtMontoVentaT
            // 
            this.txtMontoVentaT.Location = new System.Drawing.Point(184, 91);
            this.txtMontoVentaT.Name = "txtMontoVentaT";
            this.txtMontoVentaT.Size = new System.Drawing.Size(147, 20);
            this.txtMontoVentaT.TabIndex = 4;
            // 
            // txtMontoT
            // 
            this.txtMontoT.Location = new System.Drawing.Point(395, 108);
            this.txtMontoT.Name = "txtMontoT";
            this.txtMontoT.Size = new System.Drawing.Size(147, 20);
            this.txtMontoT.TabIndex = 3;
            this.txtMontoT.TextChanged += new System.EventHandler(this.txtMontoT_TextChanged);
            // 
            // btnIngresarT
            // 
            this.btnIngresarT.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIngresarT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresarT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarT.Location = new System.Drawing.Point(359, 247);
            this.btnIngresarT.Name = "btnIngresarT";
            this.btnIngresarT.Size = new System.Drawing.Size(205, 39);
            this.btnIngresarT.TabIndex = 0;
            this.btnIngresarT.Text = "Ingresar";
            this.btnIngresarT.UseVisualStyleBackColor = false;
            this.btnIngresarT.Click += new System.EventHandler(this.btnIngresarT_Click);
            this.btnIngresarT.MouseEnter += new System.EventHandler(this.btnMouseEnterT);
            this.btnIngresarT.MouseLeave += new System.EventHandler(this.btnMouseLeaveT);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.btnVolverT);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(0, -7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 71);
            this.panel3.TabIndex = 27;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-27, -37);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(202, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Location = new System.Drawing.Point(0, 62);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 44);
            this.panel6.TabIndex = 26;
            // 
            // frmTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaccion";
            this.Load += new System.EventHandler(this.Transaccion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pVenta.ResumeLayout(false);
            this.pVenta.PerformLayout();
            this.pCompra.ResumeLayout(false);
            this.pCompra.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolverT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMonedasT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontoCompraT;
        private System.Windows.Forms.TextBox txtMontoVentaT;
        private System.Windows.Forms.TextBox txtMontoT;
        private System.Windows.Forms.RadioButton rbCompraT;
        private System.Windows.Forms.Button btnIngresarT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbClientesT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cmbMonedaVT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbModoAM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClienteRecibe;
        private System.Windows.Forms.Label lblValorTransaccion;
        private System.Windows.Forms.RadioButton rbVentaT;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblMonedaDoy;
        private System.Windows.Forms.Label lblMonedaRecibo;
        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.Label lblCotizacionWeb;
        private System.Windows.Forms.Panel pCompra;
        private System.Windows.Forms.Panel pVenta;
        private System.Windows.Forms.TextBox txtMontoVentaM;
        private System.Windows.Forms.TextBox txtMontoCompraM;
        private System.Windows.Forms.TextBox txtArbitrajeV;
        private System.Windows.Forms.TextBox txtArbitrajeC;
        private System.Windows.Forms.TextBox txtComprobar;
    }
}