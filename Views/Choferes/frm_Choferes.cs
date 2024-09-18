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
using Prueba_2doParcial.Controllers;

namespace Prueba_2doParcial.Views.Choferes
{
    public partial class frm_Choferes : Form
    {
        public frm_Choferes()
        {
            InitializeComponent();
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            ChoferesModels chofer = new ChoferesModels
            {
                ID_Chofer = Convert.ToInt32(lstChoferes.SelectedValue),
                Nombre = txt_NombreChoferes.Text,
            };

            ChoferesController chofercontroller = new ChoferesController();
            try
            {
                chofercontroller.agregar(chofer);
                MessageBox.Show("Chofer agregado correctamente");
                cargarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el chofer: " + ex.Message);
            }
        }

        private void frm_Choferes_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        public void cargarLista()
        {
            ChoferesController ChoferesController = new ChoferesController();
            lstChoferes.DataSource = ChoferesController.Todos();
            lstChoferes.DisplayMember = "DisplayName";
            lstChoferes.ValueMember = "ID_Chofer";
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (lstChoferes.SelectedValue != null)
            {
                ChoferesModels choferSeleccionado = (ChoferesModels)lstChoferes.SelectedItem;
                choferSeleccionado.Nombre = txt_NombreChoferes.Text;

                ChoferesController choferesController = new ChoferesController();
                try
                {
                    choferesController.modificar(choferSeleccionado);
                    MessageBox.Show("Chofer modificado correctamente");
                    cargarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el chofer: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un chofer para modificar");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lstChoferes.SelectedItem != null)
            {
                ChoferesModels choferSeleccionado = (ChoferesModels)lstChoferes.SelectedItem;
                ChoferesController choferesController = new ChoferesController();
                try
                {
                    choferesController.eliminar(choferSeleccionado.ID_Chofer);
                    MessageBox.Show("Chofer eliminado correctamente");
                    cargarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el chofer: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un chofer para eliminar");
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_IDChofer.Text = "";
            txt_NombreChoferes.Text = "";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstChoferes_DoubleClick(object sender, EventArgs e)
        {
            if(lstChoferes.SelectedItem != null)
            {

               ChoferesModels choferSeleccionado = (ChoferesModels)lstChoferes.SelectedItem;
                txt_IDChofer.Text = choferSeleccionado.ID_Chofer.ToString();
                txt_NombreChoferes.Text = choferSeleccionado.Nombre;
        }   }
    }
}

