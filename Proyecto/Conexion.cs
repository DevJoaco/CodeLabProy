using MySql.Data.MySqlClient;

namespace Proyecto
{
    internal class Conexion
    {
        private MySqlConnection conexion;
        private string server = "codelabmysqlserver.ddns.net";
        private string database = "codelabagencia";
        private string user = "codelab";
        private string password = "1145";
        private int port = 3306; 
        private string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = "Server=" + server +
               "; Port=" + port +
                "; Database=" + database +
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
