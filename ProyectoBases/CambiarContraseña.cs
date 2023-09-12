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
    public partial class CambiarContraseña : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = 192.168.0.23/xe ; PASSWORD=1234; USER ID = SYSTEM;");
        OracleCommand comando;
        public CambiarContraseña()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = username.Text;
            string password = identified.Text;
            string newPassword = newIdentified.Text;
            ora.Open();

            try
            {
                comando = new OracleCommand("alter session set \"_oracle_script\" = true", ora);
                comando.ExecuteNonQuery();

                comando = new OracleCommand("ALTER user "+nombreUsuario+" identified by "+password+" replace "+ newPassword, ora);
                comando.ExecuteNonQuery();

                MessageBox.Show("Contraseña cambiada");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ora.Close();
        }
    }
}
