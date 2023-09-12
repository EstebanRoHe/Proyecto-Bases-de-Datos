
namespace ProyectoBases
{
    partial class CrearIndices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearIndices));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreIndice = new System.Windows.Forms.TextBox();
            this.Tabla = new System.Windows.Forms.TextBox();
            this.Columnas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Indice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tabla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Columnas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 242);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreIndice
            // 
            this.nombreIndice.Location = new System.Drawing.Point(292, 60);
            this.nombreIndice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombreIndice.Name = "nombreIndice";
            this.nombreIndice.Size = new System.Drawing.Size(255, 22);
            this.nombreIndice.TabIndex = 4;
            // 
            // Tabla
            // 
            this.Tabla.Location = new System.Drawing.Point(292, 109);
            this.Tabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(255, 22);
            this.Tabla.TabIndex = 5;
            // 
            // Columnas
            // 
            this.Columnas.Location = new System.Drawing.Point(292, 160);
            this.Columnas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Columnas.Name = "Columnas";
            this.Columnas.Size = new System.Drawing.Size(255, 22);
            this.Columnas.TabIndex = 6;
            // 
            // CrearIndices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 359);
            this.Controls.Add(this.Columnas);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.nombreIndice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CrearIndices";
            this.Text = "Índices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nombreIndice;
        private System.Windows.Forms.TextBox Tabla;
        private System.Windows.Forms.TextBox Columnas;
    }
}