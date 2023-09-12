
namespace ProyectoBases
{
    partial class CrearRespaldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearRespaldo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomSchema = new System.Windows.Forms.TextBox();
            this.userSchema = new System.Windows.Forms.TextBox();
            this.passUserSchema = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(771, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario Administrador del Schema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(757, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Schema";
            // 
            // nomSchema
            // 
            this.nomSchema.Location = new System.Drawing.Point(840, 159);
            this.nomSchema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomSchema.Name = "nomSchema";
            this.nomSchema.Size = new System.Drawing.Size(152, 22);
            this.nomSchema.TabIndex = 4;
            // 
            // userSchema
            // 
            this.userSchema.Location = new System.Drawing.Point(257, 162);
            this.userSchema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userSchema.Name = "userSchema";
            this.userSchema.Size = new System.Drawing.Size(152, 22);
            this.userSchema.TabIndex = 5;
            // 
            // passUserSchema
            // 
            this.passUserSchema.Location = new System.Drawing.Point(840, 118);
            this.passUserSchema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passUserSchema.Name = "passUserSchema";
            this.passUserSchema.Size = new System.Drawing.Size(152, 22);
            this.passUserSchema.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Crear Repaldo por Schema";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 49);
            this.button3.TabIndex = 16;
            this.button3.Text = "Crear Respaldo FULL ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(817, 211);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 49);
            this.button2.TabIndex = 17;
            this.button2.Text = "Crear Repaldo de Tabla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CrearRespaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passUserSchema);
            this.Controls.Add(this.userSchema);
            this.Controls.Add(this.nomSchema);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CrearRespaldo";
            this.Text = "Respaldos";
            this.Load += new System.EventHandler(this.CrearRespaldo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomSchema;
        private System.Windows.Forms.TextBox userSchema;
        private System.Windows.Forms.TextBox passUserSchema;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}