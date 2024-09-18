using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba_2doParcial.Models;

namespace Prueba_2doParcial.Controllers
{
    internal class AutobusesController
    {
        private AutobusesModels autobus = new AutobusesModels();

        public List<AutobusesModels> Todos()
        {
            List<AutobusesModels> ListaAutobuses = new List<AutobusesModels>();
            ListaAutobuses = autobus.Todos();
            return autobus.Todos();
        }

        public void agregar(AutobusesModels autobus)
        {
            autobus.agregar();
        }

        public void modificar(AutobusesModels autobus)
        {
            autobus.actualizar();
        }
        public void eliminar(int ID_Autobus)
        {
            autobus.eliminar(ID_Autobus);
        }

       
    }
}
