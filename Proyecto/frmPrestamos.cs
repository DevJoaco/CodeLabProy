using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Drawing;
using System.Text;



namespace Proyecto
{
    public partial class frmPrestamos : Form
    {
        private Conexion miConexion;
        public MySqlConnection Conexion { get; set; }
        private Dictionary<string, string> monedasPlurales;

        private string tempPdfFolder;

        public frmPrestamos()
        {
            InitializeComponent();

            miConexion = new Conexion();
            Conexion = miConexion.GetConexion();
            CargarPrestamos();
            this.Load += Prestamos_Load;
            CargarLabelsPrestamos();
            
            cmbBusqueda.Items.Add("Nombre");
            cmbBusqueda.Items.Add("Apellido");
            cmbBusqueda.Items.Add("Tipo de Moneda");
            cmbBusqueda.SelectedIndex = 0;

            monedasPlurales = new Dictionary<string, string>
            {
                { "Dólar", "Dólares" },
                { "Euro", "Euros" },
                { "Peso", "Pesos" },
                { "Peso Uruguayo", "Pesos Uruguayos" },
                { "Peso Argentino", "Pesos Argentinos" },
                { "Real", "Reales" },
                { "DólarEbrou", "DólaresEbrou" }
            };

            tempPdfFolder = Path.Combine(Path.GetTempPath(), "PDFs");
            if (!Directory.Exists(tempPdfFolder))
            {
                Directory.CreateDirectory(tempPdfFolder);
            }
        }

        private void DescargarPDFsTemporales()
        {
            try
            {
                string consulta = "SELECT ID_Prestamo, ArchivoPDF FROM préstamo WHERE DadoDeBaja = 0";
                MySqlCommand cmd = new MySqlCommand(consulta, Conexion);

                Conexion.Open();
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

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al descargar archivos PDF temporales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarPrestamos()
        {
            try
            {
                if (Conexion.State != ConnectionState.Open)
                {
                    Conexion.Open();
                }

                string consulta = "SELECT P.ID_Prestamo, P.Intereses, P.MontoPrestado, P.MontoADevolver, P.Fecha_Vencimiento, P.CUOTAS, " +
                    "P.Fecha_Realizacion, " +
                    "C.Nombre AS ClienteNombre, C.Apellido AS ClienteApellido, M.Nombre AS Moneda " +
                    "FROM préstamo AS P " +
                    "INNER JOIN cliente AS C ON P.Cliente_ID = C.Cliente_ID " +
                    "INNER JOIN moneda AS M ON P.Moneda_ID = M.Moneda_ID " +
                    "WHERE P.DadoDeBaja = 0 " +
                    "ORDER BY P.ID_Prestamo ASC";  //  para ordenar de menor a mayor

                MySqlCommand cmd = new MySqlCommand(consulta, Conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                DataTable tablaPrestamos = new DataTable();
                adaptador.Fill(tablaPrestamos);

                dgvPrestamos.Columns.Clear();
                dgvPrestamos.DataSource = null;
                dgvPrestamos.DataSource = tablaPrestamos;

                DataGridViewButtonColumn pdfColumn = new DataGridViewButtonColumn();
                pdfColumn.HeaderText = "Contrato";
                pdfColumn.Name = "PDFButtonColumn";
                pdfColumn.Text = "Abrir Contrato";
                pdfColumn.UseColumnTextForButtonValue = true;
                dgvPrestamos.Columns.Add(pdfColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
        }





        private byte[] ObtenerPDFDesdeBaseDeDatos(int idPrestamo)
        {
            try
            {
                string consulta = "SELECT ArchivoPDF FROM préstamo WHERE ID_Prestamo = @ID_Prestamo";
                MySqlCommand cmd = new MySqlCommand(consulta, Conexion);
                cmd.Parameters.AddWithValue("@ID_Prestamo", idPrestamo);

                Conexion.Open();
                object result = cmd.ExecuteScalar();
                Conexion.Close();

                if (result != null && result != DBNull.Value)
                {
                    return (byte[])result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el archivo PDF desde la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvPrestamos.Columns["PDFButtonColumn"].Index)
            {
                int prestamoId = Convert.ToInt32(dgvPrestamos["ID_Prestamo", e.RowIndex].Value);

                byte[] pdfBytes = ObtenerPDFDesdeBaseDeDatos(prestamoId);

                if (pdfBytes != null && pdfBytes.Length > 0)
                {
                    try
                    {
                        string tempPdfFileName = Path.Combine(tempPdfFolder, $"Prestamo_{prestamoId}.pdf");
                        File.WriteAllBytes(tempPdfFileName, pdfBytes);

                        Process.Start(tempPdfFileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al abrir el archivo PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo PDF no se pudo obtener desde la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            CargarClientesP();
            CargarMonedasP();
            DescargarPDFsTemporales();
            CargarPrestamos();
        }





        private string ObtenerTipoMoneda(int prestamoId)
        {
            try
            {
                string consulta = "SELECT M.Nombre " +
                    "FROM préstamo AS P " +
                    "INNER JOIN moneda AS M ON P.Moneda_ID = M.Moneda_ID " +
                    "WHERE P.ID_Prestamo = @PrestamoId";

                MySqlCommand cmd = new MySqlCommand(consulta, Conexion);
                cmd.Parameters.AddWithValue("@PrestamoId", prestamoId);

                Conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string nombreMoneda = reader["Nombre"].ToString();

                    if (monedasPlurales.ContainsKey(nombreMoneda))
                    {
                        return monedasPlurales[nombreMoneda];
                    }

                    return nombreMoneda;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el tipo de moneda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.Close();
            }

            return string.Empty;
        }

        private void CargarLabelsPrestamos()
        {
            int prestamosActivos = 0;
            int prestamosVencidos = 0;

            try
            {
                string consultaPrestamosActivos = "SELECT COUNT(*) FROM préstamo WHERE DadoDeBaja = 0 AND Fecha_Vencimiento >= CURDATE()";
                MySqlCommand cmdPrestamosActivos = new MySqlCommand(consultaPrestamosActivos, Conexion);

                string consultaPrestamosVencidos = "SELECT COUNT(*) FROM préstamo WHERE DadoDeBaja = 0 AND Fecha_Vencimiento < CURDATE()";
                MySqlCommand cmdPrestamosVencidos = new MySqlCommand(consultaPrestamosVencidos, Conexion);

                Conexion.Open();

                prestamosActivos = Convert.ToInt32(cmdPrestamosActivos.ExecuteScalar());
                prestamosVencidos = Convert.ToInt32(cmdPrestamosVencidos.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los labels de préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.Close();
            }

            lblPrestamosActivos.Text = "Prestamos Activos: " + prestamosActivos;
            lblPrestamosVencidos.Text = "Prestamos Vencidos: " + prestamosVencidos;
        }



        private void Prestamos_Load(object sender, EventArgs e)
        {
            CargarClientesP();
            CargarMonedasP();
        }
        public void CargarClientesP()
        {
            try
            {


                string consulta = "SELECT Cliente_ID, CONCAT(Nombre, ' ', Apellido) AS NombreCompleto FROM cliente WHERE DadoDeBaja = 0";
                MySqlCommand cmd = new MySqlCommand(consulta, Conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                DataTable tablaClientesP = new DataTable();
                adaptador.Fill(tablaClientesP);

                cmbClientesP.DisplayMember = "NombreCompleto";
                cmbClientesP.ValueMember = "Cliente_ID";
                cmbClientesP.DataSource = tablaClientesP;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.Close();
            }
        }

        public void CargarMonedasP()
        {
            try
            {
                string consulta = "Select Nombre, ValorCompra, ValorVenta from moneda";
                MySqlCommand cmd = new MySqlCommand(consulta, Conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                DataTable tablaMonedasT = new DataTable();
                adaptador.Fill(tablaMonedasT);

                cmbMonedaP.DisplayMember = "Nombre";
                cmbMonedaP.ValueMember = "ValorVenta";
                cmbMonedaP.DataSource = tablaMonedasT;

                cmbMonedaP.SelectedIndexChanged += (sender, e) =>
                {
                    if (cmbMonedaP.SelectedItem != null)
                    {
                        DataRowView selectedRow = (DataRowView)cmbMonedaP.SelectedItem;

                        double valorCompra = Convert.ToDouble(selectedRow["ValorCompra"]);
                        double valorVenta = Convert.ToDouble(selectedRow["ValorVenta"]);


                        double media = (valorCompra + valorVenta) / 2;


                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de Monedas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.Close();
            }
        }






        private string rutaArchivoPDF = "";
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos PDF|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivoPDF = openFileDialog.FileName;
                MessageBox.Show("PDF cargado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string TipoMonedaPrestamo;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cmbClientesP.SelectedItem != null && cmbMonedaP.SelectedItem != null)
            {
                DataRowView selectedCliente = (DataRowView)cmbClientesP.SelectedItem;
                int clienteId = Convert.ToInt32(selectedCliente["Cliente_ID"]);

                DataRowView selectedMoneda = (DataRowView)cmbMonedaP.SelectedItem;
                int monedaId = ObtenerMonedaId(selectedMoneda["Nombre"].ToString());

                // se obtiene el tipo de moneda y se asigna a TipoMonedaPrestamo
                string tipoMoneda = selectedMoneda["Nombre"].ToString();
                TipoMonedaPrestamo = tipoMoneda;

                decimal montoPrestado = Convert.ToDecimal(txtMontoP.Text);
                string fechaVencimiento = dtpVencimiento.Value.ToString("yyyy-MM-dd");

                decimal tasaInteres = Convert.ToDecimal(txtIntereses.Text) / 100;
                decimal nuevosIntereses = montoPrestado * tasaInteres;

                decimal tasaCambio = ObtenerCotizaciones(monedaId);

                decimal interesesDolares = nuevosIntereses;
                decimal montoADevolverDolares = montoPrestado + interesesDolares;

                int cuotas = int.Parse(txtCuotas.Text);

                if (cuotas <= 0)
                {
                    MessageBox.Show("La cantidad de cuotas debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (montoPrestado <= 0)
                {
                    MessageBox.Show("El monto prestado debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string usuarioCargo = frmMenu.Sesion.CargoUsuario;

                RegistrarInteresesEnGanancia(interesesDolares, monedaId);

                try
                {
                    string consulta = "INSERT INTO préstamo (Intereses, Cliente_ID, MontoPrestado, MontoADevolver, Fecha_Vencimiento, CUOTAS, Moneda_ID, ArchivoPDF, Fecha_Realizacion, UsuarioCargo, TipoMonedaPrestamo) " +
                        "VALUES (@Intereses, @Cliente_ID, @MontoPrestado, @MontoADevolver, @Fecha_Vencimiento, @Cuotas, @Moneda_ID, @ArchivoPDF, @Fecha_Realizacion, @UsuarioCargo, @TipoMonedaPrestamo)";

                    MySqlCommand cmd = new MySqlCommand(consulta, Conexion);
                    cmd.Parameters.AddWithValue("@Intereses", interesesDolares);
                    cmd.Parameters.AddWithValue("@Cliente_ID", clienteId);
                    cmd.Parameters.AddWithValue("@MontoPrestado", montoPrestado);
                    cmd.Parameters.AddWithValue("@MontoADevolver", montoADevolverDolares);
                    cmd.Parameters.AddWithValue("@Fecha_Vencimiento", fechaVencimiento);
                    cmd.Parameters.AddWithValue("@Cuotas", cuotas);
                    cmd.Parameters.AddWithValue("@Moneda_ID", monedaId);

                    if (!string.IsNullOrEmpty(rutaArchivoPDF))
                    {
                        byte[] pdfBytes = File.ReadAllBytes(rutaArchivoPDF);
                        cmd.Parameters.AddWithValue("@ArchivoPDF", pdfBytes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ArchivoPDF", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@Fecha_Realizacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@UsuarioCargo", usuarioCargo);
                    cmd.Parameters.AddWithValue("@TipoMonedaPrestamo", TipoMonedaPrestamo);

                    Conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    Conexion.Close();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Préstamo registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbClientesP.SelectedIndex = -1;
                        txtMontoP.Clear();
                        txtIntereses.Clear();
                        txtCuotas.Clear();
                        dtpVencimiento.Value = DateTime.Now;
                        CargarPrestamos();
                        ImprimirUltimoPrestamo();
                        rutaArchivoPDF = "";
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al registrar el préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un cliente y una moneda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RegistrarInteresesEnGanancia(decimal intereses, int monedaId)
        {
            try
            {
                decimal tasaCambio = ObtenerCotizaciones(monedaId);
                decimal interesesPesosUruguayos = intereses * tasaCambio; // Convierte los intereses a pesos uruguayos

                string consultaActualizarIntereses = "INSERT INTO ganancia (Intereses, Fecha_Ingreso) VALUES (@InteresesPesosUruguayos, NOW())";
                MySqlCommand cmdActualizarIntereses = new MySqlCommand(consultaActualizarIntereses, Conexion);
                cmdActualizarIntereses.Parameters.AddWithValue("@InteresesPesosUruguayos", interesesPesosUruguayos);

                Conexion.Open();
                cmdActualizarIntereses.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la tabla 'ganancia': " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private decimal ObtenerCotizaciones(int monedaId)
        {
            try
            {
                string consulta = "SELECT ValorCompra FROM moneda WHERE Moneda_ID = @MonedaId";
                MySqlCommand cmd = new MySqlCommand(consulta, Conexion);
                cmd.Parameters.AddWithValue("@MonedaId", monedaId);

                Conexion.Open();
                object result = cmd.ExecuteScalar();
                Conexion.Close();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el valor de compra desde la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return 1.0m;
        }



        private void ImprimirUltimoPrestamo()
        {
            try
            {
                string consulta = "SELECT P.ID_Prestamo, P.Intereses, P.MontoPrestado, P.MontoADevolver, P.Fecha_Vencimiento, P.CUOTAS, " +
                    "P.Fecha_Realizacion, C.Nombre AS ClienteNombre, C.Apellido AS ClienteApellido, C.Cedula AS ClienteCedula, C.Direccion AS ClienteDireccion, M.Nombre AS Moneda, P.TipoMonedaPrestamo " +
                    "FROM préstamo AS P " +
                    "INNER JOIN cliente AS C ON P.Cliente_ID = C.Cliente_ID " +
                    "INNER JOIN moneda AS M ON P.Moneda_ID = M.Moneda_ID " +
                    "ORDER BY P.ID_Prestamo DESC LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(consulta, Conexion);

                Conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string clienteNombre = reader["ClienteNombre"].ToString();
                    string clienteApellido = reader["ClienteApellido"].ToString();
                    string clienteCedula = reader["ClienteCedula"].ToString();
                    string clienteDireccion = reader["ClienteDireccion"].ToString();
                    DateTime fechaRealizacion = Convert.ToDateTime(reader["Fecha_Realizacion"]);
                    DateTime fechaVencimiento = Convert.ToDateTime(reader["Fecha_Vencimiento"]);
                    decimal montoPrestado = Convert.ToDecimal(reader["MontoPrestado"]);
                    decimal montoADevolver = Convert.ToDecimal(reader["MontoADevolver"]);
                    int cuotas = Convert.ToInt32(reader["CUOTAS"]);
                    string tipoMonedaPrestamo = reader["TipoMonedaPrestamo"].ToString();
                    decimal intereses = Convert.ToDecimal(reader["Intereses"]);

                    
                    string reciboFormato = $@"

                                                                     RECIBO DE PRÉSTAMO DE DINERO


En Salto Uruguay. {fechaRealizacion:dd/MM/yyyy HH:mm:ss}




La empresa Prestamista Agencia Libertad con domicilio ubicado en Artigas 622 certifica 
que ha entregado la cantidad de {montoPrestado.ToString("0.00")} {tipoMonedaPrestamo} al prestatario {clienteNombre} {clienteApellido} 
poseedor del número de identidad {clienteCedula} con domicilio ubicado en {clienteDireccion}.
El préstamo cuenta con un interés de {intereses.ToString("0.00")} y debe ser devuelto en un plazo de {cuotas} meses. 
El prestatario {clienteNombre} {clienteApellido} se compromete a pagar a la empresa prestamista Agencia Libertad
la cantidad de {(montoADevolver / cuotas).ToString("0.00")} {tipoMonedaPrestamo} mensuales el día {fechaVencimiento:dd/MM/yyyy} de cada mes, lo que significa que se deberán 
pagar {montoADevolver.ToString("0.00")} que liquidarán el total del préstamo.


                                                               …………………………………………………………..
                                                          Roberto Cordero (Agencia Libertad)          30357592



                                                               ……………………………………………………………
                                                         {clienteNombre} {clienteApellido}                  {clienteCedula}";

                    
                    string rutaImagen = "C:\\Users\\franzeira\\Desktop\\CodeLabProy\\imgs\\loginho.png";

                   
                    int imagenAncho = Image.FromFile(rutaImagen).Width / 2;
                    int imagenAlto = Image.FromFile(rutaImagen).Height / 2;

                  
                    var result = MessageBox.Show("¿Desea imprimir la factura?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // esto abre el cuadro de diálogo de impresión
                        PrintDialog printDialog = new PrintDialog();
                        PrintDocument pd = new PrintDocument();
                        printDialog.Document = pd;

                        if (printDialog.ShowDialog() == DialogResult.OK)
                        {
                            pd.PrintPage += (s, e) =>
                            {
                                // Dibujar el formato del recibo
                                e.Graphics.DrawString(reciboFormato, new Font("Arial", 10), Brushes.Black, 10, 10);

                             
                                Image imagen = Image.FromFile(rutaImagen);
                                e.Graphics.DrawImage(imagen, e.PageBounds.Width - imagenAncho - 10, 10, imagenAncho, imagenAlto);
                            };

                            pd.Print();
                        }
                    }
                }

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles del préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









        private int ObtenerMonedaId(string nombreMoneda)
        {

            string consulta = "SELECT Moneda_ID FROM moneda WHERE Nombre = @NombreMoneda";
            MySqlCommand cmd = new MySqlCommand(consulta, Conexion);
            cmd.Parameters.AddWithValue("@NombreMoneda", nombreMoneda);

            Conexion.Open();
            int monedaId = Convert.ToInt32(cmd.ExecuteScalar());
            Conexion.Close();

            return monedaId;
        }


        private void btnVolverP_Click_1(object sender, EventArgs e)
        {
            Form frmMenu = new frmMenu();

            frmMenu.Show();
            this.Close();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count > 0)
            {
                int prestamoId = Convert.ToInt32(dgvPrestamos.SelectedRows[0].Cells["ID_Prestamo"].Value);
                decimal montoDevolucion = Convert.ToDecimal(txtMontoDev.Text);
                DateTime fechaDevolucion = dtpDevolucion.Value;

                if (montoDevolucion <= 0)
                {
                    MessageBox.Show("El monto de devolución debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal montoPendiente = ObtenerMontoPendiente(prestamoId);
                string tipoMonedaPlural = ObtenerTipoMoneda(prestamoId);

                if (montoDevolucion > montoPendiente)
                {
                    MessageBox.Show("El monto de devolución no puede exceder el monto pendiente del préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string consultaDevolucion = "INSERT INTO devolucion (Prestamo_ID, MontoDevuelto, FechaDevolucion) " +
                    "VALUES (@PrestamoId, @MontoDevolucion, @FechaDevolucion)";

                using (MySqlCommand cmdDevolucion = new MySqlCommand(consultaDevolucion, Conexion))
                {
                    cmdDevolucion.Parameters.AddWithValue("@PrestamoId", prestamoId);
                    cmdDevolucion.Parameters.AddWithValue("@MontoDevolucion", montoDevolucion);
                    cmdDevolucion.Parameters.AddWithValue("@FechaDevolucion", fechaDevolucion);

                    Conexion.Open();
                    cmdDevolucion.ExecuteNonQuery();
                    Conexion.Close();
                }

                string actualizarMontoPendiente = "UPDATE préstamo SET MontoADevolver = MontoADevolver - @MontoDevolucion WHERE ID_Prestamo = @PrestamoId";

                using (MySqlCommand cmdActualizacion = new MySqlCommand(actualizarMontoPendiente, Conexion))
                {
                    cmdActualizacion.Parameters.AddWithValue("@PrestamoId", prestamoId);
                    cmdActualizacion.Parameters.AddWithValue("@MontoDevolucion", montoDevolucion);

                    Conexion.Open();
                    cmdActualizacion.ExecuteNonQuery();
                    Conexion.Close();
                }

                montoPendiente -= montoDevolucion;

                if (montoPendiente <= 0)
                {
                    string marcaBaja = "UPDATE préstamo SET DadoDeBaja = 1 WHERE ID_Prestamo = @PrestamoId";

                    using (MySqlCommand cmd = new MySqlCommand(marcaBaja, Conexion))
                    {
                        cmd.Parameters.AddWithValue("@PrestamoId", prestamoId);

                        Conexion.Open();
                        cmd.ExecuteNonQuery();
                        Conexion.Close();
                    }
                }

                MessageBox.Show($"Devolución exitosa, le quedan por devolver {montoPendiente} {tipoMonedaPlural}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMontoDev.Clear();
                dtpDevolucion.Value = DateTime.Now;

                CargarPrestamos();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un préstamo en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private decimal ObtenerMontoPendiente(int prestamoId)
        {
            string consulta = "SELECT MontoADevolver FROM préstamo WHERE ID_Prestamo = @PrestamoId";

            using (MySqlCommand cmd = new MySqlCommand(consulta, Conexion))
            {
                cmd.Parameters.AddWithValue("@PrestamoId", prestamoId);
                Conexion.Open();
                object result = cmd.ExecuteScalar();
                Conexion.Close();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }

                return 0;
            }
        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string criterio = cmbBusqueda.SelectedItem.ToString();
            string valorBusqueda = txtBusqueda.Text;

            if (!string.IsNullOrEmpty(valorBusqueda))
            {
                DataTable tablaPrestamos = (DataTable)dgvPrestamos.DataSource;

                if (tablaPrestamos != null)
                {
                    DataView dv = new DataView(tablaPrestamos);
                    string filtro = string.Empty;

                    switch (criterio)
                    {
                        case "Nombre":
                            filtro = "ClienteNombre LIKE '%" + valorBusqueda + "%'";
                            break;
                        case "Apellido":
                            filtro = "ClienteApellido LIKE '%" + valorBusqueda + "%'";
                            break;
                        case "Tipo de Moneda":
                            filtro = "Moneda LIKE '%" + valorBusqueda + "%'";
                            break;
                        default:
                            break;
                    }

                    DataTable resultado = tablaPrestamos.Clone();
                    DataRow[] rows = tablaPrestamos.Select(filtro);

                    foreach (DataRow row in rows)
                    {
                        resultado.ImportRow(row);
                    }

                    dgvPrestamos.DataSource = resultado;
                }
            }
        }

        private void btnResett_Click(object sender, EventArgs e)
        {
            CargarPrestamos();
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private byte[] imagenCedula;
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void InsertarPDFEnBD(string nombreArchivo, byte[] archivoBytes)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string criterio = cmbBusqueda.SelectedItem.ToString();
            string valorBusqueda = txtBusqueda.Text;

            if (!string.IsNullOrEmpty(valorBusqueda))
            {
                DataTable tablaPrestamos = (DataTable)dgvPrestamos.DataSource;

                if (tablaPrestamos != null)
                {
                    DataView dv = new DataView(tablaPrestamos);
                    string filtro = string.Empty;

                    switch (criterio)
                    {
                        case "Nombre":
                            filtro = "ClienteNombre LIKE '%" + valorBusqueda + "%'";
                            break;
                        case "Apellido":
                            filtro = "ClienteApellido LIKE '%" + valorBusqueda + "%'";
                            break;
                        case "Tipo de Moneda":
                            filtro = "Moneda LIKE '%" + valorBusqueda + "%'";
                            break;
                        default:
                            break;
                    }

                    DataView dvFiltered = new DataView(tablaPrestamos, filtro, "", DataViewRowState.CurrentRows);
                    dgvPrestamos.DataSource = dvFiltered.ToTable();
                }
            }
            else
            {
                CargarPrestamos();
                
            }
        }

    private void cmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        
    }

}

