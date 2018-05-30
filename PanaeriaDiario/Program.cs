using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaeriaDiario
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;user=inf282g7;database=inf282g7;port=3306;password=0mvK88;SslMode=none;";
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "PEDIDO_DIARIO";
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
