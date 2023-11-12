using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;


namespace Proyecto
{
    public partial class frmConfiguracion : Form
    {
        private Conexion miConexion;
        private frmLogin form1;
        private frmMenu form3;
        private frmCotizacionesBrou frmCotizacionesBrou;
        private string nombreUsuario;


        private MySqlConnection conexion;
        public MySqlConnection Conexion { get; set; }


        public frmConfiguracion(string nombreUsuario, MySqlConnection conexion)
        {
            InitializeComponent();
            miConexion = new Conexion();
            form1 = new frmLogin();
            form3 = new frmMenu();
            frmCotizacionesBrou = new frmCotizacionesBrou();
            this.Load += Form4_Load;
            this.nombreUsuario = nombreUsuario;
            this.conexion = conexion;


        }


        public void AgregarDatosAlDataGridView(string nombreMoneda, string valorCompra, string valorVenta)
        {
            frmMenu form3 = new frmMenu();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CargarClientesDeaca();


        }
        public void CargarClientesDeaca()
        {
            try
            {
                string consulta = "SELECT Cliente_ID, CONCAT(Nombre, ' ', Apellido) AS NombreCompleto FROM cliente WHERE DadoDeBaja = 0";
                MySqlCommand cmd = new MySqlCommand(consulta, Conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                DataTable tablaClientes = new DataTable();
                adaptador.Fill(tablaClientes);

                cmbClientes2.DisplayMember = "NombreCompleto";
                cmbClientes2.ValueMember = "Cliente_ID";
                cmbClientes2.DataSource = tablaClientes;
                cmbClientesMod.DisplayMember = "NombreCompleto";
                cmbClientesMod.ValueMember = "Cliente_ID";
                cmbClientesMod.DataSource = tablaClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Close();
            form3.Show();
        }

        private void bntIngresarM_Click(object sender, EventArgs e)
        {

        }



        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.png;*.jpg;*.jpeg;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaDeLaImagen = openFileDialog.FileName;
                string nombreDeUsuario = ObtenerNombreDeUsuarioDeLaSesion();

                byte[] imagenEnBytes = File.ReadAllBytes(rutaDeLaImagen);

                try
                {
                    string connectionString = "Server=codelabmysqlserver.ddns.net;Database=codelabagencia;user=bdcode;password=11452020;";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string consulta = "UPDATE usuario SET ImagenPerfil = @FotoPerfil WHERE U_Usuario = @NombreDeUsuario";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                        {
                            cmd.Parameters.Add("@FotoPerfil", MySqlDbType.Blob).Value = imagenEnBytes;
                            cmd.Parameters.Add("@NombreDeUsuario", MySqlDbType.VarChar).Value = nombreDeUsuario;

                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Imagen de perfil actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar la imagen de perfil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
       
        private string ObtenerNombreDeUsuarioDeLaSesion()
        {
            return nombreUsuario;
        }

        private void btnEliminarCl_Click(object sender, EventArgs e)
        {
            if (cmbClientes2.SelectedValue != null)
            {
                int clienteID = (int)cmbClientes2.SelectedValue;

                // Agregue este message box con message buttons para que diga si desea eliminar el cliente seleccionado o no
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar al cliente seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        string connectionString = "Server=codelabmysqlserver.ddns.net;Database=codelabagencia;user=bdcode;password=11452020;";

                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            string consulta = "UPDATE cliente SET DadoDeBaja = 1 WHERE Cliente_ID = @clienteID";

                            using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                            {
                                cmd.Parameters.AddWithValue("@clienteID", clienteID);

                                connection.Open();

                                int filasAfectadas = cmd.ExecuteNonQuery();

                                if (filasAfectadas > 0)
                                {
                                    MessageBox.Show("Cliente dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    CargarClientesDeaca();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo dar de baja al cliente. No se encontraron registros coincidentes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            else
            {
                MessageBox.Show("Por favor, elija un cliente antes de darlo de baja.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }








        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show($"¿{nombreUsuario}, estás seguro de eliminar esta cuenta?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    string eliminarCuentaQuery = "DELETE FROM usuario WHERE U_Usuario = @usuario";

                    using (MySqlCommand cmd = new MySqlCommand(eliminarCuentaQuery, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", nombreUsuario);

                        conexion.Open();

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show($"La cuenta de {nombreUsuario} ha sido eliminada con éxito.", "Cuenta eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmLogin form1 = new frmLogin();
                            form1.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show($"No se encontró la cuenta de {nombreUsuario}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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




        private void button1_Click(object sender, EventArgs e)
        {
            int clienteID = (int)cmbClientesMod.SelectedValue;

            if (clienteID <= 0)
            {
                MessageBox.Show("Por favor, elija un cliente antes de modificarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string columnaModificar = "";

            if (rbNombre.Checked)
                columnaModificar = "Nombre";
            else if (rbApellido.Checked)
                columnaModificar = "Apellido";
            else if (rbCedula.Checked)
                columnaModificar = "Cedula";
            else if (rbCelular.Checked)
                columnaModificar = "Celular";
            else if (rbDireccion.Checked)
                columnaModificar = "Direccion";

            if (string.IsNullOrEmpty(columnaModificar))
            {
                MessageBox.Show("Por favor, seleccione una opción para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nuevoValor = txtEntradaModi.Text;

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                string consulta = $"UPDATE cliente SET {columnaModificar} = @nuevoValor WHERE Cliente_ID = @clienteID";

                using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@clienteID", clienteID);
                    cmd.Parameters.AddWithValue("@nuevoValor", nuevoValor);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        //aca agregue despues del cliente que se modifico correctamente el nuevo valor que se modifico y la columna
                        string mensaje = $"Cliente modificado correctamente. Nuevo valor de {columnaModificar}: {nuevoValor}";
                        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarClientesDeaca();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el cliente. No se encontraron registros coincidentes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {

            this.Close();
            frmCotizacionesBrou.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }

}



