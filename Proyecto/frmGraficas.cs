using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto
{
    public partial class frmGraficas : Form
    {
        private MySqlConnection conexion;
        private DataTable tablaGanancia;
        private DataTable tablaMonedas;

        public frmGraficas()
        {
            InitializeComponent();
            conexion = new MySqlConnection("Server=codelabmysqlserver.ddns.net;Port=3306;Database=codelabagencia;User=bdcode;Password=11452020");
            conexion.Close();

            cmbTipoGrafico.Items.Add("Columna");
            cmbTipoGrafico.Items.Add("Pastel");
            cmbTipoGrafico.Items.Add("Línea");
            cmbTipoGrafico.SelectedIndex = 0;
        }

        private void frmGraficas_Load(object sender, EventArgs e)
        {
           
            CargarDatosDesdeDB();
            ConfigurarGrafico();
        }

       
        private void CargarDatosDesdeDB()
        {
            string query = "SELECT Fecha, TipoOperacion, MontoGanancia FROM ganancia";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            tablaGanancia = new DataTable();

            try
            {
                conexion.Open();
                adapter.Fill(tablaGanancia);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos desde la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void ConfigurarGrafico()
        {
            chartGanancias12.Series.Clear();
            chartGanancias12.Series.Add("Ganancias");

           
            chartGanancias12.ChartAreas[0].AxisX.Interval = 1;
            chartGanancias12.ChartAreas[0].AxisX.LabelStyle.Format = "dd MMM"; 
            chartGanancias12.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartGanancias12.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            
            chartGanancias12.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartGanancias12.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            
            chartGanancias12.Series["Ganancias"].Points.DataBindXY(tablaGanancia.DefaultView, "Fecha", tablaGanancia.DefaultView, "MontoGanancia");

            
            EstablecerTipoGrafico();
        }

        private void MostrarDatosSegunTipo(string tipoOperacion)
        {
            DataView vistaFiltrada = tablaGanancia.DefaultView;
            vistaFiltrada.RowFilter = $"TipoOperacion = '{tipoOperacion}'";

            chartGanancias12.Series["Ganancias"].Points.DataBindXY(vistaFiltrada, "Fecha", vistaFiltrada, "MontoGanancia");
        }

        private void btnPrestamo_Click_1(object sender, EventArgs e)
        {
            lblSalida.Text = "GANANCIAS PRESTAMOS";
            CambiarColorSerie("Ganancias", Color.SteelBlue);
            MostrarDatosSegunTipo("Prestamo");
        }

        private void btnCompra_Click_1(object sender, EventArgs e)
        {
            lblSalida.Text = "GANANCIAS COMPRAS";
            CambiarColorSerie("Ganancias", Color.Yellow);
            MostrarDatosSegunTipo("Compra");
        }

        private void btnVenta_Click_1(object sender, EventArgs e)
        {
            lblSalida.Text = "GANANCIAS VENTAS";
            CambiarColorSerie("Ganancias", Color.SpringGreen);
            MostrarDatosSegunTipo("Venta");
        }

        private void EstablecerTipoGrafico()
        {
            switch (cmbTipoGrafico.SelectedItem.ToString())
            {
                case "Columna":
                    chartGanancias12.Series["Ganancias"].ChartType = SeriesChartType.Column;
                    break;
                case "Pastel":
                    chartGanancias12.Series["Ganancias"].ChartType = SeriesChartType.Pie;
                    break;
                case "Línea":
                    chartGanancias12.Series["Ganancias"].ChartType = SeriesChartType.Line;
                    break;
            }
        }

        private void CambiarColorSerie(string Ganancias, Color color)
        {
            chartGanancias12.Series[Ganancias].Color = color;
        }

        

        private void Volver_Click(object sender, EventArgs e)
        {
            frmMenu frmMe = new frmMenu();
            this.Close();
            frmMe.Show();
        }

       

        private void cmbTipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            EstablecerTipoGrafico();
        }

        
    }
}
