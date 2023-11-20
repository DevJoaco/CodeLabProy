using MySql.Data.MySqlClient;

class Conexion
{
    private MySqlConnection conexion;
    private string server = "codelabmysqlserver.ddns.net";
    private string database = "codelabagencia";
    private string user = "bdcode";
    private string password = "11452020";
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


