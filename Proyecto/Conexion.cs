using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    internal class Conexion
    {

        private MySqlConnection conexion;
        private String server = "localhost";
        private String database = "AgenciaDeCambio";
        private String user = "root";
        private String password = "";
        private string cadenaConexion;


        public Conexion()
        {
            cadenaConexion = "DataBase=" + database +
                "; DataSourse=" + server +
                "; User ID=" + user +
                "; Password=" + password;
        }

        public MySqlConnection GetConexion()
        {
                if (conexion == null)
                {
                    conexion = new MySqlConnection(cadenaConexion);
                    conexion.Open();
                }

                return conexion;
            
        }
    }
}
