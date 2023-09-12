
namespace ProyectoBases
{
    partial class Directorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Directorios));
            this.DBA_USERS = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBA_USERS)).BeginInit();
            this.SuspendLayout();
            // 
            // DBA_USERS
            // 
            this.DBA_USERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBA_USERS.Location = new System.Drawing.Point(40, 96);
            this.DBA_USERS.Margin = new System.Windows.Forms.Padding(2);
            this.DBA_USERS.Name = "DBA_USERS";
            this.DBA_USERS.RowHeadersWidth = 62;
            this.DBA_USERS.RowTemplate.Height = 28;
            this.DBA_USERS.Size = new System.Drawing.Size(609, 335);
            this.DBA_USERS.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cargar Directorios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Directorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DBA_USERS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Directorios";
            this.Text = "Directorios";
            this.Load += new System.EventHandler(this.Directorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBA_USERS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DBA_USERS;
        private System.Windows.Forms.Button button1;
    }
}