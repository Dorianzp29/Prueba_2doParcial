using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba_2doParcial.Controllers;
using Prueba_2doParcial.Models;

namespace Prueba_2doParcial.Views.Rutas
{
    public partial class frm_Rutas : Form
    {
        public frm_Rutas()
        {
            InitializeComponent();
        }

        private void frm_Rutas_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        public void cargarLista()
        {
            RutasController RutasController = new RutasController();
            lstRutas.DataSource = RutasController.Todos();
            lstRutas.DisplayMember = "DisplayName";
            lstRutas.ValueMember = "ID_Ruta";
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            RutasModels ruta = new RutasModels
            {
                ID_Ruta = Convert.ToInt32(lstRutas.SelectedValue),
                Destino = txt_Destino.Text,
                ID_Autobuses = Convert.ToInt32(txt_IDAutobusRuta.Text),
                ID_Chofer = Convert.ToInt32(txt_IDChoferRuta.Text),
            };

            RutasController rutaController = new RutasController();
            try
            {
                rutaController.agregar(ruta);
                MessageBox.Show("Ruta agregada correctamente");
                cargarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la ruta: " + ex.Message);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (lstRutas.SelectedValue != null)
            {
                RutasModels rutaSeleccionada = (RutasModels)lstRutas.SelectedItem;
                rutaSeleccionada.Destino = txt_Destino.Text;
                rutaSeleccionada.ID_Autobuses = Convert.ToInt32(txt_IDAutobusRuta.Text);
                rutaSeleccionada.ID_Chofer = Convert.ToInt32(txt_IDChoferRuta.Text);

                RutasController rutaController = new RutasController();
                try
                {
                    rutaController.modificar(rutaSeleccionada);
                    MessageBox.Show("Ruta modificada correctamente");
                    cargarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar la ruta: " + ex.Message);
                }
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lstRutas.SelectedItem != null)
            {
                RutasModels rutaSeleccionada = (RutasModels)lstRutas.SelectedItem;
                RutasController rutaController = new RutasController();
                try
                {
                    rutaController.eliminar(rutaSeleccionada.ID_Ruta);
                    MessageBox.Show("Ruta eliminada correctamente");
                    cargarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la ruta: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una ruta para eliminar");
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Destino.Text = "";
            txt_IDAutobusRuta.Text = "";
            txt_IDChoferRuta.Text = "";
            txt_IDRuta.Text = "";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstRutas_DoubleClick(object sender, EventArgs e)
        {
            if (lstRutas.SelectedItem != null)
            {
                RutasModels rutaSeleccionada = (RutasModels)lstRutas.SelectedItem;
                txt_IDRuta.Text = rutaSeleccionada.ID_Ruta.ToString();
                txt_Destino.Text = rutaSeleccionada.Destino;
                txt_IDAutobusRuta.Text = rutaSeleccionada.ID_Autobuses.ToString();
                txt_IDChoferRuta.Text = rutaSeleccionada.ID_Chofer.ToString();
            }
        }
    }
}
