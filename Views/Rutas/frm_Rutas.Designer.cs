namespace Prueba_2doParcial.Views.Rutas
{
    partial class frm_Rutas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_IDRuta = new System.Windows.Forms.TextBox();
            this.txt_Destino = new System.Windows.Forms.TextBox();
            this.txt_IDChoferRuta = new System.Windows.Forms.TextBox();
            this.txt_IDAutobusRuta = new System.Windows.Forms.TextBox();
            this.lstRutas = new System.Windows.Forms.ListBox();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Ruta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Chofer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Autobus";
            // 
            // txt_IDRuta
            // 
            this.txt_IDRuta.Location = new System.Drawing.Point(68, 145);
            this.txt_IDRuta.Name = "txt_IDRuta";
            this.txt_IDRuta.Size = new System.Drawing.Size(231, 22);
            this.txt_IDRuta.TabIndex = 4;
            // 
            // txt_Destino
            // 
            this.txt_Destino.Location = new System.Drawing.Point(68, 216);
            this.txt_Destino.Name = "txt_Destino";
            this.txt_Destino.Size = new System.Drawing.Size(231, 22);
            this.txt_Destino.TabIndex = 5;
            // 
            // txt_IDChoferRuta
            // 
            this.txt_IDChoferRuta.Location = new System.Drawing.Point(68, 290);
            this.txt_IDChoferRuta.Name = "txt_IDChoferRuta";
            this.txt_IDChoferRuta.Size = new System.Drawing.Size(231, 22);
            this.txt_IDChoferRuta.TabIndex = 6;
            // 
            // txt_IDAutobusRuta
            // 
            this.txt_IDAutobusRuta.Location = new System.Drawing.Point(68, 363);
            this.txt_IDAutobusRuta.Name = "txt_IDAutobusRuta";
            this.txt_IDAutobusRuta.Size = new System.Drawing.Size(231, 22);
            this.txt_IDAutobusRuta.TabIndex = 7;
            // 
            // lstRutas
            // 
            this.lstRutas.FormattingEnabled = true;
            this.lstRutas.ItemHeight = 16;
            this.lstRutas.Location = new System.Drawing.Point(368, 114);
            this.lstRutas.Name = "lstRutas";
            this.lstRutas.Size = new System.Drawing.Size(559, 276);
            this.lstRutas.TabIndex = 8;
            this.lstRutas.DoubleClick += new System.EventHandler(this.lstRutas_DoubleClick);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(68, 462);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(129, 54);
            this.btn_Insertar.TabIndex = 9;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(238, 462);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(129, 54);
            this.btn_Modificar.TabIndex = 10;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(412, 462);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(129, 54);
            this.btn_Eliminar.TabIndex = 11;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(585, 462);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(129, 54);
            this.btn_Limpiar.TabIndex = 12;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(762, 462);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(129, 54);
            this.btn_Cancelar.TabIndex = 13;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gestión de Rutas";
            // 
            // frm_Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 549);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Insertar);
            this.Controls.Add(this.lstRutas);
            this.Controls.Add(this.txt_IDAutobusRuta);
            this.Controls.Add(this.txt_IDChoferRuta);
            this.Controls.Add(this.txt_Destino);
            this.Controls.Add(this.txt_IDRuta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Rutas";
            this.Text = "frm_Rutas";
            this.Load += new System.EventHandler(this.frm_Rutas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_IDRuta;
        private System.Windows.Forms.TextBox txt_Destino;
        private System.Windows.Forms.TextBox txt_IDChoferRuta;
        private System.Windows.Forms.TextBox txt_IDAutobusRuta;
        private System.Windows.Forms.ListBox lstRutas;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label5;
    }
}