namespace Prueba_2doParcial.Views.Rutas
{
    partial class frm_reportes_rutas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lstFiltro = new System.Windows.Forms.ListBox();
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.rutasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Prueba_2doParcial.Reportes.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rutasTableAdapter = new Prueba_2doParcial.Reportes.DataSet1TableAdapters.RutasTableAdapter();
            this.rutas1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rutas1TableAdapter = new Prueba_2doParcial.Reportes.DataSet1TableAdapters.Rutas1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutas1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rutas1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Prueba_2doParcial.Reportes.Rutas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(795, 443);
            this.reportViewer1.TabIndex = 0;
            // 
            // lstFiltro
            // 
            this.lstFiltro.FormattingEnabled = true;
            this.lstFiltro.ItemHeight = 16;
            this.lstFiltro.Location = new System.Drawing.Point(804, 31);
            this.lstFiltro.Name = "lstFiltro";
            this.lstFiltro.Size = new System.Drawing.Size(274, 228);
            this.lstFiltro.TabIndex = 1;
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.Location = new System.Drawing.Point(862, 275);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(166, 106);
            this.btn_Cargar.TabIndex = 2;
            this.btn_Cargar.Text = "Cargar Reporte";
            this.btn_Cargar.UseVisualStyleBackColor = true;
            this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
            // 
            // rutasBindingSource
            // 
            this.rutasBindingSource.DataMember = "Rutas";
            this.rutasBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // rutasTableAdapter
            // 
            this.rutasTableAdapter.ClearBeforeFill = true;
            // 
            // rutas1BindingSource
            // 
            this.rutas1BindingSource.DataMember = "Rutas1";
            this.rutas1BindingSource.DataSource = this.dataSet1;
            // 
            // rutas1TableAdapter
            // 
            this.rutas1TableAdapter.ClearBeforeFill = true;
            // 
            // frm_reportes_rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 450);
            this.Controls.Add(this.btn_Cargar);
            this.Controls.Add(this.lstFiltro);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_reportes_rutas";
            this.Text = "frm_reportes_rutas";
            this.Load += new System.EventHandler(this.frm_reportes_rutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutas1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private Reportes.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rutasBindingSource;
        private Reportes.DataSet1TableAdapters.RutasTableAdapter rutasTableAdapter;
        private System.Windows.Forms.ListBox lstFiltro;
        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.BindingSource rutas1BindingSource;
        private Reportes.DataSet1TableAdapters.Rutas1TableAdapter rutas1TableAdapter;
    }
}