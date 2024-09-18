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
using Prueba_2doParcial.Reportes;

namespace Prueba_2doParcial.Views.Rutas
{
    public partial class frm_reportes_rutas : Form
    {
        RutasController _Rutas = new RutasController();
        public frm_reportes_rutas()
        {
            InitializeComponent();
        }

        private void frm_reportes_rutas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Rutas' Puede moverla o quitarla según sea necesario.
            //this.rutas1TableAdapter.Fill(this.dataSet1.Rutas1,"");
            lstFiltro.DataSource = _Rutas.Todos();
            lstFiltro.DisplayMember = "Destino";
            lstFiltro.ValueMember = "ID_Ruta";


            this.reportViewer1.RefreshReport();
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            if(lstFiltro.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un destino");
            }
            else
            {
                this.rutas1TableAdapter.Fill(this.dataSet1.Rutas1, Convert.ToInt32(lstFiltro.SelectedValue));                
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
