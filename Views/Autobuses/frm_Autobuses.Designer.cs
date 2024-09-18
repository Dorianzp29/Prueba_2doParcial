namespace Prueba_2doParcial.Views.Autobuses
{
    partial class frm_Autobuses
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
            this.lstAutobuses = new System.Windows.Forms.ListBox();
            this.txt_IDBus = new System.Windows.Forms.TextBox();
            this.txt_Modelo = new System.Windows.Forms.TextBox();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Autobuses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Autobus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // lstAutobuses
            // 
            this.lstAutobuses.FormattingEnabled = true;
            this.lstAutobuses.ItemHeight = 16;
            this.lstAutobuses.Location = new System.Drawing.Point(358, 34);
            this.lstAutobuses.Name = "lstAutobuses";
            this.lstAutobuses.Size = new System.Drawing.Size(371, 356);
            this.lstAutobuses.TabIndex = 3;
            this.lstAutobuses.DoubleClick += new System.EventHandler(this.lstAutobuses_DoubleClick);
            // 
            // txt_IDBus
            // 
            this.txt_IDBus.Location = new System.Drawing.Point(52, 154);
            this.txt_IDBus.Name = "txt_IDBus";
            this.txt_IDBus.Size = new System.Drawing.Size(263, 22);
            this.txt_IDBus.TabIndex = 4;
            // 
            // txt_Modelo
            // 
            this.txt_Modelo.Location = new System.Drawing.Point(52, 248);
            this.txt_Modelo.Name = "txt_Modelo";
            this.txt_Modelo.Size = new System.Drawing.Size(263, 22);
            this.txt_Modelo.TabIndex = 5;
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(7, 424);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(127, 56);
            this.btn_Insertar.TabIndex = 6;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(154, 424);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(127, 56);
            this.btn_Modificar.TabIndex = 7;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 56);
            this.button3.TabIndex = 8;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(446, 423);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(127, 56);
            this.btn_Limpiar.TabIndex = 9;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(595, 424);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(127, 56);
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frm_Autobuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 492);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Insertar);
            this.Controls.Add(this.txt_Modelo);
            this.Controls.Add(this.txt_IDBus);
            this.Controls.Add(this.lstAutobuses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Autobuses";
            this.Text = "frm_Autobuses";
            this.Load += new System.EventHandler(this.frm_Autobuses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstAutobuses;
        private System.Windows.Forms.TextBox txt_IDBus;
        private System.Windows.Forms.TextBox txt_Modelo;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}