using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_2doParcial.Config
{
    internal class ConexionBDD
    {
        
        
            private static readonly string connectionString;

        static ConexionBDD()
        {
            // Aquí puedes establecer tu cadena de conexión. Se recomienda obtenerla de un archivo de configuración o variables de entorno.
            connectionString = "Server=DORIAN;Database=Buses;User Id=sa;Password=12345;";
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
                throw;
            }
        
        }
    }
}

