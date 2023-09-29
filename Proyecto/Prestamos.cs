using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Prestamos : Form
    {

        private Conexion miConexion;
        public MySqlConnection Conexion { get; set; }

        public Prestamos()
        {
            InitializeComponent();

            miConexion = new Conexion();
            Conexion = miConexion.GetConexion();

            this.Load += Prestamos_Load;
        }


        private void btnVolverP_Click(object sender, EventArgs e)
        {

            Form FormMenu = new Form3();

            this.Close();
            FormMenu.Show();

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

                        txtValorMonedaP.Text = media.ToString(); 
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




        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void txtValorMonedaP_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


