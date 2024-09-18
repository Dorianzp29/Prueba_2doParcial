using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Prueba_2doParcial.Config;
namespace Prueba_2doParcial.Models
{
    internal class PasajerosModels
    {
        public int ID_Pasajero { get; set; }
        public string Nombre { get; set; }
        public int ID_Ruta { get; set; }

        public string DisplayName
        {
            get
            {
                return ID_Pasajero + " " + Nombre + " " + ID_Ruta;
            }
        }

        SqlDataReader lector;
        List<PasajerosModels> ListaPasajeros = new List<PasajerosModels>();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public List<PasajerosModels> Todos()
        {
            ListaPasajeros.Clear();
            using (var con = ConexionBDD.GetConnection())
            {
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Pasajeros";
                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    PasajerosModels pasajero = new PasajerosModels
                    {
                        ID_Pasajero = Convert.ToInt32(lector["ID_Pasajero"]),
                        Nombre = lector["Nombre"].ToString(),
                        ID_Ruta = Convert.ToInt32(lector["ID_Ruta"]),
                    };
                    ListaPasajeros.Add(pasajero);
                }
                return ListaPasajeros;
            }
        }

        public void agregar()
        {
            using (var con = ConexionBDD.GetConnection())
            {
                string cadena = "INSERT INTO Pasajeros (Nombre, ID_Ruta) VALUES (@Nombre, @ID_Ruta)";
                using (SqlCommand cmd = new SqlCommand(cadena, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@ID_Ruta", ID_Ruta);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void modificar()
        {
            using (var con = ConexionBDD.GetConnection())
            {
                string cadena = "UPDATE Pasajeros SET Nombre = @Nombre, ID_Ruta = @ID_Ruta WHERE ID_Pasajero = @ID_Pasajero";
                using (SqlCommand cmd = new SqlCommand(cadena, con))
                {
                    cmd.Parameters.AddWithValue("@ID_Pasajero", ID_Pasajero);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@ID_Ruta", ID_Ruta);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void eliminar(int ID_Pasajero)
        {
            using (var con = ConexionBDD.GetConnection())
            {
                string cadena = "DELETE FROM Pasajeros WHERE ID_Pasajero = @ID_Pasajero";
                using (SqlCommand cmd = new SqlCommand(cadena, con))
                {
                    cmd.Parameters.AddWithValue("@ID_Pasajero", ID_Pasajero);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
