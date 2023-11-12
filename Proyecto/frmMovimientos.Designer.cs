namespace Proyecto
{
    partial class frmMovimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimientos));
            this.btnMCompras = new System.Windows.Forms.Button();
            this.btnMVentas = new System.Windows.Forms.Button();
            this.btnMPrestamos = new System.Windows.Forms.Button();
            this.pMovimientos = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnVolverMo = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbApellido = new System.Windows.Forms.RadioButton();
            this.rbDireccion = new System.Windows.Forms.RadioButton();
            this.rbCedula = new System.Windows.Forms.RadioButton();
            this.txtBuscadorr = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMovimientosRecientes = new System.Windows.Forms.Button();
            this.pMovimientos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMCompras
            // 
            this.btnMCompras.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCompras.Location = new System.Drawing.Point(11, 58);
            this.btnMCompras.Name = "btnMCompras";
            this.btnMCompras.Size = new System.Drawing.Size(158, 41);
            this.btnMCompras.TabIndex = 2;
            this.btnMCompras.Text = "Movimientos De Compras";
            this.btnMCompras.UseVisualStyleBackColor = false;
            this.btnMCompras.Click += new System.EventHandler(this.button1_Click);
            this.btnMCompras.MouseEnter += new System.EventHandler(this.btnMouseEnterMO);
            this.btnMCompras.MouseLeave += new System.EventHandler(this.btnMouseLeaveMO);
            // 
            // btnMVentas
            // 
            this.btnMVentas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.btnMVentas.Location = new System.Drawing.Point(11, 132);
            this.btnMVentas.Name = "btnMVentas";
            this.btnMVentas.Size = new System.Drawing.Size(158, 41);
            this.btnMVentas.TabIndex = 3;
            this.btnMVentas.Text = "Movimientos De Ventas";
            this.btnMVentas.UseVisualStyleBackColor = false;
            this.btnMVentas.Click += new System.EventHandler(this.button2_Click);
            this.btnMVentas.MouseEnter += new System.EventHandler(this.btnMouseEnterMO);
            this.btnMVentas.MouseLeave += new System.EventHandler(this.btnMouseLeaveMO);
            // 
            // btnMPrestamos
            // 
            this.btnMPrestamos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.btnMPrestamos.Location = new System.Drawing.Point(11, 197);
            this.btnMPrestamos.Name = "btnMPrestamos";
            this.btnMPrestamos.Size = new System.Drawing.Size(158, 43);
            this.btnMPrestamos.TabIndex = 4;
            this.btnMPrestamos.Text = "Movimientos De Prestamos";
            this.btnMPrestamos.UseVisualStyleBackColor = false;
            this.btnMPrestamos.Click += new System.EventHandler(this.button3_Click);
            this.btnMPrestamos.MouseEnter += new System.EventHandler(this.btnMouseEnterMO);
            this.btnMPrestamos.MouseLeave += new System.EventHandler(this.btnMouseLeaveMO);
            // 
            // pMovimientos
            // 
            this.pMovimientos.BackColor = System.Drawing.Color.SteelBlue;
            this.pMovimientos.Controls.Add(this.btnMovimientosRecientes);
            this.pMovimientos.Controls.Add(this.panel7);
            this.pMovimientos.Controls.Add(this.panel8);
            this.pMovimientos.Controls.Add(this.label1);
            this.pMovimientos.Controls.Add(this.btnMPrestamos);
            this.pMovimientos.Controls.Add(this.btnMCompras);
            this.pMovimientos.Controls.Add(this.btnMVentas);
            this.pMovimientos.Location = new System.Drawing.Point(790, 97);
            this.pMovimientos.Name = "pMovimientos";
            this.pMovimientos.Size = new System.Drawing.Size(210, 455);
            this.pMovimientos.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel7.Location = new System.Drawing.Point(-24, 390);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(238, 47);
            this.panel7.TabIndex = 18;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel8.Location = new System.Drawing.Point(183, -21);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(27, 430);
            this.panel8.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 42;
            this.label1.Text = "SELECCIONAR";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Location = new System.Drawing.Point(766, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(25, 435);
            this.panel5.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.btnVolverMo);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(-38, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1045, 71);
            this.panel3.TabIndex = 15;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(32, -35);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(202, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // btnVolverMo
            // 
            this.btnVolverMo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnVolverMo.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolverMo.Image = global::Proyecto.Properties.Resources.Botonvolveratras;
            this.btnVolverMo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverMo.Location = new System.Drawing.Point(818, 6);
            this.btnVolverMo.Name = "btnVolverMo";
            this.btnVolverMo.Size = new System.Drawing.Size(200, 57);
            this.btnVolverMo.TabIndex = 0;
            this.btnVolverMo.Text = "Volver";
            this.btnVolverMo.UseVisualStyleBackColor = false;
            this.btnVolverMo.Click += new System.EventHandler(this.btnVolverMo_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Location = new System.Drawing.Point(-38, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1042, 33);
            this.panel6.TabIndex = 14;
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Location = new System.Drawing.Point(38, 132);
            this.dgvMovimientos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.ReadOnly = true;
            this.dgvMovimientos.RowHeadersWidth = 51;
            this.dgvMovimientos.RowTemplate.Height = 24;
            this.dgvMovimientos.Size = new System.Drawing.Size(712, 260);
            this.dgvMovimientos.TabIndex = 20;
            this.dgvMovimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimientos_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(256, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 27);
            this.label7.TabIndex = 41;
            this.label7.Text = "HISTORIAL DE MOVIMIENTOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(-7, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 47);
            this.panel1.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 43;
            this.label2.Text = "BUSCADOR";
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.rbNombre.Location = new System.Drawing.Point(681, 397);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(74, 20);
            this.rbNombre.TabIndex = 44;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbApellido
            // 
            this.rbApellido.AutoSize = true;
            this.rbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.rbApellido.Location = new System.Drawing.Point(681, 417);
            this.rbApellido.Name = "rbApellido";
            this.rbApellido.Size = new System.Drawing.Size(75, 20);
            this.rbApellido.TabIndex = 45;
            this.rbApellido.TabStop = true;
            this.rbApellido.Text = "Apellido";
            this.rbApellido.UseVisualStyleBackColor = true;
            // 
            // rbDireccion
            // 
            this.rbDireccion.AutoSize = true;
            this.rbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.rbDireccion.Location = new System.Drawing.Point(681, 442);
            this.rbDireccion.Name = "rbDireccion";
            this.rbDireccion.Size = new System.Drawing.Size(82, 20);
            this.rbDireccion.TabIndex = 46;
            this.rbDireccion.TabStop = true;
            this.rbDireccion.Text = "Direccion";
            this.rbDireccion.UseVisualStyleBackColor = true;
            // 
            // rbCedula
            // 
            this.rbCedula.AutoSize = true;
            this.rbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.rbCedula.Location = new System.Drawing.Point(679, 462);
            this.rbCedula.Name = "rbCedula";
            this.rbCedula.Size = new System.Drawing.Size(68, 20);
            this.rbCedula.TabIndex = 47;
            this.rbCedula.TabStop = true;
            this.rbCedula.Text = "Cedula";
            this.rbCedula.UseVisualStyleBackColor = true;
            // 
            // txtBuscadorr
            // 
            this.txtBuscadorr.Location = new System.Drawing.Point(316, 441);
            this.txtBuscadorr.Name = "txtBuscadorr";
            this.txtBuscadorr.Size = new System.Drawing.Size(184, 20);
            this.txtBuscadorr.TabIndex = 48;
            this.txtBuscadorr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(-4, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(27, 400);
            this.panel2.TabIndex = 49;
            // 
            // btnMovimientosRecientes
            // 
            this.btnMovimientosRecientes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMovimientosRecientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.btnMovimientosRecientes.Location = new System.Drawing.Point(12, 277);
            this.btnMovimientosRecientes.Name = "btnMovimientosRecientes";
            this.btnMovimientosRecientes.Size = new System.Drawing.Size(158, 43);
            this.btnMovimientosRecientes.TabIndex = 43;
            this.btnMovimientosRecientes.Text = "Movimientos Recientes";
            this.btnMovimientosRecientes.UseVisualStyleBackColor = false;
            this.btnMovimientosRecientes.Click += new System.EventHandler(this.btnMovimientosRecientes_Click);
            // 
            // frmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBuscadorr);
            this.Controls.Add(this.rbCedula);
            this.Controls.Add(this.rbDireccion);
            this.Controls.Add(this.rbApellido);
            this.Controls.Add(this.rbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pMovimientos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvMovimientos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos";
            this.pMovimientos.ResumeLayout(false);
            this.pMovimientos.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMCompras;
        private System.Windows.Forms.Button btnMVentas;
        private System.Windows.Forms.Button btnMPrestamos;
        private System.Windows.Forms.Panel pMovimientos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnVolverMo;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbApellido;
        private System.Windows.Forms.RadioButton rbDireccion;
        private System.Windows.Forms.RadioButton rbCedula;
        private System.Windows.Forms.TextBox txtBuscadorr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMovimientosRecientes;
    }
}