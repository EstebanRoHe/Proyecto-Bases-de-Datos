using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OracleClient;
using System.IO;
using System.Diagnostics;

namespace ProyectoBases
{
    public partial class EliminarUsuario : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = 192.168.0.23/xe ; PASSWORD=1234; USER ID = SYSTEM;");
        OracleCommand comando;
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombreUsuario = username.Text;
            ora.Open();

            try
            {
                comando = new OracleCommand("alter session set \"_oracle_script\" = true", ora);
                comando.ExecuteNonQuery();
                MessageBox.Show("Alter session");

                comando = new OracleCommand("DROP USER " + nombreUsuario + " CASCADE", ora);
                comando.ExecuteNonQuery();

                MessageBox.Show("Usuario eliminado");
                this.Close();


            }
            catch(Exception ex)
            {
                ora.Close();
                MessageBox.Show(ex.Message);
            }
            ora.Close();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
