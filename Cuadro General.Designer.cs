namespace Prueba_2doParcial
{
    partial class Menu_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.autobusesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choferesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteRutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteRutasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autobusesToolStripMenuItem,
            this.choferesToolStripMenuItem,
            this.pasajerasToolStripMenuItem,
            this.rutasToolStripMenuItem,
            this.reporteRutasToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // autobusesToolStripMenuItem
            // 
            this.autobusesToolStripMenuItem.Name = "autobusesToolStripMenuItem";
            this.autobusesToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.autobusesToolStripMenuItem.Text = "Autobuses";
            this.autobusesToolStripMenuItem.Click += new System.EventHandler(this.autobusesToolStripMenuItem_Click);
            // 
            // choferesToolStripMenuItem
            // 
            this.choferesToolStripMenuItem.Name = "choferesToolStripMenuItem";
            this.choferesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.choferesToolStripMenuItem.Text = "Choferes";
            this.choferesToolStripMenuItem.Click += new System.EventHandler(this.choferesToolStripMenuItem_Click);
            // 
            // pasajerasToolStripMenuItem
            // 
            this.pasajerasToolStripMenuItem.Name = "pasajerasToolStripMenuItem";
            this.pasajerasToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.pasajerasToolStripMenuItem.Text = "Pasajeros";
            this.pasajerasToolStripMenuItem.Click += new System.EventHandler(this.pasajerasToolStripMenuItem_Click);
            // 
            // rutasToolStripMenuItem
            // 
            this.rutasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteRutasToolStripMenuItem});
            this.rutasToolStripMenuItem.Name = "rutasToolStripMenuItem";
            this.rutasToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.rutasToolStripMenuItem.Text = "Rutas";
            this.rutasToolStripMenuItem.Click += new System.EventHandler(this.rutasToolStripMenuItem_Click);
            // 
            // reporteRutasToolStripMenuItem
            // 
            this.reporteRutasToolStripMenuItem.Name = "reporteRutasToolStripMenuItem";
            this.reporteRutasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reporteRutasToolStripMenuItem.Text = "Reporte Rutas";
            this.reporteRutasToolStripMenuItem.Click += new System.EventHandler(this.reporteRutasToolStripMenuItem_Click);
            // 
            // reporteRutasToolStripMenuItem1
            // 
            this.reporteRutasToolStripMenuItem1.Name = "reporteRutasToolStripMenuItem1";
            this.reporteRutasToolStripMenuItem1.Size = new System.Drawing.Size(116, 24);
            this.reporteRutasToolStripMenuItem1.Text = "Reporte Rutas";
            this.reporteRutasToolStripMenuItem1.Click += new System.EventHandler(this.reporteRutasToolStripMenuItem1_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Principal";
            this.Text = "Menú Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem autobusesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choferesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasajerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteRutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteRutasToolStripMenuItem1;
    }
}

