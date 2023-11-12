using MySql.Data.MySqlClient;
using Proyecto.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmMenu : Form
    {
        private MySqlConnection conexion;
        Form frmLogin;

        public frmMenu()
        {
            InitializeComponent();
            conexion = new MySqlConnection("Server=codelabmysqlserver.ddns.net;Database=codelabagencia;user=bdcode;password=11452020;");
            this.MouseDown += Form3_MouseDown;
            this.MouseMove += Form3_MouseMove;
            this.MouseUp += Form3_MouseUp;
            this.Load += Form3_Load;
            frmLogin = new frmLogin();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(ActualizarReloj);
            timer.Start();
            CargarClientes();
            frmLogin.Close();
            EventoINFOMENU();
            dgvClientess.RowHeadersVisible = false;
            cmbBusqueda.Items.Add("Nombre");
            cmbBusqueda.Items.Add("Apellido");
            cmbBusqueda.Items.Add("Cédula");
            cmbBusqueda.Items.Add("Número");
            cmbBusqueda.Items.Add("Dirección");

            cmbBusqueda.SelectedIndex = 0;

            string usuario = Sesion.NombreUsuario;
            string gmail = CargarGMAIL(usuario);
            string cargo = CargarUSER(usuario);

            Label lblUserInfo = this.Controls.Find("lblNombreUsuario", true).FirstOrDefault() as Label;

            if (lblUserInfo != null)
            {
                lblUserInfo.Text = "Usuario: " + usuario + "\nGmail: " + gmail + "\nCargo: " + cargo;
            }
            else
            {
                MessageBox.Show("No existe label de información de usuarios");
            }

            CargaFOTOPERFIL(usuario);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string usuario = Sesion.NombreUsuario;
            string cargo = CargarUSER(usuario);

            if (cargo != "Jefe")
            {
                btnMovimientos.Image = Properties.Resources.candado;
                btnMetricas.Image = Properties.Resources.candado;

                Color colorOcultar = Color.FromArgb(128, 128, 128);
                btnMovimientos.BackColor = colorOcultar;
                btnMetricas.BackColor = colorOcultar;


                btnMovimientos.ForeColor = Color.DarkRed;
               btnMetricas.ForeColor = Color.DarkRed;
                
                btnMovimientos.Enabled = false;
                btnMetricas.Enabled = false;
            }
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

        private string CargarGMAIL(string nombreUsuario) 
        {
            string gmail = null;

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                string consulta = "SELECT U_Gmail FROM usuario WHERE U_Usuario = @nombreUsuario";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                object resultado = comando.ExecuteScalar(); // ejecuta la consulta y
                                                            // recupera el valor de la primera columna de la primera fila del resultado,
                                                            // lo que es útil cuando solo necesitas un solo valor de la base de datos,
                                                            // como en este caso para obtener el "Cargo" del usuario.

                if (resultado != null)
                {
                    gmail = resultado.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el Gmail del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return gmail;
        }
        private string CargarUSER(string nombreUsuario) 
        {
            string cargo = null;

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                string consulta = "SELECT U_Cargo FROM usuario WHERE U_Usuario = @nombreUsuario";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                object resultado = comando.ExecuteScalar();

                if (resultado != null)
                {
                    cargo = resultado.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el Cargo del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return cargo;
        }


        

        private void CargarClientes()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                string consulta = "SELECT * FROM cliente WHERE DadoDeBaja = 0";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvClientess.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            public static string CargoUsuario { get; set; }
            
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Form FrmPrestamos = new frmPrestamos();


            this.Close();
            FrmPrestamos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form FrmTransaccion = new frmTransaccion();

            this.Close();
            FrmTransaccion.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmLogin frmLog = new frmLogin();

            MessageBox.Show("La Sesion se ha cerrado correctamente");

            this.Close();
            frmLog.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            frmConfiguracion formConfig = new frmConfiguracion(Sesion.NombreUsuario, conexion);

            formConfig.Conexion = conexion;

            this.Hide();
            formConfig.Show();

        }

        private void btnMetricas_Click(object sender, EventArgs e)
        {
            Form FormGraficas = new frmGraficas();

            this.Close();
            FormGraficas.Show();

        }


        private void EventoINFOMENU()
        {
            int prestamosActivos = 0;
            int transaccionesTotales = 0; 
            int clientesActivos = 0;

            try
            {
                string consultaPrestamosActivos = "SELECT COUNT(*) FROM préstamo WHERE DadoDeBaja = 0 AND Fecha_Vencimiento >= CURDATE()";
                MySqlCommand cmdPrestamosActivos = new MySqlCommand(consultaPrestamosActivos, conexion);

                string consultaTransaccionesTotales = "SELECT COUNT(*) FROM devolucion"; 
                MySqlCommand cmdTransaccionesTotales = new MySqlCommand(consultaTransaccionesTotales, conexion);

                string consultaClientesActivos = "SELECT COUNT(*) FROM cliente WHERE DadoDeBaja = 0";
                MySqlCommand cmdClientesActivos = new MySqlCommand(consultaClientesActivos, conexion);

                conexion.Open();

                prestamosActivos = Convert.ToInt32(cmdPrestamosActivos.ExecuteScalar());
                transaccionesTotales = Convert.ToInt32(cmdTransaccionesTotales.ExecuteScalar()); 
                clientesActivos = Convert.ToInt32(cmdClientesActivos.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }

            lblPrestamosA.Text = "Prestamos Activos: " + prestamosActivos;
            lblTranSac.Text = "Transacciones Totales: " + transaccionesTotales; 
            lblClientsss.Text = "Clientes Activos: " + clientesActivos;
        }
        private void CargaFOTOPERFIL(string nombreDeUsuario)
        {
            try
            {
                string connectionString = "Server=codelabmysqlserver.ddns.net;Database=codelabagencia;user=bdcode;password=11452020;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // esta consulta es para obtener la imagen de perfil del usuario actual
                    string consulta = "SELECT ImagenPerfil FROM usuario WHERE U_Usuario = @NombreDeUsuario";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                    {
                        cmd.Parameters.Add("@NombreDeUsuario", MySqlDbType.VarChar).Value = nombreDeUsuario;

                        // Lee la imagen desde la base de datos
                        object imagenBytes = cmd.ExecuteScalar();

                        if (imagenBytes != DBNull.Value)
                        {
                            // pasa los bytes de la imagen en un objeto Image
                            byte[] bytesImagen = (byte[])imagenBytes;
                            using (MemoryStream ms = new MemoryStream(bytesImagen))
                            {
                                Image imagen = Image.FromStream(ms);
                                PictureFOTOPERFIL.Image = imagen;
                            }
                        }
                        else
                        {
                            
                            PictureFOTOPERFIL.Image = null; 
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnGuardarIN_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreIN.Text;
            string apellido = txtApellidoIN.Text;
            string cedula = txtCedulaIN.Text;
            string celular = txtCelularIN.Text;
            string direccion = txtDireccionIN.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(celular) || string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de enviar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

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
            frmLogin.Close();
        }
        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            Form FormMovimientos = new frmMovimientos();

            this.Close();
            FormMovimientos.Show();
        }
      

        private void btnBuscarCL_Click(object sender, EventArgs e)
        {
            string criterio = cmbBusqueda.SelectedItem.ToString();
            string valorBusqueda = txtBusquedaIn.Text.Trim();

            if (string.IsNullOrEmpty(valorBusqueda))
            {
                MessageBox.Show("Por favor, ingrese un valor de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                string consulta = "SELECT * FROM cliente WHERE ";

                switch (criterio)
                {
                    case "Nombre":
                        consulta += "Nombre LIKE @valorBusqueda";
                        break;
                    case "Apellido":
                        consulta += "Apellido LIKE @valorBusqueda";
                        break;
                    case "Cédula":
                        consulta += "Cedula LIKE @valorBusqueda";
                        break;
                    case "Número":
                        consulta += "Celular LIKE @valorBusqueda";
                        break;
                    case "Dirección":
                        consulta += "Direccion LIKE @valorBusqueda";
                        break;
                    default:
                        MessageBox.Show("Criterio de búsqueda no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@valorBusqueda", "%" + valorBusqueda + "%");

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvClientess.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

        }


        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvClientess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

    
       

        private void PictureFOTOPERFIL_Click(object sender, EventArgs e)
        {

        }

        private void txtBusquedaIn_TextChanged(object sender, EventArgs e)
        {

            string criterio = cmbBusqueda.SelectedItem.ToString();
            string valorBusqueda = txtBusquedaIn.Text.Trim();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                string consulta = "SELECT * FROM cliente";

                if (!string.IsNullOrEmpty(valorBusqueda))
                {
                    consulta += " WHERE ";

                    switch (criterio)
                    {
                        case "Nombre":
                            consulta += "Nombre LIKE @valorBusqueda";
                            break;
                        case "Apellido":
                            consulta += "Apellido LIKE @valorBusqueda";
                            break;
                        case "Cédula":
                            consulta += "Cedula LIKE @valorBusqueda";
                            break;
                        case "Número":
                            consulta += "Celular LIKE @valorBusqueda";
                            break;
                        case "Dirección":
                            consulta += "Direccion LIKE @valorBusqueda";
                            break;
                        default:
                            MessageBox.Show("Criterio de búsqueda no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                    }
                }

                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                if (!string.IsNullOrEmpty(valorBusqueda))
                {
                    comando.Parameters.AddWithValue("@valorBusqueda", "%" + valorBusqueda + "%");
                }

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvClientess.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }


        }
    }

    


