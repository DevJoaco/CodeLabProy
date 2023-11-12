using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Proyecto
{

    public partial class frmMovimientos : Form
    {
        private Conexion miConexion;
        public MySqlConnection Conexion { get; set; }

        private string tempPdfFolder;
        private int prestamoId;


        public frmMovimientos()
        {
            miConexion = new Conexion();
            Conexion = miConexion.GetConexion();
            InitializeComponent();


            tempPdfFolder = Path.Combine(Path.GetTempPath(), "PDFs");
            if (!Directory.Exists(tempPdfFolder))
            {
                Directory.CreateDirectory(tempPdfFolder);
            }

            DescargarPDFsTemporales();
            ObtenerPDFDesdeBaseDeDatos(prestamoId);

            MostrarCombinacionDeBotones();
            ObtenerDatosDeCombinacion();

        }

        private void btnVolverMo_Click(object sender, EventArgs e)
        {
            Form FormMenu = new frmMenu();

            this.Close();
            FormMenu.Show();

        }


        private void btnMouseEnterMO(object sender, EventArgs e)
        {
            Button bt = sender as Button;

            foreach (Control ctr in pMovimientos.Controls)
            {
                if (ctr is Button)
                {
                    bt.BackColor = Color.AntiqueWhite;
                }
            }
        }

        private void btnMouseLeaveMO(object sender, EventArgs e)
        {


            Button bt = sender as Button;

            foreach (Control ctr in pMovimientos.Controls)
            {
                if (ctr is Button)
                {
                    bt.BackColor = Color.LightSteelBlue;
                }
            }
        }

        private void MostrarCombinacionDeBotones()
        {
            DataTable datosDeCombinacion = ObtenerDatosDeCombinacion();

            DataGridViewButtonColumn columnaPDF = new DataGridViewButtonColumn();
            columnaPDF.HeaderText = "Contrato";
            columnaPDF.Name = "PDFButtonColumn";
            columnaPDF.Text = "Abrir Contrato";
            columnaPDF.UseColumnTextForButtonValue = true;

            dgvMovimientos.Columns.Add(columnaPDF);

            dgvMovimientos.DataSource = datosDeCombinacion;
        }

        private DataTable ObtenerDatosDeCombinacion()
        {
            try
            {
                string connectionString = "Server=codelabmysqlserver.ddns.net;Database=codelabagencia;User=bdcode;Password=11452020";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT t.Transacción_ID, t.Tipo,  t.Moneda_C, t.Moneda_V, t.Monto_C, t.Monto_V, " +
                                   "c.Nombre AS NombreCliente, c.Apellido AS ApellidoCliente, t.CargoUsuario " +
                                   "FROM transacción t " +
                                   "LEFT JOIN cliente c ON t.Cliente = c.Cliente_ID";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataTable.Columns["Transacción_ID"].ColumnName = "ID Transaccion";
                        dataTable.Columns["Moneda_C"].ColumnName = "Valor Compra";
                        dataTable.Columns["Moneda_V"].ColumnName = "Valor Venta";
                        dataTable.Columns["Monto_C"].ColumnName = "Agencia Recibe";
                        dataTable.Columns["Monto_V"].ColumnName = "Cliente Recibe";

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos de los tres botones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }




        private void DescargarPDFsTemporales()
        {
            try
            {
                string connectionString = "Server=codelabmysqlserver.ddns.net;Database=codelabagencia;User=bdcode;Password=11452020";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string consulta = "SELECT ID_Prestamo, ArchivoPDF FROM préstamo WHERE DadoDeBaja = 0";
                    MySqlCommand cmd = new MySqlCommand(consulta, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int prestamoId = reader.GetInt32("ID_Prestamo");

                        if (!reader.IsDBNull(reader.GetOrdinal("ArchivoPDF")))
                        {
                            byte[] pdfBytes = (byte[])reader["ArchivoPDF"];
                            string pdfFileName = Path.Combine(tempPdfFolder, $"Prestamo_{prestamoId}.pdf");
                            File.WriteAllBytes(pdfFileName, pdfBytes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al descargar archivos PDF temporales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private byte[] ObtenerPDFDesdeBaseDeDatos(int idPrestamo)
        {
            try
            {
                string connectionString = "Server=codelabmysqlserver.ddns.net;Database=codelabagencia;User=bdcode;Password=11452020";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string consulta = "SELECT ArchivoPDF FROM préstamo WHERE ID_Prestamo = @ID_Prestamo";
                    MySqlCommand cmd = new MySqlCommand(consulta, connection);
                    cmd.Parameters.AddWithValue("@ID_Prestamo", idPrestamo);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return (byte[])result;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el archivo PDF desde la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            dgvMovimientos.DataSource = null;
            dgvMovimientos.Columns.Clear();

            string connectionString = "Server=codelabmysqlserver.ddns.net;Database=codelabagencia;User=bdcode;Password=11452020";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT t.Transacción_ID,  t.Tipo,  t.Moneda_C, t.Moneda_V, t.Monto_C, t.Monto_V, " +
                               "c.Nombre AS NombreCliente, c.Apellido AS ApellidoCliente, t.CargoUsuario " +
                               "FROM transacción t " +
                               "LEFT JOIN cliente c ON t.Cliente = c.Cliente_ID " +
                               "WHERE t.Tipo = 'Compra'";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    dataTable.Columns["Transacción_ID"].ColumnName = "ID Transaccion";
                    dataTable.Columns["Moneda_C"].ColumnName = "Valor Compra";
                    dataTable.Columns["Moneda_V"].ColumnName = "Valor Venta";
                    dataTable.Columns["Monto_C"].ColumnName = "Agencia Recibe";
                    dataTable.Columns["Monto_V"].ColumnName = "Cliente Recibe";

                    dgvMovimientos.DataSource = dataTable;
                }
            }
        }  

        private void button3_Click(object sender, EventArgs e)
        {
            dgvMovimientos.DataSource = null;
            dgvMovimientos.Columns.Clear();
            try
            {
                string connectionString = "Server=codelabmysqlserver.ddns.net;Database=codelabagencia;User=bdcode;Password=11452020";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string consulta = "SELECT P.ID_Prestamo, P.Intereses, P.MontoPrestado, P.MontoADevolver, P.Fecha_Vencimiento, P.CUOTAS, " +
                        "P.Fecha_Realizacion, " +
                        "C.Nombre AS ClienteNombre, C.Apellido AS ClienteApellido, M.Nombre AS Moneda " +
                        "FROM préstamo AS P " +
                        "INNER JOIN cliente AS C ON P.Cliente_ID = C.Cliente_ID " +
                        "INNER JOIN moneda AS M ON P.Moneda_ID = M.Moneda_ID " +
                        "WHERE P.DadoDeBaja = 0 " +
                        "ORDER BY P.ID_Prestamo ASC";

                    MySqlCommand cmd = new MySqlCommand(consulta, connection);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    DataTable tablaPrestamos = new DataTable();
                    adaptador.Fill(tablaPrestamos);

                    dgvMovimientos.Columns.Clear();
                    dgvMovimientos.DataSource = null;
                    dgvMovimientos.DataSource = tablaPrestamos;

                    DataGridViewButtonColumn pdfColumn = new DataGridViewButtonColumn();
                    pdfColumn.HeaderText = "Contrato";
                    pdfColumn.Name = "PDFButtonColumn";
                    pdfColumn.Text = "Abrir Contrato";
                    pdfColumn.UseColumnTextForButtonValue = true;
                    dgvMovimientos.Columns.Add(pdfColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            dgvMovimientos.DataSource = null;
            dgvMovimientos.Columns.Clear();

            string connectionString = "Server=codelabmysqlserver.ddns.net;Database=codelabagencia;User=bdcode;Password=11452020";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT t.Transacción_ID, t.Tipo,  t.Moneda_C, t.Moneda_V, t.Monto_C, t.Monto_V, " +
                               "c.Nombre AS NombreCliente, c.Apellido AS ApellidoCliente, t.CargoUsuario " +
                               "FROM transacción t " +
                               "LEFT JOIN cliente c ON t.Cliente = c.Cliente_ID " +
                               "WHERE t.Tipo = 'Venta'";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvMovimientos.DataSource = dataTable;
                }
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (!(rbNombre.Checked || rbApellido.Checked || rbCedula.Checked || rbDireccion.Checked))
                {
                    MessageBox.Show("Selecciona un tipo de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Server=codelabmysqlserver.ddns.net;Database=codelabagencia;User=bdcode;Password=11452020";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string filtro = txtBuscadorr.Text.Trim();
                    string columnaBusqueda = "";

                    if (rbNombre.Checked) columnaBusqueda = "C.Nombre";
                    else if (rbApellido.Checked) columnaBusqueda = "C.Apellido";
                    else if (rbCedula.Checked) columnaBusqueda = "C.Cedula";
                    else if (rbDireccion.Checked) columnaBusqueda = "C.Direccion";

                    string consulta = "SELECT P.ID_Prestamo, P.Intereses, P.MontoPrestado, P.MontoADevolver, P.Fecha_Vencimiento, P.CUOTAS, " +
                        "P.Fecha_Realizacion, " +
                        "C.Nombre AS ClienteNombre, C.Apellido AS ClienteApellido, M.Nombre AS Moneda " +
                        "FROM préstamo AS P " +
                        "INNER JOIN cliente AS C ON P.Cliente_ID = C.Cliente_ID " +
                        "INNER JOIN moneda AS M ON P.Moneda_ID = M.Moneda_ID " +
                        "WHERE P.DadoDeBaja = 0 " +
                        $"AND {columnaBusqueda} LIKE '%{filtro}%' " +
                        "ORDER BY P.ID_Prestamo ASC";

                    MySqlCommand cmd = new MySqlCommand(consulta, connection);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    DataTable tablaPrestamos = new DataTable();
                    adaptador.Fill(tablaPrestamos);

                    dgvMovimientos.Columns.Clear();
                    dgvMovimientos.DataSource = null;
                    dgvMovimientos.DataSource = tablaPrestamos;

                    DataGridViewButtonColumn pdfColumn = new DataGridViewButtonColumn();
                    pdfColumn.HeaderText = "Contrato";
                    pdfColumn.Name = "PDFButtonColumn";
                    pdfColumn.Text = "Abrir Contrato";
                    pdfColumn.UseColumnTextForButtonValue = true;
                    dgvMovimientos.Columns.Add(pdfColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvMovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMovimientosRecientes_Click(object sender, EventArgs e)
        {
            MostrarCombinacionDeBotones();
            ObtenerDatosDeCombinacion();
        }
    }
}