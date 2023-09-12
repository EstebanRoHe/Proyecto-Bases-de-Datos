
namespace ProyectoBases
{
    partial class CrearRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearRole));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreRol = new System.Windows.Forms.TextBox();
            this.asignarA = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textUsuario1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asignar a";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Crear Rol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreRol
            // 
            this.nombreRol.Location = new System.Drawing.Point(141, 67);
            this.nombreRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(205, 22);
            this.nombreRol.TabIndex = 4;
            // 
            // asignarA
            // 
            this.asignarA.Location = new System.Drawing.Point(141, 134);
            this.asignarA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.asignarA.Name = "asignarA";
            this.asignarA.Size = new System.Drawing.Size(204, 22);
            this.asignarA.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(544, 105);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Eliminar Rol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textUsuario1
            // 
            this.textUsuario1.Location = new System.Drawing.Point(544, 64);
            this.textUsuario1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUsuario1.Name = "textUsuario1";
            this.textUsuario1.Size = new System.Drawing.Size(140, 22);
            this.textUsuario1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Usuario";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CrearRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 359);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textUsuario1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.asignarA);
            this.Controls.Add(this.nombreRol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CrearRole";
            this.Text = "Crear Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nombreRol;
        private System.Windows.Forms.TextBox asignarA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textUsuario1;
        private System.Windows.Forms.Label label5;
    }
}