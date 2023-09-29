using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form4 : Form
    {
        private Conexion miConexion;
        private Form1 form1;
        private Form3 form3;
        private string nombreUsuario;


        private MySqlConnection conexion;
        public MySqlConnection Conexion { get; set; }


        public Form4(string nombreUsuario, MySqlConnection conexion)
        {
            InitializeComponent();
            miConexion = new Conexion();
            form1 = new Form1();
            form3 = new Form3();
            this.Load += Form4_Load;
            this.nombreUsuario = nombreUsuario;
            this.conexion = conexion;
        }


        public void AggDatosDGV(string nombreMoneda, string valorCompra, string valorVenta)
        {
            Form3 form3 = new Form3();

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
            string nombreMoneda = txtNombreMoneda.Text;
            string valorCompra = txtValorCompra.Text;
            string valorVenta = txtValorVenta.Text;

            AggDatosDGV(nombreMoneda, valorCompra, valorVenta);


        }


        private void btnEliminarCl_Click(object sender, EventArgs e)
        {
            if (cmbClientes2.SelectedValue != null)
            {
                int clienteID = (int)cmbClientes2.SelectedValue;

                try
                {
                    string connectionString = "Server=codelabmysqlserver.ddns.net;Database=codelabagencia;user=codelab;password=1145;";

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
                                form3.CargarClientes();
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

                            Form1 form1 = new Form1();
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
                        MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label9_Click(object sender, EventArgs e)
        {

        }
    } 

    }

