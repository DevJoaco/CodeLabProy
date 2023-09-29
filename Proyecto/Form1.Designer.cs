namespace Proyecto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pIniciarSesión = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.Button();
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
            this.pPrincipal.Location = new System.Drawing.Point(-1, 32);
            this.pPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(699, 410);
            this.pPrincipal.TabIndex = 0;
            this.pPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.Pprincipal_Paint);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.White;
            this.btnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarse.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarse.Location = new System.Drawing.Point(375, 305);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(302, 71);
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
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(359, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registrate dando click al boton de abajo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(370, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Aun no tienes una cuenta?\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(340, 58);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(389, 308);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pIniciarSesión
            // 
            this.pIniciarSesión.Controls.Add(this.Cerrar);
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
            this.pIniciarSesión.Location = new System.Drawing.Point(6, 2);
            this.pIniciarSesión.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pIniciarSesión.Name = "pIniciarSesión";
            this.pIniciarSesión.Size = new System.Drawing.Size(332, 445);
            this.pIniciarSesión.TabIndex = 15;
            this.pIniciarSesión.Paint += new System.Windows.Forms.PaintEventHandler(this.pIniciarSesión_Paint);
            this.pIniciarSesión.Enter += new System.EventHandler(this.txtEnter);
            this.pIniciarSesión.Leave += new System.EventHandler(this.txtLeave);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(3, 1);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(52, 26);
            this.Cerrar.TabIndex = 1;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(64, 290);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 16;
            // 
            // chbOcultarPasss
            // 
            this.chbOcultarPasss.AutoSize = true;
            this.chbOcultarPasss.Location = new System.Drawing.Point(254, 259);
            this.chbOcultarPasss.Name = "chbOcultarPasss";
            this.chbOcultarPasss.Size = new System.Drawing.Size(60, 17);
            this.chbOcultarPasss.TabIndex = 15;
            this.chbOcultarPasss.Text = "Ocultar";
            this.chbOcultarPasss.UseVisualStyleBackColor = true;
            this.chbOcultarPasss.CheckedChanged += new System.EventHandler(this.chbOcultarPasss_CheckedChanged);
            // 
            // btnIniciarSesión
            // 
            this.btnIniciarSesión.BackColor = System.Drawing.Color.Black;
            this.btnIniciarSesión.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIniciarSesión.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIniciarSesión.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnIniciarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesión.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesión.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesión.Location = new System.Drawing.Point(11, 368);
            this.btnIniciarSesión.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIniciarSesión.Name = "btnIniciarSesión";
            this.btnIniciarSesión.Size = new System.Drawing.Size(303, 56);
            this.btnIniciarSesión.TabIndex = 4;
            this.btnIniciarSesión.Text = "Iniciar Sesión";
            this.btnIniciarSesión.UseVisualStyleBackColor = false;
            this.btnIniciarSesión.Click += new System.EventHandler(this.btnIniciarSesión_Click);
            this.btnIniciarSesión.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnIniciarSesión_KeyPress);
            // 
            // pContraseñaIS
            // 
            this.pContraseñaIS.BackColor = System.Drawing.Color.Silver;
            this.pContraseñaIS.Location = new System.Drawing.Point(8, 277);
            this.pContraseñaIS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pContraseñaIS.Name = "pContraseñaIS";
            this.pContraseñaIS.Size = new System.Drawing.Size(306, 2);
            this.pContraseñaIS.TabIndex = 13;
            this.pContraseñaIS.Paint += new System.Windows.Forms.PaintEventHandler(this.pContraseñaIS_Paint);
            // 
            // txtContraseñaIS
            // 
            this.txtContraseñaIS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseñaIS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaIS.Location = new System.Drawing.Point(8, 257);
            this.txtContraseñaIS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContraseñaIS.Name = "txtContraseñaIS";
            this.txtContraseñaIS.Size = new System.Drawing.Size(306, 19);
            this.txtContraseñaIS.TabIndex = 3;
            this.txtContraseñaIS.Tag = "Contraseña";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 235);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Contraseña :";
            // 
            // pUsuarioIS
            // 
            this.pUsuarioIS.BackColor = System.Drawing.Color.Silver;
            this.pUsuarioIS.Location = new System.Drawing.Point(8, 191);
            this.pUsuarioIS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pUsuarioIS.Name = "pUsuarioIS";
            this.pUsuarioIS.Size = new System.Drawing.Size(306, 2);
            this.pUsuarioIS.TabIndex = 10;
            this.pUsuarioIS.Paint += new System.Windows.Forms.PaintEventHandler(this.pUsuarioIS_Paint);
            // 
            // txtUsuarioIS
            // 
            this.txtUsuarioIS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioIS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioIS.Location = new System.Drawing.Point(8, 169);
            this.txtUsuarioIS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuarioIS.Name = "txtUsuarioIS";
            this.txtUsuarioIS.Size = new System.Drawing.Size(306, 19);
            this.txtUsuarioIS.TabIndex = 2;
            this.txtUsuarioIS.Tag = "Nombre De Usuario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 147);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "Usuario :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(74, 66);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 30);
            this.label14.TabIndex = 1;
            this.label14.Text = "Iniciar Sesión";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pContenedor
            // 
            this.pContenedor.BackColor = System.Drawing.Color.White;
            this.pContenedor.Controls.Add(this.pIniciarSesión);
            this.pContenedor.Location = new System.Drawing.Point(0, 6);
            this.pContenedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(340, 457);
            this.pContenedor.TabIndex = 6;
            this.pContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pContenedor_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(698, 472);
            this.Controls.Add(this.pContenedor);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agencia Libertad -Login";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button Cerrar;
    }
}

