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



namespace ProyectoBases
{
    public partial class CrearRole : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = 192.168.0.23/xe ; PASSWORD=1234; USER ID = SYSTEM;");
        OracleCommand query;

        public CrearRole()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rol = nombreRol.Text;
           
            string asig = asignarA.Text;
            ora.Open();
            try
            {
                query = new OracleCommand("alter session set \"_oracle_script\" = true", ora);
                query.ExecuteNonQuery();

                query = new OracleCommand("CREATE ROLE " + rol + " NOT IDENTIFIED", ora);
                query.ExecuteNonQuery();

                query = new OracleCommand("GRANT " + rol + " TO " + asig, ora);
                query.ExecuteNonQuery();

                MessageBox.Show("Rol " + rol + " Creado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ora.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string user = textUsuario1.Text;

            ora.Open();
            try
            {
                query = new OracleCommand("alter session set \"_oracle_script\" = true", ora);
                query.ExecuteNonQuery();
               
                query = new OracleCommand("REVOKE ALL PRIVILEGES FROM "+user+";", ora);
                
                query.ExecuteNonQuery();
                MessageBox.Show("Role Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ora.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
