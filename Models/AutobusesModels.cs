using Prueba_2doParcial.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_2doParcial.Models
{
    internal class AutobusesModels
    {
        public int ID_Autobus { get; set; }
        public string Modelo { get; set; }

        public string DisplayName
        {

            get
            {
                return ID_Autobus + " " + Modelo;
            }
        }


        SqlDataReader lector;
        List<AutobusesModels> ListaAutobuses = new List<AutobusesModels>();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public List<AutobusesModels> Todos()
        {
            ListaAutobuses.Clear();
            using (var con = ConexionBDD.GetConnection())
            {
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Autobuses";
                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    AutobusesModels autobus = new AutobusesModels
                    {
                        ID_Autobus = Convert.ToInt32(lector["ID_Autobus"]),
                        Modelo = lector["Modelo"].ToString(),
                    };
                    ListaAutobuses.Add(autobus);
                }
                return ListaAutobuses;
            }
        }

        public void agregar()
        {
            using (var con = ConexionBDD.GetConnection())
            {
                string cadena = "INSERT INTO Autobuses(Modelo) VALUES(@Modelo)";
                using (SqlCommand cmd = new SqlCommand(cadena, con))
                {
                    cmd.Parameters.AddWithValue("@Modelo", Modelo);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public void actualizar()
        {
            using (var con = ConexionBDD.GetConnection())
            {
                string cadena = "UPDATE Autobuses SET Modelo = @Modelo WHERE ID_Autobus = @ID_Autobus";
                using (SqlCommand cmd = new SqlCommand(cadena, con))
                {
                    cmd.Parameters.AddWithValue("@Modelo", Modelo);
                    cmd.Parameters.AddWithValue("@ID_Autobus", ID_Autobus);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void eliminar(int ID_Autobus)
        {
            using (var con = ConexionBDD.GetConnection())
            {
                string cadena = "DELETE FROM Autobuses WHERE ID_Autobus = @ID_Autobus";
                using (SqlCommand cmd = new SqlCommand(cadena, con))
                {
                    cmd.Parameters.AddWithValue("@ID_Autobus", ID_Autobus);
                    cmd.ExecuteNonQuery();
                }
            }








        }
    }
}
