using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba_2doParcial.Models;

namespace Prueba_2doParcial.Controllers
{
    internal class RutasController
    {
        private RutasModels ruta = new RutasModels();

        public List<RutasModels> Todos()
            {
            List<RutasModels> ListaRutas = new List<RutasModels>();
            ListaRutas = ruta.Todos();
            return ruta.Todos();
        }

        public void agregar(RutasModels ruta)
        {
            ruta.agregar();
        }

        public void modificar(RutasModels ruta)
        {
            ruta.actualizar();
        }

        public void eliminar(int ID_Ruta)
        {
            ruta.eliminar(ID_Ruta);
        }
    }
}
