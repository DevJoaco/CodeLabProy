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
    public partial class FormConexionBDcs : Form
    {

        private Conexion mConexion;
        public FormConexionBDcs()
        {
            InitializeComponent();

            mConexion = new Conexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string result = "";
            MySqlDataReader mySqlDataReader = null;
            string consulta = "select * from usuarios";

            if (mConexion.GetConexion() != null)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                mySqlCommand.Connection = mConexion.GetConexion();
                mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read()) {
                    result = mySqlDataReader.GetString("usuario");

                }
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("error al conectar");
            } 

        }
    }
}
