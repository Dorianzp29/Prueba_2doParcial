using Prueba_2doParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_2doParcial.Controllers
{
    internal class PasajerosController
    {
        private PasajerosModels pasajero = new PasajerosModels();

        public List<PasajerosModels> Todos()
        {
            List<PasajerosModels> ListaPasajeros = new List<PasajerosModels>();
            ListaPasajeros = pasajero.Todos();
            return pasajero.Todos();
        }

        public void agregar(PasajerosModels pasajero)
        {
            pasajero.agregar();
        }

        public void modificar(PasajerosModels pasajero)
        {
            pasajero.modificar();
        }

        public void eliminar(int ID_Pasajero)
        {
            pasajero.eliminar(ID_Pasajero);
        }

    }
}
