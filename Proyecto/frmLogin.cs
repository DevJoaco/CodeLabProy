using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmLogin : Form
 
    {
        private MySqlConnection conexion;
        private Conexion miConexion;
        public frmLogin()
        {
            InitializeComponent();
            miConexion = new Conexion();
            conexion = miConexion.GetConexion();
            this.MouseDown += Form_MouseDown;
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;
            chbOcultarPasss.Checked = true;
            this.KeyPreview = true;
            this.KeyPress += btnIniciarSesión_KeyPress;
            txtUsuarioIS.Text = "jefe";
            txtContraseñaIS.Text = "1";

            txtUsuarioIS.MouseEnter += txtUsuarioIS_MouseEnter;
            txtUsuarioIS.MouseLeave += txtUsuarioIS_MouseLeave;
            txtUsuarioIS.Enter += txtUsuarioIS_Enter;
            txtUsuarioIS.Leave += txtUsuarioIS_Leave;
            pUsuarioIS.MouseEnter += txtUsuarioIS_MouseEnter;
            pUsuarioIS.MouseLeave += txtUsuarioIS_MouseLeave;

            txtContraseñaIS.MouseEnter += TextBoxContraseña_MouseEnter;
            txtContraseñaIS.MouseLeave += TextBoxContraseña_MouseLeave;
            txtContraseñaIS.Enter += TextBoxContraseña_Enter;
            txtContraseñaIS.Leave += TextBoxContraseña_Leave;
            pContraseñaIS.MouseEnter += PanelContraseña_MouseEnter;
            pContraseñaIS.MouseLeave += PanelContraseña_MouseLeave;
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X,
                    (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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



        private void Pprincipal_Paint(object sender, PaintEventArgs e)
        {
            // PANEL PRINCIPAL         ( PANEL ) pPrincipal
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {          
            Form fRegistro = new frmRegistro();
            Form fLogin = new frmLogin();

            fRegistro.Show();
            this.Hide();

        }
        private void txtUsuarioIS_MouseEnter(object sender, EventArgs e)
        {
            pUsuarioIS.BackColor = Color.Black;
        }

        private void txtUsuarioIS_MouseLeave(object sender, EventArgs e)
        {
            if (!txtUsuarioIS.Focused)
            {
                pUsuarioIS.BackColor = Color.Silver;
            }
        }

        private void txtUsuarioIS_Enter(object sender, EventArgs e)
        {
            pUsuarioIS.BackColor = Color.Black; 
        }

        private void txtUsuarioIS_Leave(object sender, EventArgs e)
        {
            pUsuarioIS.BackColor = Color.Silver; 
        }

        private void TextBoxContraseña_MouseEnter(object sender, EventArgs e)
        {
            pContraseñaIS.BackColor = Color.Black;
        }

        private void TextBoxContraseña_MouseLeave(object sender, EventArgs e)
        {

        }

        private void TextBoxContraseña_Enter(object sender, EventArgs e)
        {
            pContraseñaIS.BackColor = Color.Black; 
        }

        private void TextBoxContraseña_Leave(object sender, EventArgs e)
        {
            pContraseñaIS.BackColor = Color.Silver; 
        }

        private void PanelContraseña_MouseEnter(object sender, EventArgs e)
        {
            pContraseñaIS.BackColor = Color.Black;
        }

        private void PanelContraseña_MouseLeave(object sender, EventArgs e)
        {
            if (!txtContraseñaIS.Focused)
            {
                pContraseñaIS.BackColor = Color.Silver;
            }
        }


        private void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioIS.Text;
            string contraseña = txtContraseñaIS.Text;

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytesContraseña = Encoding.UTF8.GetBytes(contraseña);
                    byte[] hash = sha256.ComputeHash(bytesContraseña);
                    string hashContraseña = BitConverter.ToString(hash).Replace("-", "").ToLower();

                    string consulta = "SELECT U_Usuario, U_Cargo FROM usuario WHERE U_Usuario = @usuario AND U_Contraseña = @hashContraseña";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@hashContraseña", hashContraseña);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Almacenar la información del usuario en la sesión
                                frmMenu.Sesion.NombreUsuario = reader["U_Usuario"].ToString();
                                frmMenu.Sesion.CargoUsuario = reader["U_Cargo"].ToString();

                                frmMenu frm3 = new frmMenu();
                                frm3.Show();
                                this.Hide();
                                MessageBox.Show("¡Bienvenido, " + usuario + "!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión o realizar la consulta: " + ex.Message);
            }
        }
        private string ObtenerCargoUsuario(string usuario)
        {
            string consultaCargo = "SELECT U_Cargo FROM usuario WHERE U_Usuario = @usuario";

            using (MySqlCommand comandoCargo = new MySqlCommand(consultaCargo, conexion))
            {
                comandoCargo.Parameters.AddWithValue("@usuario", usuario);

                string cargoUsuario = comandoCargo.ExecuteScalar() as string;

                return cargoUsuario;
            }
        }




        private void chbOcultarPasss_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOcultarPasss.Checked)
            {

                txtContraseñaIS.UseSystemPasswordChar = true;

                chbOcultarPasss.Text = "Ver";
            }
            else
            {

                chbOcultarPasss.Text = "Ocultar";


                txtContraseñaIS.UseSystemPasswordChar = false;
            }
        }
                     




        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label14_Click(object sender, EventArgs e)
        {
            // LABEL INICIAR SESIÓN  ( LABEL )
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // AUN NO TIENES UNA CUENTA       ( LABEL )
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // YA CUENTAS CON UNA CUENTA      ( LABEL )
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // INGRESA DANDOLE CLICK AL BOTON DE ABAJO        ( LABEL )
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // BOTON ACCEDER          ( BUTTON ) btnAcceder


        }

        private void label2_Click(object sender, EventArgs e)
        {
            // REGISTRATE DANDOLE CLICK AL BOTON DE ABAJO         ( LABEL ) 

        }

        private void pContenedor_Paint(object sender, PaintEventArgs e)
        {
            // PANEL CONTENEDOR          ( PANEL ) pContenedor

        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // BOTON REGISTRAR    ( BUTTON )  btnRegistrar

        }

        private void pIniciarSesión_Paint(object sender, PaintEventArgs e)
        {
            // INICIAR SESIÓN        ( PANEL )     pIniciarSesión
        }



        private void pContraseñaIS_Paint(object sender, PaintEventArgs e)
        {
            // CONTRASEÑA INICIAR SESIÓN   ( PANEL ) pContraseñaIS

        }

        private void pUsuarioIS_Paint(object sender, PaintEventArgs e)
        {
            // USUARIO INICIAR SESIÓN   ( PANEL ) pUsuarioIS

        }

        private void btnIniciarSesión_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                btnIniciarSesión_Click(sender, e);
            }
        }


    }
}

