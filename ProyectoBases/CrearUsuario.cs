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
    public partial class CrearUsuario : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = 192.168.0.23/xe ; PASSWORD=1234; USER ID = SYSTEM;");
        OracleCommand comando;


        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;
            

            try
            {
                ora.Open();
                comando = new OracleCommand("alter session set \"_oracle_script\" = true", ora);
                comando.ExecuteNonQuery();

                comando = new OracleCommand("CREATE USER " + username + " IDENTIFIED BY " + password, ora);
                comando.ExecuteNonQuery();

                comando = new OracleCommand("GRANT RESOURCE TO " + username, ora);
                comando.ExecuteNonQuery();

                comando = new OracleCommand("GRANT CONNECT TO " + username, ora);
                comando.ExecuteNonQuery();

                comando = new OracleCommand("GRANT ALL PRIVILEGES TO " + username, ora);
                comando.ExecuteNonQuery();

                MessageBox.Show("Usuario Creado");
                this.Close();
            }
            catch (Exception ex)
            {
                ora.Close();
                MessageBox.Show(ex.Message);
            }
            ora.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //username
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //identified
        }
    }
}
