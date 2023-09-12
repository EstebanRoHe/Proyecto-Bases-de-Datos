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
using System.Drawing.Imaging;

namespace ProyectoBases
{
    public partial class CrearTableSpace : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = 192.168.0.23/xe ; PASSWORD=1234; USER ID = SYSTEM;");
        OracleCommand query;
        OracleCommand queryTemp;

        string nombreLogicoTemp = "";
        string nombreFisicoTemp = "";

        public CrearTableSpace()
        {
            InitializeComponent();
            //ora.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombreLogico = logicName.Text;
            string nombreFisico = physicName.Text;
            string tam = tama.Text;
            string nombreUsuario = username.Text;
            string contra = identified.Text;

            string ruta = "'C:\\app\\user\\product\\21c\\oradata\\XE\\";

            try
            {
                ora.Open();
                //Sesion alterada  
                query = new OracleCommand("alter session set \"_oracle_script\" = true", ora);
                query.ExecuteNonQuery();

                //TABLESPACE

                query = new OracleCommand("CREATE TABLESPACE " + nombreLogico + " DATAFILE" + ruta + nombreFisico + ".DBF' SIZE "+tam+ " AUTOEXTEND ON", ora);
                //query = new OracleCommand("CREATE TABLESPACE \"" + nombreLogico + "\" DATAFILE '" + ruta +" "+ nombreFisico + ".DBF' SIZE "+ tam + " AUTOEXTEND ON NEXT 1M", ora);
                query.ExecuteNonQuery();

                query = new OracleCommand("CREATE TEMPORARY TABLESPACE " + nombreLogico + "Temp TEMPFILE " + ruta + nombreFisico + "_Temp.DBF' SIZE 5M AUTOEXTEND ON", ora);
                //query = new OracleCommand("CREATE TEMPORARY TABLESPACE \"" + nombreLogico + "\"Temp TEMPFILE '" + ruta + nombreFisico + "Temp.DBF' SIZE 5M AUTOEXTEND ON", ora);
                query.ExecuteNonQuery();


                //Crecion del Usuario 
                query = new OracleCommand("CREATE USER " + nombreUsuario + " IDENTIFIED BY " + contra + " DEFAULT TABLESPACE " + nombreLogico + " TEMPORARY TABLESPACE "+ nombreLogico +"Temp ", ora);
                query.ExecuteNonQuery();

                query = new OracleCommand("GRANT RESOURCE TO " + nombreUsuario, ora);
                query.ExecuteNonQuery();

                query = new OracleCommand("GRANT CONNECT TO " + nombreUsuario, ora);
                query.ExecuteNonQuery();

                query = new OracleCommand("GRANT ALL PRIVILEGES " + nombreUsuario, ora);
                query.ExecuteNonQuery();

                MessageBox.Show("¡Tablespace generado correctamente!");
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ora.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            string nombre = textNuevoNombre.Text;
            string tamano = textNuevoTamano.Text;

            try
            {
                ora.Open();
              
                query = new OracleCommand("alter session set \"_oracle_script\" = true", ora);
                query.ExecuteNonQuery();
                query = new OracleCommand("ALTER DATABASE DATAFILE "+"'"+"C:\\app\\user\\product\\21c\\oradata\\XE\\"+nombre+".DBF"+"'"+" resize "+tamano+ "M",ora);
             
                query.ExecuteNonQuery();
                MessageBox.Show("Se modifico el tamaño");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ora.Close();
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void CrearTableSpace_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
