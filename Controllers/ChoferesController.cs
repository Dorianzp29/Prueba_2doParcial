using Prueba_2doParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_2doParcial.Controllers
{
    internal class ChoferesController
    {
        private ChoferesModels chofer = new ChoferesModels();

        public List<ChoferesModels> Todos()
        {

           List<ChoferesModels> ListaChoferes = new List<ChoferesModels>();
            ListaChoferes = chofer.Todos();
            return chofer.Todos();
        }

        public void agregar(ChoferesModels chofer)
        {
            chofer.agregar();
        }

        public void modificar(ChoferesModels chofer)
        {
            chofer.actualizar();
        }

        public void eliminar(int ID_Chofer)
        {
            chofer.eliminar(ID_Chofer);
        }
    }
}
