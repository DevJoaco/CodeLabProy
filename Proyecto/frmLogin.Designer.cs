namespace Proyecto
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pIniciarSesión = new System.Windows.Forms.Panel();
            this.CERRAR = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.chbOcultarPasss = new System.Windows.Forms.CheckBox();
            this.btnIniciarSesión = new System.Windows.Forms.Button();
            this.pContraseñaIS = new System.Windows.Forms.Panel();
            this.txtContraseñaIS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pUsuarioIS = new System.Windows.Forms.Panel();
            this.txtUsuarioIS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pContenedor = new System.Windows.Forms.Panel();
            this.pPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pIniciarSesión.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.Black;
            this.pPrincipal.Controls.Add(this.btnRegistrarse);
            this.pPrincipal.Controls.Add(this.label2);
            this.pPrincipal.Controls.Add(this.label1);
            this.pPrincipal.Controls.Add(this.pictureBox2);
            this.pPrincipal.Location = new System.Drawing.Point(-2, 49);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1048, 631);
            this.pPrincipal.TabIndex = 0;
            this.pPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.Pprincipal_Paint);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarse.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarse.Location = new System.Drawing.Point(593, 469);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(398, 94);
            this.btnRegistrarse.TabIndex = 5;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            this.btnRegistrarse.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnRegistrarse.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(543, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registrate dando click al boton de abajo";
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(542, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Aun no tienes una cuenta?\r\n";
           
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(510, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(584, 474);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pIniciarSesión
            // 
            this.pIniciarSesión.Controls.Add(this.CERRAR);
            this.pIniciarSesión.Controls.Add(this.lblMensaje);
            this.pIniciarSesión.Controls.Add(this.chbOcultarPasss);
            this.pIniciarSesión.Controls.Add(this.btnIniciarSesión);
            this.pIniciarSesión.Controls.Add(this.pContraseñaIS);
            this.pIniciarSesión.Controls.Add(this.txtContraseñaIS);
            this.pIniciarSesión.Controls.Add(this.label10);
            this.pIniciarSesión.Controls.Add(this.pUsuarioIS);
            this.pIniciarSesión.Controls.Add(this.txtUsuarioIS);
            this.pIniciarSesión.Controls.Add(this.label11);
            this.pIniciarSesión.Controls.Add(this.label14);
            this.pIniciarSesión.Controls.Add(this.pictureBox1);
            this.pIniciarSesión.Location = new System.Drawing.Point(9, 3);
            this.pIniciarSesión.Name = "pIniciarSesión";
            this.pIniciarSesión.Size = new System.Drawing.Size(498, 685);
            this.pIniciarSesión.TabIndex = 15;
            
            // 
            // CERRAR
            // 
            this.CERRAR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CERRAR.BackColor = System.Drawing.Color.Firebrick;
            this.CERRAR.Font = new System.Drawing.Font("Montserrat Black", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CERRAR.ForeColor = System.Drawing.Color.Transparent;
            this.CERRAR.Location = new System.Drawing.Point(4, 0);
            this.CERRAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CERRAR.Name = "CERRAR";
            this.CERRAR.Size = new System.Drawing.Size(127, 51);
            this.CERRAR.TabIndex = 1;
            this.CERRAR.Text = "CERRAR";
            this.CERRAR.UseVisualStyleBackColor = false;
            
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(96, 446);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 20);
            this.lblMensaje.TabIndex = 16;
            // 
            // chbOcultarPasss
            // 
            this.chbOcultarPasss.AutoSize = true;
            this.chbOcultarPasss.Location = new System.Drawing.Point(406, 357);
            this.chbOcultarPasss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbOcultarPasss.Name = "chbOcultarPasss";
            this.chbOcultarPasss.Size = new System.Drawing.Size(86, 24);
            this.chbOcultarPasss.TabIndex = 15;
            this.chbOcultarPasss.Text = "Ocultar";
            this.chbOcultarPasss.UseVisualStyleBackColor = true;
            this.chbOcultarPasss.CheckedChanged += new System.EventHandler(this.chbOcultarPasss_CheckedChanged);
            // 
            // btnIniciarSesión
            // 
            this.btnIniciarSesión.BackColor = System.Drawing.Color.SeaGreen;
            this.btnIniciarSesión.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIniciarSesión.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIniciarSesión.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnIniciarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesión.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesión.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesión.Location = new System.Drawing.Point(64, 436);
            this.btnIniciarSesión.Name = "btnIniciarSesión";
            this.btnIniciarSesión.Size = new System.Drawing.Size(338, 77);
            this.btnIniciarSesión.TabIndex = 4;
            this.btnIniciarSesión.Text = "Iniciar Sesión";
            this.btnIniciarSesión.UseVisualStyleBackColor = false;
            this.btnIniciarSesión.Click += new System.EventHandler(this.btnIniciarSesión_Click);
            this.btnIniciarSesión.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnIniciarSesión_KeyPress);
            // 
            // pContraseñaIS
            // 
            this.pContraseñaIS.BackColor = System.Drawing.Color.Silver;
            this.pContraseñaIS.Location = new System.Drawing.Point(12, 389);
            this.pContraseñaIS.Name = "pContraseñaIS";
            this.pContraseñaIS.Size = new System.Drawing.Size(459, 3);
            this.pContraseñaIS.TabIndex = 13;
           
            // 
            // txtContraseñaIS
            // 
            this.txtContraseñaIS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseñaIS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaIS.Location = new System.Drawing.Point(150, 354);
            this.txtContraseñaIS.Name = "txtContraseñaIS";
            this.txtContraseñaIS.Size = new System.Drawing.Size(237, 28);
            this.txtContraseñaIS.TabIndex = 3;
            this.txtContraseñaIS.Tag = "Contraseña";
            this.txtContraseñaIS.Enter += new System.EventHandler(this.TextBoxContraseña_Enter);
            this.txtContraseñaIS.Leave += new System.EventHandler(this.TextBoxContraseña_Leave);
            this.txtContraseñaIS.MouseEnter += new System.EventHandler(this.TextBoxContraseña_MouseEnter);
            this.txtContraseñaIS.MouseLeave += new System.EventHandler(this.TextBoxContraseña_MouseLeave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 29);
            this.label10.TabIndex = 11;
            this.label10.Text = "Contraseña :";
            // 
            // pUsuarioIS
            // 
            this.pUsuarioIS.BackColor = System.Drawing.Color.Silver;
            this.pUsuarioIS.Location = new System.Drawing.Point(12, 262);
            this.pUsuarioIS.Name = "pUsuarioIS";
            this.pUsuarioIS.Size = new System.Drawing.Size(459, 3);
            this.pUsuarioIS.TabIndex = 10;
           
            // 
            // txtUsuarioIS
            // 
            this.txtUsuarioIS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioIS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioIS.Location = new System.Drawing.Point(119, 228);
            this.txtUsuarioIS.Name = "txtUsuarioIS";
            this.txtUsuarioIS.Size = new System.Drawing.Size(295, 28);
            this.txtUsuarioIS.TabIndex = 2;
            this.txtUsuarioIS.Tag = "Nombre De Usuario";
            this.txtUsuarioIS.Enter += new System.EventHandler(this.txtUsuarioIS_Enter);
            this.txtUsuarioIS.Leave += new System.EventHandler(this.txtUsuarioIS_Leave);
            this.txtUsuarioIS.MouseEnter += new System.EventHandler(this.txtUsuarioIS_MouseEnter);
            this.txtUsuarioIS.MouseLeave += new System.EventHandler(this.txtUsuarioIS_MouseLeave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 29);
            this.label11.TabIndex = 8;
            this.label11.Text = "Usuario :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(130, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(239, 44);
            this.label14.TabIndex = 1;
            this.label14.Text = "Iniciar Sesión";
            
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 530);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pContenedor
            // 
            this.pContenedor.BackColor = System.Drawing.Color.White;
            this.pContenedor.Controls.Add(this.pIniciarSesión);
            this.pContenedor.Location = new System.Drawing.Point(0, 9);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(510, 703);
            this.pContenedor.TabIndex = 6;
            
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1047, 726);
            this.Controls.Add(this.pContenedor);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agencia Libertad -Login";
            this.TransparencyKey = System.Drawing.Color.Lime;
          
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pIniciarSesión.ResumeLayout(false);
            this.pIniciarSesión.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pIniciarSesión;
        private System.Windows.Forms.Button btnIniciarSesión;
        private System.Windows.Forms.Panel pContraseñaIS;
        private System.Windows.Forms.TextBox txtContraseñaIS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pUsuarioIS;
        private System.Windows.Forms.TextBox txtUsuarioIS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pContenedor;
        private System.Windows.Forms.CheckBox chbOcultarPasss;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button CERRAR;
    }
}

