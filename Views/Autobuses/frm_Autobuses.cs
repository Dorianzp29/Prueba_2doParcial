using Prueba_2doParcial.Controllers;
using Prueba_2doParcial.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_2doParcial.Views.Autobuses
{
    public partial class frm_Autobuses : Form
    {
        public frm_Autobuses()
        {
            InitializeComponent();
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            AutobusesModels autobus = new AutobusesModels
            {
                ID_Autobus = Convert.ToInt32(lstAutobuses.SelectedValue),
                Modelo = txt_Modelo.Text,
            };

            AutobusesController autobuscontroller = new AutobusesController();
            try
            {
                autobuscontroller.agregar(autobus);
                MessageBox.Show("Autobus agregado correctamente");
                cargarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el autobus: " + ex.Message);
            }
        }

        private void frm_Autobuses_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        public void cargarLista()
        {
            AutobusesController AutobusesController = new AutobusesController();
            lstAutobuses.DataSource = AutobusesController.Todos();
            lstAutobuses.DisplayMember = "DisplayName";
            lstAutobuses.ValueMember = "ID_Autobus";
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (lstAutobuses.SelectedValue != null)
            {
                AutobusesModels autobusSeleccionado = (AutobusesModels)lstAutobuses.SelectedItem;
                autobusSeleccionado.Modelo = txt_Modelo.Text;

                AutobusesController autobusesController = new AutobusesController();
                try
                {
                    autobusesController.modificar(autobusSeleccionado);
                    MessageBox.Show("Autobus modificado correctamente");
                    cargarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el autobus: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un autobus para modificar");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Eliminar
            if (lstAutobuses.SelectedItem != null)
            {
                AutobusesModels autobusSeleccionado = (AutobusesModels)lstAutobuses.SelectedItem;
                AutobusesController autobusesController = new AutobusesController();
                try
                {
                    autobusesController.eliminar(autobusSeleccionado.ID_Autobus);
                    MessageBox.Show("Autobus eliminado correctamente");
                    cargarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el autobus: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un autobus para eliminar");
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_IDBus.Text = "";
            txt_Modelo.Text = "";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstAutobuses_DoubleClick(object sender, EventArgs e)
        {
            if(lstAutobuses.SelectedItem != null)
            {
                AutobusesModels autobusSeleccionado = (AutobusesModels)lstAutobuses.SelectedItem;
                txt_IDBus.Text = autobusSeleccionado.ID_Autobus.ToString();
                txt_Modelo.Text = autobusSeleccionado.Modelo;
            }
        }
    }
}
