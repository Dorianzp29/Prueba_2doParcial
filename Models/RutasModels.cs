using Prueba_2doParcial.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_2doParcial.Models
{
    internal class RutasModels
    {
        public int ID_Ruta { get; set; }
        public string Destino { get; set; }
        public int ID_Chofer { get; set; }
        public int ID_Autobuses { get; set; }

        public string DisplayName
        {
            get
            {
                return ID_Ruta + " " + Destino + " " + ID_Chofer + " " + ID_Autobuses;
            }
        }

        SqlDataReader lector;
        List<RutasModels> ListaRutas = new List<RutasModels>();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public List<RutasModels> Todos()
        {
            ListaRutas.Clear();
            using (var con = ConexionBDD.GetConnection())
            {
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Rutas";
                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    RutasModels ruta = new RutasModels
                    {
                        ID_Ruta = Convert.ToInt32(lector["ID_Ruta"]),
                        Destino = lector["Destino"].ToString(),
                        ID_Chofer = Convert.ToInt32(lector["ID_Chofer"]),
                        ID_Autobuses = Convert.ToInt32(lector["ID_Autobuses"]),
                    };
                    ListaRutas.Add(ruta);
                }
                return ListaRutas;
            }



        }

        public void agregar()
        {
            using (var con = ConexionBDD.GetConnection())
            {
                string cadena = "INSERT INTO Rutas (Destino, ID_Chofer, ID_Autobuses) VALUES (@Destino, @ID_Chofer, @ID_Autobuses)";
                using (SqlCommand cmd = new SqlCommand(cadena, con))
                {
                    cmd.Parameters.AddWithValue("@Destino", Destino);
                    cmd.Parameters.AddWithValue("@ID_Chofer", ID_Chofer);
                    cmd.Parameters.AddWithValue("@ID_Autobuses", ID_Autobuses);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void actualizar()
        {
            using (var con = ConexionBDD.GetConnection())
            {
                string cadena = "UPDATE Rutas SET Destino = @Destino, ID_Chofer = @ID_Chofer, ID_Autobuses = @ID_Autobuses WHERE ID_Ruta = @ID_Ruta";
                using (SqlCommand cmd = new SqlCommand(cadena, con))
                {
                    cmd.Parameters.AddWithValue("@ID_Ruta", ID_Ruta);
                    cmd.Parameters.AddWithValue("@Destino", Destino);
                    cmd.Parameters.AddWithValue("@ID_Chofer", ID_Chofer);
                    cmd.Parameters.AddWithValue("@ID_Autobuses", ID_Autobuses);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void eliminar(int ID_Ruta)
        {
            using (var con = ConexionBDD.GetConnection())
            {
                string cadena = "DELETE FROM Rutas WHERE ID_Ruta = @ID_Ruta";
                using (SqlCommand cmd = new SqlCommand(cadena, con))
                {
                    cmd.Parameters.AddWithValue("@ID_Ruta", ID_Ruta);
                    cmd.ExecuteNonQuery();
                }
            }
        }



    }
}
