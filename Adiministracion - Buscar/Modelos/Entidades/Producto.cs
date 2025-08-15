using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Producto
    {
        private int id;
        private string nombre;
        private double precio;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }

        public static DataTable CargarProductos()
        {
            SqlConnection con = Conexion.Conexion.Conectar();
            string comando = "select *from VerProductos";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

        public static DataTable Buscar(string termino)
        {
            SqlConnection con = Conexion.Conexion.Conectar();
            string comando = $"select *from VerProductos where nombre like '%{termino}%';";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;

        }
    }
}
