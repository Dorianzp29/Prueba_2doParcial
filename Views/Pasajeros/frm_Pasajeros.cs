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

namespace Prueba_2doParcial.Views.Pasajeros
{
    public partial class frm_Pasajeros : Form
    {
        public frm_Pasajeros()
        {
            InitializeComponent();
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            PasajerosModels pasajero = new PasajerosModels
            {
                ID_Pasajero = Convert.ToInt32(lstPasajeros.SelectedValue),
                Nombre = txt_NombrePasa.Text,
                ID_Ruta = Convert.ToInt32(txt_IDRuta),
            };

            PasajerosController pasajeroController = new PasajerosController();
            try
            {
                pasajeroController.agregar(pasajero);
                MessageBox.Show("Pasajero agregado correctamente");
                cargarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el pasajero: " + ex.Message);
            }
        }

        private void frm_Pasajeros_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        public void cargarLista()
        {
            PasajerosController PasajerosController = new PasajerosController();
            lstPasajeros.DataSource = PasajerosController.Todos();
            lstPasajeros.DisplayMember = "DisplayName";
            lstPasajeros.ValueMember = "ID_Pasajero";
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (lstPasajeros.SelectedValue != null)
            {
                PasajerosModels pasajeroSeleccionado = (PasajerosModels)lstPasajeros.SelectedItem;
                pasajeroSeleccionado.Nombre = txt_NombrePasa.Text;
                pasajeroSeleccionado.ID_Ruta = Convert.ToInt32(txt_IDRuta.Text);


                PasajerosController pasajerosController = new PasajerosController();
                try
                {
                    pasajerosController.modificar(pasajeroSeleccionado);
                    MessageBox.Show("Pasajero modificado correctamente");
                    cargarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el pasajero: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pasajero");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if(lstPasajeros.SelectedItem != null)
            {

               PasajerosModels pasajeroSeleccionado = (PasajerosModels)lstPasajeros.SelectedItem;
                PasajerosController pasajerosController = new PasajerosController();
                try
                {
                    pasajerosController.eliminar(pasajeroSeleccionado.ID_Pasajero);
                    MessageBox.Show("Pasajero eliminado correctamente");
                    cargarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el pasajero: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pasajero");
            }}

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_IDPasajero.Text = "";
            txt_NombrePasa.Text = "";
            txt_IDRuta.Text = "";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstPasajeros_DoubleClick(object sender, EventArgs e)
        {
            if(lstPasajeros.SelectedItem != null)
            {

               PasajerosModels pasajeroSeleccionado = (PasajerosModels)lstPasajeros.SelectedItem;
                txt_IDPasajero.Text = pasajeroSeleccionado.ID_Pasajero.ToString();
                txt_NombrePasa.Text = pasajeroSeleccionado.Nombre;
                txt_IDRuta.Text = pasajeroSeleccionado.ID_Ruta.ToString();}
        }
    }
}


