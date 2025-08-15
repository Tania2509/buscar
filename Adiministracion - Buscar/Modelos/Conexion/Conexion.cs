using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Conexion
{
    public class Conexion
    {
        private static string servidor = "ODIE\\SQLEXPRESS01";
        private static string baseDeDatos = "Tienda";

        public static SqlConnection Conectar()
        {
            string cadena =
                $"Data Source={servidor}; Initial Catalog={baseDeDatos}; Integrated Security=True;";

            SqlConnection con = new SqlConnection(cadena);

            con.Open();

            return con;
        }
    }
}
