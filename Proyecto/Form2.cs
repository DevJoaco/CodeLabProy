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
    public partial class Form2 : Form
    {
        private MySqlConnection conexion;
        private Conexion miConexion;
       

        public Form2()
        {
            InitializeComponent();
            miConexion = new Conexion();
            chbOcultarPasss2.Checked = true;

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




        private void pRegistro_Paint(object sender, PaintEventArgs e)
        {
            // REGISTRO ( PANEL ) pRegistro
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // ACCEDER  ( BOTON ) btnAcceder

            Form fLogin = new Form1();
            Form fRegistro = new Form2();

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

                        string consultaVerificacion = "SELECT COUNT(*) FROM usuario WHERE U_Usuario = @usuario OR U_Gmail = @gmail";

                        comando.CommandText = consultaVerificacion;
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@gmail", gmail);

                        int existeUsuario = Convert.ToInt32(comando.ExecuteScalar());

                        if (existeUsuario > 0)
                        {
                            MessageBox.Show("El usuario con el mismo nombre de usuario o Gmail ya existe.");
                            return;
                        }

                        string contraseñaEncriptada = EncriptconSha2(contraseña);
                        string consultaInsercion = "INSERT INTO usuario (U_Usuario, Nombre, U_Apellido, U_Contraseña, U_Gmail) VALUES (@usuario, @nombre, @apellido, @contraseña, @gmail)";

                        comando.CommandText = consultaInsercion;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@apellido", apellido);
                        comando.Parameters.AddWithValue("@contraseña", contraseñaEncriptada);
                        comando.Parameters.AddWithValue("@gmail", gmail);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Usuario registrado exitosamente.");
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}