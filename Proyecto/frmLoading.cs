using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Proyecto
{
    public partial class frmLoading : Form
    {
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

        
        public frmLoading()
        {

            InitializeComponent();
            
        }
       protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ThreadPool.QueueUserWorkItem((state) =>
            {
         //  ExtraerCotizaciones();
         //   ActualizarMonedas();

               
                this.Invoke(new Action(() =>
                {
                    this.Hide();
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.Show();
                }));
            });
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
           
        }

        private void ExtraerCotizaciones()
        {
            var edgeDriveService = EdgeDriverService.CreateDefaultService();
            edgeDriveService.HideCommandPromptWindow = true;  // esto oculta la ventana del cmd
            var edgeOptions = new EdgeOptions();

            try
            {
               
                IWebDriver driver = new EdgeDriver(edgeDriveService, edgeOptions);
                driver.Manage().Window.Size = new Size(0, 0);
               


                // con esto se mueve la pestaña del edge afuera de la pantalla
                driver.Manage().Window.Position = new System.Drawing.Point(-2000, -2000);
               
                driver.Navigate().GoToUrl("https://www.brou.com.uy/web/guest/cotizaciones");

                // esto encuentra los elementos que contienen las cotizaciones
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

                //esto deja la posición original de la pestaña del navegador
                driver.Manage().Window.Position = new System.Drawing.Point(0, 0);

                driver.Quit();
            }
            finally
            {
                edgeDriveService.Dispose();
            }
        }



        private void ActualizarMonedas()
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

                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


            private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
