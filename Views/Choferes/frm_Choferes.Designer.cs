namespace Prueba_2doParcial.Views.Choferes
{
    partial class frm_Choferes
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
            this.lstChoferes = new System.Windows.Forms.ListBox();
            this.txt_IDChofer = new System.Windows.Forms.TextBox();
            this.txt_NombreChoferes = new System.Windows.Forms.TextBox();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Choferes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Chofer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // lstChoferes
            // 
            this.lstChoferes.FormattingEnabled = true;
            this.lstChoferes.ItemHeight = 16;
            this.lstChoferes.Location = new System.Drawing.Point(331, 109);
            this.lstChoferes.Name = "lstChoferes";
            this.lstChoferes.Size = new System.Drawing.Size(427, 308);
            this.lstChoferes.TabIndex = 3;
            this.lstChoferes.DoubleClick += new System.EventHandler(this.lstChoferes_DoubleClick);
            // 
            // txt_IDChofer
            // 
            this.txt_IDChofer.Location = new System.Drawing.Point(28, 189);
            this.txt_IDChofer.Name = "txt_IDChofer";
            this.txt_IDChofer.Size = new System.Drawing.Size(285, 22);
            this.txt_IDChofer.TabIndex = 4;
            // 
            // txt_NombreChoferes
            // 
            this.txt_NombreChoferes.Location = new System.Drawing.Point(28, 335);
            this.txt_NombreChoferes.Name = "txt_NombreChoferes";
            this.txt_NombreChoferes.Size = new System.Drawing.Size(285, 22);
            this.txt_NombreChoferes.TabIndex = 5;
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(28, 452);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(130, 59);
            this.btn_Insertar.TabIndex = 6;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(183, 453);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(130, 59);
            this.btn_Modificar.TabIndex = 7;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(331, 452);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(130, 59);
            this.btn_Eliminar.TabIndex = 8;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(478, 453);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(130, 59);
            this.btn_Limpiar.TabIndex = 9;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(626, 453);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(130, 59);
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frm_Choferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 526);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Insertar);
            this.Controls.Add(this.txt_NombreChoferes);
            this.Controls.Add(this.txt_IDChofer);
            this.Controls.Add(this.lstChoferes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Choferes";
            this.Text = "frm_Choferes";
            this.Load += new System.EventHandler(this.frm_Choferes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstChoferes;
        private System.Windows.Forms.TextBox txt_IDChofer;
        private System.Windows.Forms.TextBox txt_NombreChoferes;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}