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
    public partial class MovimientosPrestamo : Form
    {
        private Conexion miConexion;
        public MySqlConnection Conexion { get; set; }

        Form FormMenu = new Form3();
        Form FormMovimientos = new Movimientos();
        public MovimientosPrestamo()
        {
            InitializeComponent();

            miConexion = new Conexion();
            Conexion = miConexion.GetConexion();

            this.Load += MovimientoPrestamo_Load;
        }

        private void btnVolverMenuP_Click(object sender, EventArgs e)
        {

            this.Close();
            FormMenu.Show();
        }

        private void VolverMovimientosP_Click(object sender, EventArgs e)
        {

            this.Close();
            FormMovimientos.Show();
        }

        private void MovimientoPrestamo_Load(object sender, EventArgs e)
        {
            CargarClientesP();
        }
        public void CargarClientesP()
        {
            try
            {


                string consulta = "SELECT Cliente_ID, CONCAT(Nombre, ' ', Apellido) AS NombreCompleto FROM cliente";
                MySqlCommand cmd = new MySqlCommand(consulta, Conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                DataTable tablaClientesP = new DataTable();
                adaptador.Fill(tablaClientesP);

                cmbClientesMP.DisplayMember = "NombreCompleto";
                cmbClientesMP.ValueMember = "Cliente_ID";
                cmbClientesMP.DataSource = tablaClientesP;
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


    }
}
