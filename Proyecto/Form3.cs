using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form3 : Form
    {
        private MySqlConnection conexion;
        private Form1 form1;
        Form FormPrestamos = new Prestamos();
        Form FormTransaccion = new Transaccion();
        
        public Form3()
        {
            InitializeComponent();
            conexion = new MySqlConnection("Server=codelabmysqlserver.ddns.net;Database=codelabagencia;user=codelab;password=1145;");
            this.MouseDown += Form3_MouseDown;
            this.MouseMove += Form3_MouseMove;
            this.MouseUp += Form3_MouseUp;
            this.Load += Form3_Load;

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(ActualizarReloj);
            timer.Start();
            CargarClientes();
            cmbClientes.Refresh();

            form1 = new Form1();
      
        }
        

        private void ActualizarReloj(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            bool mover = true;
            Point MoverCursor = Cursor.Position;
            Point MoverForm = this.Location;

            if (mover)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(MoverCursor));
                this.Location = Point.Add(MoverForm, new Size(dif));
            }
        }

        private void btnMouseEnterM(object sender, EventArgs e)
        {
            Button bt = sender as Button;

            foreach (Control ctr in pBotonesMenu.Controls)
            {
                if (ctr is Button)
                {
                    bt.BackColor = Color.DarkGray;
                }
            }
        }

        private void btnMouseLeaveM(object sender, EventArgs e)
        {


            Button bt = sender as Button;

            foreach (Control ctr in pBotonesMenu.Controls)
            {
                if (ctr is Button)
                {
                    bt.BackColor = Color.LightGray;
                }
            }
        }


        private void btnMouseEnterINM(object sender, EventArgs e)
        {
            Button bt = sender as Button;

            foreach (Control ctr in pBotonesMenu.Controls)
            {
                if (ctr is Button)
                {
                    bt.BackColor = Color.AntiqueWhite;
                }
            }
        }

        private void btnMouseLeaveINM(object sender, EventArgs e)
        {


            Button bt = sender as Button;

            foreach (Control ctr in pBotonesMenu.Controls)
            {
                if (ctr is Button)
                {
                    bt.BackColor = Color.DarkGray;
                }
            }
        }




        private void Form3_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "Nombre: " + Sesion.Nombre;
            lblApellido.Text = "Apellido: " + Sesion.Apellido;
            lblGmail.Text = "Gmail: " + Sesion.Gmail;
        }



        public void CargarClientes()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                string consulta = "SELECT Cliente_ID, CONCAT(Nombre, ' ', Apellido) AS NombreCompleto FROM cliente WHERE DadoDeBaja = 0";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tablaClientes = new DataTable();
                adaptador.Fill(tablaClientes);

                cmbClientes.DisplayMember = "NombreCompleto";
                cmbClientes.ValueMember = "Cliente_ID";
                cmbClientes.DataSource = tablaClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de clientes en Form3: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }


        public static class Sesion
        {
            public static string NombreUsuario { get; set; }
            public static string Nombre { get; set; }
            public static string Apellido { get; set; }
            public static string Gmail { get; set; }
        }



        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {

        }
        
  

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrestamos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Close();
            FormTransaccion.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {

            MessageBox.Show("La Sesion se ha cerrado correctamente");

            this.Close();
            form1.Show();
         
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Form4 formConfig = new Form4(Sesion.NombreUsuario, conexion);

            formConfig.Conexion = conexion;

            this.Hide();
            formConfig.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form FormGraficas = new Graficas();

            this.Close();
           FormGraficas.Show();

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtGuardar_Click(object sender, EventArgs e)
        {


        }

        private void btnGuardarIN_Click(object sender, EventArgs e)
        {
           
                string nombre = txtNombreIN.Text;
                string apellido = txtApellidoIN.Text;
                string cedula = txtCedulaIN.Text;
                string celular = txtCelularIN.Text;
            string direccion = txtDireccionIN.Text;

                try
                {
                    if (conexion.State != ConnectionState.Open)
                    {
                        conexion.Open();
                    }

                    string consulta = "INSERT INTO cliente (Nombre, Apellido, Cedula, Celular, Direccion) VALUES (@nombre, @apellido, @cedula, @celular, @Direccion)";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellido", apellido);
                    comando.Parameters.AddWithValue("@cedula", cedula);
                    comando.Parameters.AddWithValue("@celular", celular);
                    comando.Parameters.AddWithValue("@direccion", direccion);

                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Cliente ingresado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarClientes();
                        txtNombreIN.Clear();
                        txtApellidoIN.Clear();
                        txtCedulaIN.Clear();
                        txtCelularIN.Clear();
                         txtDireccionIN.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo ingresar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
   
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }

        private void btnSalirM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Form FormMovimientos = new Movimientos();

            this.Close();
            FormMovimientos.Show();

        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

