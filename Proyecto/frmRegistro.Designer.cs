namespace Proyecto
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.btnAcceder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pRegistro = new System.Windows.Forms.Panel();
            this.rbEmpleado = new System.Windows.Forms.RadioButton();
            this.rbJefe = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.chbOcultarPasss2 = new System.Windows.Forms.CheckBox();
            this.pApellido = new System.Windows.Forms.Panel();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pContraseña = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pUsuario = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pGmail = new System.Windows.Forms.Panel();
            this.pNombre = new System.Windows.Forms.Panel();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbLogo1 = new System.Windows.Forms.PictureBox();
            this.pPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcceder.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.Transparent;
            this.btnAcceder.Location = new System.Drawing.Point(73, 459);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(359, 99);
            this.btnAcceder.TabIndex = 7;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            this.btnAcceder.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnAcceder.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingresa dandole click al boton de abajo";
           
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 18.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "¿Ya tienes una cuenta?\r\n";
            
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.Black;
            this.pPrincipal.Controls.Add(this.label4);
            this.pPrincipal.Controls.Add(this.label3);
            this.pPrincipal.Controls.Add(this.btnAcceder);
            this.pPrincipal.Controls.Add(this.pictureBox2);
            this.pPrincipal.Location = new System.Drawing.Point(0, 49);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1048, 631);
            this.pPrincipal.TabIndex = 8;
            
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-27, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(584, 474);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pRegistro
            // 
            this.pRegistro.BackColor = System.Drawing.Color.White;
            this.pRegistro.Controls.Add(this.rbEmpleado);
            this.pRegistro.Controls.Add(this.rbJefe);
            this.pRegistro.Controls.Add(this.label2);
            this.pRegistro.Controls.Add(this.chbOcultarPasss2);
            this.pRegistro.Controls.Add(this.pApellido);
            this.pRegistro.Controls.Add(this.txtApellido);
            this.pRegistro.Controls.Add(this.label1);
            this.pRegistro.Controls.Add(this.btnRegistrar);
            this.pRegistro.Controls.Add(this.pContraseña);
            this.pRegistro.Controls.Add(this.txtContraseña);
            this.pRegistro.Controls.Add(this.label9);
            this.pRegistro.Controls.Add(this.pUsuario);
            this.pRegistro.Controls.Add(this.txtUsuario);
            this.pRegistro.Controls.Add(this.label8);
            this.pRegistro.Controls.Add(this.pGmail);
            this.pRegistro.Controls.Add(this.pNombre);
            this.pRegistro.Controls.Add(this.txtGmail);
            this.pRegistro.Controls.Add(this.txtNombre);
            this.pRegistro.Controls.Add(this.label7);
            this.pRegistro.Controls.Add(this.label6);
            this.pRegistro.Controls.Add(this.label5);
            this.pRegistro.Controls.Add(this.pbLogo1);
            this.pRegistro.Location = new System.Drawing.Point(522, 9);
            this.pRegistro.Name = "pRegistro";
            this.pRegistro.Size = new System.Drawing.Size(510, 703);
            this.pRegistro.TabIndex = 9;
            // 
            // rbEmpleado
            // 
            this.rbEmpleado.AutoSize = true;
            this.rbEmpleado.Location = new System.Drawing.Point(273, 542);
            this.rbEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbEmpleado.Name = "rbEmpleado";
            this.rbEmpleado.Size = new System.Drawing.Size(106, 24);
            this.rbEmpleado.TabIndex = 20;
            this.rbEmpleado.TabStop = true;
            this.rbEmpleado.Text = "Empleado";
            this.rbEmpleado.UseVisualStyleBackColor = true;
            
            // 
            // rbJefe
            // 
            this.rbJefe.AutoSize = true;
            this.rbJefe.Location = new System.Drawing.Point(153, 542);
            this.rbJefe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbJefe.Name = "rbJefe";
            this.rbJefe.Size = new System.Drawing.Size(65, 24);
            this.rbJefe.TabIndex = 19;
            this.rbJefe.TabStop = true;
            this.rbJefe.Text = "Jefe";
            this.rbJefe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cargo :";
            // 
            // chbOcultarPasss2
            // 
            this.chbOcultarPasss2.AutoSize = true;
            this.chbOcultarPasss2.Location = new System.Drawing.Point(392, 469);
            this.chbOcultarPasss2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbOcultarPasss2.Name = "chbOcultarPasss2";
            this.chbOcultarPasss2.Size = new System.Drawing.Size(86, 24);
            this.chbOcultarPasss2.TabIndex = 8;
            this.chbOcultarPasss2.TabStop = false;
            this.chbOcultarPasss2.Text = "Ocultar";
            this.chbOcultarPasss2.UseVisualStyleBackColor = true;
            this.chbOcultarPasss2.CheckedChanged += new System.EventHandler(this.chbOcultarPasss2_CheckedChanged);
            // 
            // pApellido
            // 
            this.pApellido.BackColor = System.Drawing.Color.Silver;
            this.pApellido.Location = new System.Drawing.Point(44, 271);
            this.pApellido.Name = "pApellido";
            this.pApellido.Size = new System.Drawing.Size(438, 3);
            this.pApellido.TabIndex = 17;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(44, 237);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(438, 28);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Tag = "Nombre";
            this.txtApellido.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtApellido.Leave += new System.EventHandler(this.TextBox_Leave);
            this.txtApellido.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
            this.txtApellido.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Apellido :";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(115, 592);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(290, 76);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pContraseña
            // 
            this.pContraseña.BackColor = System.Drawing.Color.Silver;
            this.pContraseña.Location = new System.Drawing.Point(40, 514);
            this.pContraseña.Name = "pContraseña";
            this.pContraseña.Size = new System.Drawing.Size(438, 3);
            this.pContraseña.TabIndex = 13;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(40, 488);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(438, 28);
            this.txtContraseña.TabIndex = 5;
            this.txtContraseña.Tag = "Contraseña";
            this.txtContraseña.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.TextBox_Leave);
            this.txtContraseña.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
            this.txtContraseña.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "Contraseña :";
            // 
            // pUsuario
            // 
            this.pUsuario.BackColor = System.Drawing.Color.Silver;
            this.pUsuario.Location = new System.Drawing.Point(44, 437);
            this.pUsuario.Name = "pUsuario";
            this.pUsuario.Size = new System.Drawing.Size(438, 3);
            this.pUsuario.TabIndex = 10;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(44, 403);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(438, 28);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Tag = "Nombre De Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.TextBox_Leave);
            this.txtUsuario.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
            this.txtUsuario.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Usuario :";
            // 
            // pGmail
            // 
            this.pGmail.BackColor = System.Drawing.Color.Silver;
            this.pGmail.Location = new System.Drawing.Point(44, 357);
            this.pGmail.Name = "pGmail";
            this.pGmail.Size = new System.Drawing.Size(438, 3);
            this.pGmail.TabIndex = 7;
            // 
            // pNombre
            // 
            this.pNombre.BackColor = System.Drawing.Color.Silver;
            this.pNombre.Location = new System.Drawing.Point(40, 189);
            this.pNombre.Name = "pNombre";
            this.pNombre.Size = new System.Drawing.Size(438, 3);
            this.pNombre.TabIndex = 4;
            // 
            // txtGmail
            // 
            this.txtGmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGmail.Location = new System.Drawing.Point(44, 323);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(438, 28);
            this.txtGmail.TabIndex = 3;
            this.txtGmail.Tag = "Correo Electronico";
            this.txtGmail.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtGmail.Leave += new System.EventHandler(this.TextBox_Leave);
            this.txtGmail.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
            this.txtGmail.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(44, 158);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(438, 28);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Tag = "Nombre";
            this.txtNombre.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.TextBox_Leave);
            this.txtNombre.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
            this.txtNombre.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 29);
            this.label7.TabIndex = 5;
            this.label7.Tag = "";
            this.label7.Text = "Gmail :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(144, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 54);
            this.label5.TabIndex = 1;
            this.label5.Text = "Registro";
            // 
            // pbLogo1
            // 
            this.pbLogo1.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo1.Image")));
            this.pbLogo1.Location = new System.Drawing.Point(351, 0);
            this.pbLogo1.Name = "pbLogo1";
            this.pbLogo1.Size = new System.Drawing.Size(158, 152);
            this.pbLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo1.TabIndex = 0;
            this.pbLogo1.TabStop = false;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1047, 726);
            this.Controls.Add(this.pRegistro);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pRegistro.ResumeLayout(false);
            this.pRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Panel pRegistro;
        private System.Windows.Forms.RadioButton rbEmpleado;
        private System.Windows.Forms.RadioButton rbJefe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbOcultarPasss2;
        private System.Windows.Forms.Panel pApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel pContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pGmail;
        private System.Windows.Forms.Panel pNombre;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbLogo1;
    }
}