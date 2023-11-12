using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using MySql.Data.MySqlClient;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Globalization;

namespace Proyecto
{
    public partial class frmCotizacionesBrou : Form
    {

        Form frmMenuCB = new frmMenu();
        
        string CotizacionDolarCompra = "0.00";
        string CotizacionDolarVenta = "0.00";
        string CotizacionDolarEbrouCompra = "0.00";
        string CotizacionDolarEbrouVenta = "0.00";
        string CotizacionEuroCompra = "0.00";
        string CotizacionEuroVenta = "0.00";
        string CotizacionPesoArgentinoCompra = "0.00";
        string CotizacionPesoArgentinoVenta = "0.00";
        string CotizacionRealCompra = "0.00";
        string CotizacionRealVenta = "0.00";

        public frmCotizacionesBrou()
        {
            InitializeComponent();
        }

        private void frmCotizacionesBrou_Load(object sender, EventArgs e)
        {
            
        }   
        
        private void btnExtraerBrou_Click(object sender, EventArgs e)
        {
            var edgeDriveService = EdgeDriverService.CreateDefaultService();
            IWebDriver driver = new EdgeDriver(edgeDriveService);

            List<Moneda> monedas = new List<Moneda>();

            try
            {
                driver.Navigate().GoToUrl("https://www.brou.com.uy/web/guest/cotizaciones");


                var elementosCotizaciones = driver.FindElements(By.ClassName("valor"));

                CotizacionDolarCompra = elementosCotizaciones[4].Text;
                CotizacionDolarVenta = elementosCotizaciones[5].Text;

                CotizacionDolarEbrouCompra = elementosCotizaciones[8].Text;
                CotizacionDolarEbrouVenta = elementosCotizaciones[9].Text;

                CotizacionEuroCompra = elementosCotizaciones[12].Text;
                CotizacionEuroVenta = elementosCotizaciones[13].Text;

                CotizacionPesoArgentinoCompra = elementosCotizaciones[16].Text;
                CotizacionPesoArgentinoVenta = elementosCotizaciones[17].Text;

                CotizacionRealCompra = elementosCotizaciones[20].Text;
                CotizacionRealVenta = elementosCotizaciones[21].Text;
            
            }
            finally
            {
                driver.Quit();
            }
        }

        private void btnActualizarMonedas_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=codelabmysqlserver.ddns.net;Database=codelabagencia;User=bdcode;Password=11452020";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE moneda SET ValorCompra = @ValorCompra, ValorVenta = @ValorVenta WHERE Nombre = @Nombre";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.Clear();

                        command.Parameters.AddWithValue("@Nombre", "Dólar");
                        command.Parameters.AddWithValue("@ValorCompra", CotizacionDolarCompra.ToString().Replace(",", "."));
                        command.Parameters.AddWithValue("@ValorVenta", CotizacionDolarVenta.ToString().Replace(",", "."));
                        command.ExecuteNonQuery();


                        command.Parameters.Clear();

                        command.Parameters.AddWithValue("@Nombre", "DólarEbrou");
                        command.Parameters.AddWithValue("@ValorCompra", CotizacionDolarEbrouCompra.ToString().Replace(",", "."));
                        command.Parameters.AddWithValue("@ValorVenta", CotizacionDolarEbrouVenta.ToString().Replace(",", "."));
                        command.ExecuteNonQuery();

                        command.Parameters.Clear();

                        command.Parameters.AddWithValue("@Nombre", "Euro");
                        command.Parameters.AddWithValue("@ValorCompra", CotizacionEuroCompra.ToString().Replace(",", "."));
                        command.Parameters.AddWithValue("@ValorVenta", CotizacionEuroVenta.ToString().Replace(",", "."));
                        command.ExecuteNonQuery();

                        command.Parameters.Clear();

                        command.Parameters.AddWithValue("@Nombre", "Peso Argentino");
                        command.Parameters.AddWithValue("@ValorCompra", CotizacionPesoArgentinoCompra.ToString().Replace(",", "."));
                        command.Parameters.AddWithValue("@ValorVenta", CotizacionPesoArgentinoVenta.ToString().Replace(",", "."));
                        command.ExecuteNonQuery();

                        command.Parameters.Clear();

                        command.Parameters.AddWithValue("@Nombre", "Real");
                        command.Parameters.AddWithValue("@ValorCompra", CotizacionRealCompra.ToString().Replace(",", "."));
                        command.Parameters.AddWithValue("@ValorVenta", CotizacionRealVenta.ToString().Replace(",", "."));
                        command.ExecuteNonQuery();

                        MessageBox.Show("Valores actualizados con éxito.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuCB.Show();
        }

        private void btnVolverMenuP_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuCB.Show();
        }
    }
    public class Moneda
    {
        public string NombreMoneda { get; set; }    
        public double ValorCompra { get; set; }
        public double ValorVenta { get; set; }
    }
}



