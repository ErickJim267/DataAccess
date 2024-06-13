using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Conexiones
{
    public class ConnectionDB
    {
        private SqlConnection Conexion = new SqlConnection("Data Source = root;Initial Catalog = Caso_1; Persist Security info=true;User=root; Password=12345");
        
        public SqlConnection openSqlConnection()
        {
            if (Conexion.State == System.Data.ConnectionState.Closed) Conexion.Open();
            return Conexion;
        }

        public SqlConnection closeSQLConnection()
        {
            if (Conexion.State == System.Data.ConnectionState.Open) Conexion.Close();
            return Conexion;
        }
    }
}
