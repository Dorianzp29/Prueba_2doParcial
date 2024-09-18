using Prueba_2doParcial.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_2doParcial.Models
{
    internal class ChoferesModels
    {
        public int ID_Chofer { get; set; }
        public string Nombre { get; set; }

        public string DisplayName
        {
            get
            {
                return ID_Chofer + " " + Nombre;
            }
        }

        SqlDataReader lector;
        List<ChoferesModels> ListaChoferes = new List<ChoferesModels>();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public List<ChoferesModels> Todos()
        {
            ListaChoferes.Clear();
            using (var con = ConexionBDD.GetConnection())
            {
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Choferes";
                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    ChoferesModels chofer = new ChoferesModels
                    {
                        ID_Chofer = Convert.ToInt32(lector["ID_Chofer"]),
                        Nombre = lector["Nombre"].ToString(),
                    };
                    ListaChoferes.Add(chofer);
                }
                return ListaChoferes;
            }
        }

        public void agregar()
        {
            using (var con = ConexionBDD.GetConnection())
            {
                string cadena = "INSERT INTO Choferes (Nombre) VALUES (@Nombre)";
                using (SqlCommand cmd = new SqlCommand(cadena, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void actualizar()
        {
            using (var con = ConexionBDD.GetConnection())
            {
                string cadena = "UPDATE Choferes SET Nombre = @Nombre WHERE ID_Chofer = @ID_Chofer";
                using (SqlCommand cmd = new SqlCommand(cadena, con))
                {
                    cmd.Parameters.AddWithValue("@ID_Chofer", ID_Chofer);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void eliminar(int ID_Chofer)
        {
            using (var con = ConexionBDD.GetConnection())
            {
                string cadena = "DELETE FROM Choferes WHERE ID_Chofer = @ID_Chofer";
                using (SqlCommand cmd = new SqlCommand(cadena, con))
                {
                    cmd.Parameters.AddWithValue("@ID_Chofer", ID_Chofer);
                    cmd.ExecuteNonQuery();
                }
            }
        }














    }
}
