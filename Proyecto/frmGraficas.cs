using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;

namespace Proyecto
{
    public partial class frmGraficas : Form
    {
        private MySqlConnection conexion;

        public frmGraficas()
        {
            InitializeComponent();
            //CargarGanancias();

            conexion = new MySqlConnection("Server=codelabmysqlserver.ddns.net;Database=codelabagencia;User=bdcode;Password=11452020");
        }

        private void btnVolverG_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMenu().Show();
        }

        private void Graficas_Load(object sender, EventArgs e)
        {
           
        }

        private void CargarGanancias()
        {
            try
            {
                conexion.Open();
                string consulta = "SELECT Intereses FROM ganancia";
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        decimal interes = reader.GetDecimal(0);
                        chartGanancias12.Series["Ganancias"].Points.AddY(interes);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ganancias: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void chartGanancias12_Click(object sender, EventArgs e)
        {
           

        }
    }
}
