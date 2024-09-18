namespace Prueba_2doParcial.Views.Pasajeros
{
    partial class frm_Pasajeros
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
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IDPasajero = new System.Windows.Forms.TextBox();
            this.txt_NombrePasa = new System.Windows.Forms.TextBox();
            this.txt_IDRuta = new System.Windows.Forms.TextBox();
            this.lstPasajeros = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(51, 451);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(125, 57);
            this.btn_Insertar.TabIndex = 0;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(182, 451);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(125, 57);
            this.btn_Modificar.TabIndex = 1;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(313, 451);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(125, 57);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(444, 451);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(125, 57);
            this.btn_Limpiar.TabIndex = 3;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(575, 451);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(125, 57);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Pasajero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Ruta";
            // 
            // txt_IDPasajero
            // 
            this.txt_IDPasajero.Location = new System.Drawing.Point(69, 116);
            this.txt_IDPasajero.Name = "txt_IDPasajero";
            this.txt_IDPasajero.Size = new System.Drawing.Size(221, 22);
            this.txt_IDPasajero.TabIndex = 8;
            // 
            // txt_NombrePasa
            // 
            this.txt_NombrePasa.Location = new System.Drawing.Point(69, 203);
            this.txt_NombrePasa.Name = "txt_NombrePasa";
            this.txt_NombrePasa.Size = new System.Drawing.Size(221, 22);
            this.txt_NombrePasa.TabIndex = 9;
            // 
            // txt_IDRuta
            // 
            this.txt_IDRuta.Location = new System.Drawing.Point(71, 277);
            this.txt_IDRuta.Name = "txt_IDRuta";
            this.txt_IDRuta.Size = new System.Drawing.Size(221, 22);
            this.txt_IDRuta.TabIndex = 10;
            // 
            // lstPasajeros
            // 
            this.lstPasajeros.FormattingEnabled = true;
            this.lstPasajeros.ItemHeight = 16;
            this.lstPasajeros.Location = new System.Drawing.Point(327, 74);
            this.lstPasajeros.Name = "lstPasajeros";
            this.lstPasajeros.Size = new System.Drawing.Size(421, 356);
            this.lstPasajeros.TabIndex = 11;
            this.lstPasajeros.DoubleClick += new System.EventHandler(this.lstPasajeros_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gestión de Pasajeros";
            // 
            // frm_Pasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 536);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstPasajeros);
            this.Controls.Add(this.txt_IDRuta);
            this.Controls.Add(this.txt_NombrePasa);
            this.Controls.Add(this.txt_IDPasajero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Insertar);
            this.Name = "frm_Pasajeros";
            this.Text = "frm_Pasajeros";
            this.Load += new System.EventHandler(this.frm_Pasajeros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IDPasajero;
        private System.Windows.Forms.TextBox txt_NombrePasa;
        private System.Windows.Forms.TextBox txt_IDRuta;
        private System.Windows.Forms.ListBox lstPasajeros;
        private System.Windows.Forms.Label label4;
    }
}