using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto
{
    public partial class frmRegistro : Form
    {
        private Conexion miConexion;
       

        public frmRegistro()
        {
            InitializeComponent();
            miConexion = new Conexion();
            chbOcultarPasss2.Checked = true;

            txtNombre.MouseEnter += TextBox_MouseEnter;
            txtNombre.MouseLeave += TextBox_MouseLeave;
            txtNombre.Enter += TextBox_Enter;
            txtNombre.Leave += TextBox_Leave;

            pNombre.MouseEnter += Panel_MouseEnter;
            pNombre.MouseLeave += Panel_MouseLeave;

            txtApellido.MouseEnter += TextBox_MouseEnter;
            txtApellido.MouseLeave += TextBox_MouseLeave;
            txtApellido.Enter += TextBox_Enter;
            txtApellido.Leave += TextBox_Leave;

            pApellido.MouseEnter += Panel_MouseEnter;
            pApellido.MouseLeave += Panel_MouseLeave;

            txtGmail.MouseEnter += TextBox_MouseEnter;
            txtGmail.MouseLeave += TextBox_MouseLeave;
            txtGmail.Enter += TextBox_Enter;
            txtGmail.Leave += TextBox_Leave;

            pGmail.MouseEnter += Panel_MouseEnter;
            pGmail.MouseLeave += Panel_MouseLeave;

            txtUsuario.MouseEnter += TextBox_MouseEnter;
            txtUsuario.MouseLeave += TextBox_MouseLeave;
            txtUsuario.Enter += TextBox_Enter;
            txtUsuario.Leave += TextBox_Leave;

            pUsuario.MouseEnter += Panel_MouseEnter;
            pUsuario.MouseLeave += Panel_MouseLeave;

            txtContraseña.MouseEnter += TextBox_MouseEnter;
            txtContraseña.MouseLeave += TextBox_MouseLeave;
            txtContraseña.Enter += TextBox_Enter;
            txtContraseña.Leave += TextBox_Leave;

            pContraseña.MouseEnter += Panel_MouseEnter;
            pContraseña.MouseLeave += Panel_MouseLeave;
      
        }




        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button bt = sender as Button;

            foreach (Control ctr in pPrincipal.Controls)
            {
                if (ctr is Button)
                {
                    bt.BackColor = Color.DarkGray;
                }
            }
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {

            Button bt = sender as Button;

            foreach (Control ctr in pPrincipal.Controls)  
            {
                if (ctr is Button)   
                {
                    bt.BackColor = Color.White;  
                }
            }
        }


        private void TextBox_MouseEnter(object sender, EventArgs e)
        {
            Panel panel;

            if (sender == txtNombre)
            {
                panel = pNombre;
            }
            else if (sender == txtApellido)
            {
                panel = pApellido;
            }
            else if (sender == txtGmail)
            {
                panel = pGmail;
            }
            else if (sender == txtUsuario)
            {
                panel = pUsuario;
            }
            else if (sender == txtContraseña)
            {
                panel = pContraseña;
            }
            else
            {
                return; 
            }

            panel.BackColor = Color.Black;
        }

        private void TextBox_MouseLeave(object sender, EventArgs e)
        {
            Panel panel;

            if (sender == txtNombre)
            {
                panel = pNombre;
            }
            else if (sender == txtApellido)
            {
                panel = pApellido;
            }
            else if (sender == txtGmail)
            {
                panel = pGmail;
            }
            else if (sender == txtUsuario)
            {
                panel = pUsuario;
            }
            else if (sender == txtContraseña)
            {
                panel = pContraseña;
            }
            else
            {
                return; 
            }

            if (!(sender as TextBox).Focused)
            {
                panel.BackColor = Color.Silver;
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            Panel panel;

            if (sender == txtNombre)
            {
                panel = pNombre;
            }
            else if (sender == txtApellido)
            {
                panel = pApellido;
            }
            else if (sender == txtGmail)
            {
                panel = pGmail;
            }
            else if (sender == txtUsuario)
            {
                panel = pUsuario;
            }
            else if (sender == txtContraseña)
            {
                panel = pContraseña;
            }
            else
            {
                return; 
            }

            panel.BackColor = Color.Black; 
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            Panel panel;

            if (sender == txtNombre)
            {
                panel = pNombre;
            }
            else if (sender == txtApellido)
            {
                panel = pApellido;
            }
            else if (sender == txtGmail)
            {
                panel = pGmail;
            }
            else if (sender == txtUsuario)
            {
                panel = pUsuario;
            }
            else if (sender == txtContraseña)
            {
                panel = pContraseña;
            }
            else
            {
                return; 
            }

            panel.BackColor = Color.Silver;
        }

        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            Panel panel;

            if (sender == pNombre)
            {
                panel = pNombre;
            }
            else if (sender == pApellido)
            {
                panel = pApellido;
            }
            else if (sender == pGmail)
            {
                panel = pGmail;
            }
            else if (sender == pUsuario)
            {
                panel = pUsuario;
            }
            else if (sender == pContraseña)
            {
                panel = pContraseña;
            }
            else
            {
                return;
            }

            panel.BackColor = Color.Black;
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            Panel panel;

            if (sender == pNombre)
            {
                panel = pNombre;
            }
            else if (sender == pApellido)
            {
                panel = pApellido;
            }
            else if (sender == pGmail)
            {
                panel = pGmail;
            }
            else if (sender == pUsuario)
            {
                panel = pUsuario;
            }
            else if (sender == pContraseña)
            {
                panel = pContraseña;
            }
            else
            {
                return; 
            }  
                panel.BackColor = Color.Silver;
            
        }

     



        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // ACCEDER  ( BOTON ) btnAcceder

            Form fLogin = new frmLogin();
            Form fRegistro = new frmRegistro();

            fLogin.Show();
            this.Close();
        }


        private string EncriptconSha2(string contraseña)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(contraseña);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }

                return sb.ToString();
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string gmail = txtGmail.Text;
            string cargo = (rbJefe.Checked) ? "Jefe" : "Empleado";
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                using (MySqlConnection conexion = miConexion.GetConexion())
                {
                    if (conexion.State != ConnectionState.Open)
                    {
                        conexion.Open();
                    }

                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        comando.Connection = conexion;

                        string consultaVerificacionUsuario = "SELECT COUNT(*) FROM usuario WHERE U_Usuario = @usuario OR U_Gmail = @gmail";
                        string consultaVerificacionEmpleados = "SELECT COUNT(*) FROM usuario WHERE U_Cargo = 'Empleado'";

                        comando.CommandText = consultaVerificacionUsuario;
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@gmail", gmail);

                        int RetornodeBD = Convert.ToInt32(comando.ExecuteScalar());

                        if (RetornodeBD > 0)
                        {
                            MessageBox.Show("El usuario con el mismo nombre de usuario o Gmail ya existe.");
                            return;
                        }

                        if (cargo == "Jefe")
                        {
                            string consultaVerificacionJefe = "SELECT COUNT(*) FROM usuario WHERE U_Cargo = 'Jefe'";
                            comando.CommandText = consultaVerificacionJefe;
                            int cantidadJefes = Convert.ToInt32(comando.ExecuteScalar());

                            if (cantidadJefes > 0)
                            {
                                MessageBox.Show("Ya hay un Jefe registrado, Maximo 1.");
                                return;
                            }
                        }
                        else if (cargo == "Empleado")
                        {
                            comando.CommandText = consultaVerificacionEmpleados;
                            int cantidadEmpleados = Convert.ToInt32(comando.ExecuteScalar());

                            if (cantidadEmpleados >= 3)
                            {
                                MessageBox.Show("No se pueden registrar mas empleados, Maximo 3.");
                                return;
                            }
                        }

                        string contraseñaEncriptada = EncriptconSha2(contraseña);
                        string consultaInsercion = "INSERT INTO usuario (U_Usuario, Nombre, U_Apellido, U_Contraseña, U_Gmail, U_Cargo) VALUES (@usuario, @nombre, @apellido, @contraseña, @gmail, @cargo)";

                        comando.CommandText = consultaInsercion;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@apellido", apellido);
                        comando.Parameters.AddWithValue("@contraseña", contraseñaEncriptada);
                        comando.Parameters.AddWithValue("@gmail", gmail);
                        comando.Parameters.AddWithValue("@cargo", cargo);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Usuario registrado exitosamente.");
                        Form fRegistro = new frmRegistro();
                        Form fLogin = new frmLogin();

                        fLogin.Show();
                        this.Close();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
        }



        private void chbOcultarPasss2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOcultarPasss2.Checked)
            {

                txtContraseña.UseSystemPasswordChar = true;

                chbOcultarPasss2.Text = "Ver";
            }
            else
            {

                chbOcultarPasss2.Text = "Ocultar";


                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        

        private void pPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}