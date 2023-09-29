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


    public partial class Transaccion : Form
    {

        private Conexion miConexion;
        public MySqlConnection Conexion { get; set; }

        public Transaccion()
        {
            InitializeComponent();

            miConexion = new Conexion();
            Conexion = miConexion.GetConexion();

            this.Load += Transaccion_Load;

        }

        private void Transaccion_Load(object sender, EventArgs e)
        {
            CargarClientesT();
            CargarMonedasT();
        }
        public void CargarClientesT()
        {
            try
            {


                string consulta = "SELECT Cliente_ID, CONCAT(Nombre, ' ', Apellido) AS NombreCompleto FROM cliente WHERE DadoDeBaja = 0";
                MySqlCommand cmd = new MySqlCommand(consulta, Conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                DataTable tablaClientesP = new DataTable();
                adaptador.Fill(tablaClientesP);

                cmbClientesT.DisplayMember = "NombreCompleto";
                cmbClientesT.ValueMember = "Cliente_ID";
                cmbClientesT.DataSource = tablaClientesP;
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


        public void CargarMonedasT()
        {
            try
            {
                string consulta = "Select Nombre, ValorCompra, ValorVenta from moneda";
                MySqlCommand cmd = new MySqlCommand(consulta, Conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                DataTable tablaMonedasT = new DataTable();
                adaptador.Fill(tablaMonedasT);

                
                cmbMonedasT.DisplayMember = "Nombre";
                cmbMonedaVT.DisplayMember = "Nombre";
                cmbMonedasT.ValueMember = "ValorCompra";
                cmbMonedaVT.ValueMember = "ValorVenta";
                
                cmbMonedaVT.DataSource = tablaMonedasT;
                cmbMonedasT.DataSource = tablaMonedasT;

              
                cmbMonedasT.SelectedIndexChanged += (sender, e) =>
                {
                    if (cmbMonedasT.SelectedItem != null)
                    {
                        
                        DataRowView selectedRow = (DataRowView)cmbMonedasT.SelectedItem;

                        
                        txtMontoVentaT.Text = selectedRow["ValorVenta"].ToString();
                        txtMontoCompraT.Text = selectedRow["ValorCompra"].ToString();

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





        private void btnVolverT_Click(object sender, EventArgs e)
        {
            Form FormMenu = new Form3();

            this.Close();
            FormMenu.Show();

        }

       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Transaccion_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnIngresarT_Click(object sender, EventArgs e)
        {

        }
    }
}
