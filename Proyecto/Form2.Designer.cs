namespace Proyecto
{
    partial class Form2
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
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbLogo1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.pNombre = new System.Windows.Forms.Panel();
            this.pGmail = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pUsuario = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.pContraseña = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pRegistro = new System.Windows.Forms.Panel();
            this.pPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).BeginInit();
            this.pRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.Black;
            this.pPrincipal.Controls.Add(this.btnAcceder);
            this.pPrincipal.Controls.Add(this.label3);
            this.pPrincipal.Controls.Add(this.label4);
            this.pPrincipal.Location = new System.Drawing.Point(0, 40);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(800, 370);
            this.pPrincipal.TabIndex = 8;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.Transparent;
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(40, 202);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(331, 41);
            this.btnAcceder.TabIndex = 5;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            this.btnAcceder.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnAcceder.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingresa dandole click al boton de abajo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "¿Ya cuentas con una cuenta?\r\n";
            // 
            // pbLogo1
            // 
            this.pbLogo1.Image = global::Proyecto.Properties.Resources.CodeLabLogo;
            this.pbLogo1.Location = new System.Drawing.Point(152, 8);
            this.pbLogo1.Name = "pbLogo1";
            this.pbLogo1.Size = new System.Drawing.Size(70, 70);
            this.pbLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo1.TabIndex = 0;
            this.pbLogo1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "Registro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 5;
            this.label7.Tag = "";
            this.label7.Text = "Gmail :";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(10, 136);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(362, 23);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Tag = "Nombre";
            // 
            // txtGmail
            // 
            this.txtGmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGmail.Location = new System.Drawing.Point(10, 196);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(362, 23);
            this.txtGmail.TabIndex = 6;
            this.txtGmail.Tag = "Correo Electronico";
            // 
            // pNombre
            // 
            this.pNombre.BackColor = System.Drawing.Color.Silver;
            this.pNombre.Location = new System.Drawing.Point(10, 163);
            this.pNombre.Name = "pNombre";
            this.pNombre.Size = new System.Drawing.Size(362, 3);
            this.pNombre.TabIndex = 4;
            // 
            // pGmail
            // 
            this.pGmail.BackColor = System.Drawing.Color.Silver;
            this.pGmail.Location = new System.Drawing.Point(10, 223);
            this.pGmail.Name = "pGmail";
            this.pGmail.Size = new System.Drawing.Size(362, 3);
            this.pGmail.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Usuario :";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(10, 260);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(362, 23);
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.Tag = "Nombre De Usuario";
            // 
            // pUsuario
            // 
            this.pUsuario.BackColor = System.Drawing.Color.Silver;
            this.pUsuario.Location = new System.Drawing.Point(10, 287);
            this.pUsuario.Name = "pUsuario";
            this.pUsuario.Size = new System.Drawing.Size(362, 3);
            this.pUsuario.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Contraseña :";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(10, 336);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(362, 23);
            this.txtContraseña.TabIndex = 12;
            this.txtContraseña.Tag = "Contraseña";
            // 
            // pContraseña
            // 
            this.pContraseña.BackColor = System.Drawing.Color.Silver;
            this.pContraseña.Location = new System.Drawing.Point(10, 363);
            this.pContraseña.Name = "pContraseña";
            this.pContraseña.Size = new System.Drawing.Size(362, 3);
            this.pContraseña.TabIndex = 13;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(10, 372);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(362, 41);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // pRegistro
            // 
            this.pRegistro.BackColor = System.Drawing.Color.White;
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
            this.pRegistro.Location = new System.Drawing.Point(407, 12);
            this.pRegistro.Name = "pRegistro";
            this.pRegistro.Size = new System.Drawing.Size(390, 420);
            this.pRegistro.TabIndex = 8;
            this.pRegistro.Paint += new System.Windows.Forms.PaintEventHandler(this.pRegistro_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pRegistro);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).EndInit();
            this.pRegistro.ResumeLayout(false);
            this.pRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbLogo1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.Panel pNombre;
        private System.Windows.Forms.Panel pGmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel pUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Panel pContraseña;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel pRegistro;
    }
}