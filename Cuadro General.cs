using Prueba_2doParcial.Views.Autobuses;
using Prueba_2doParcial.Views.Choferes;
using Prueba_2doParcial.Views.Pasajeros;
using Prueba_2doParcial.Views.Rutas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_2doParcial
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void autobusesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Autobuses _Autobuses = new frm_Autobuses();
            _Autobuses.ShowDialog();
        }

        private void choferesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Choferes _Choferes = new frm_Choferes();
            _Choferes.ShowDialog();
        }

        private void pasajerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Pasajeros _Pasajeros = new frm_Pasajeros();
            _Pasajeros.ShowDialog();
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Rutas _Rutas = new frm_Rutas();
            _Rutas.ShowDialog();
        }

        private void reporteRutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_reportes_rutas _ReporteRutas = new frm_reportes_rutas();
            _ReporteRutas.ShowDialog();
        }

        private void reporteRutasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_reportes_rutas _Reportes_Rutas = new frm_reportes_rutas();
            _Reportes_Rutas.ShowDialog();
        }
    }
}
