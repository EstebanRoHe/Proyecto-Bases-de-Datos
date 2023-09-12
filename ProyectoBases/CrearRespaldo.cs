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
using System.Collections;


namespace ProyectoBases
{
    public partial class CrearRespaldo : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = 192.168.0.23/xe ; PASSWORD=1234; USER ID = SYSTEM;");
        
        OracleCommand query;
        public CrearRespaldo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sche = nomSchema.Text;
            string usuario = userSchema.Text;
            string pass = passUserSchema.Text;

            string ruta = "'C:\\Respaldos\\";

            ora.Open();

            try
            {
                query = new OracleCommand("alter session set \"_oracle_script\" = true", ora);
                query.ExecuteNonQuery();

                query = new OracleCommand("CREATE OR REPLACE DIRECTORY RESPALDO AS " + ruta + "'", ora);
                query.ExecuteNonQuery();
               
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";            
                    process.StartInfo.Arguments = "/C EXPDP SYSTEM/1234@XE SCHEMAS="+ usuario + " DIRECTORY=RESPALDO DUMPFILE="+ usuario + ".DMP LOGFILE="+ usuario + ".LOG;";
                    MessageBox.Show(process.StartInfo.Arguments);
                    process.Start();
                }
               
            }
            catch (Exception ew)
            {
                MessageBox.Show(ew.Message);
            }

            ora.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sche = nomSchema.Text;
            string usuario = userSchema.Text;
            string pass = passUserSchema.Text;

            string ruta = "'C:\\Respaldos\\";
            ora.Open();


            var cmd = new Process();
           
            try
            {

                query = new OracleCommand("alter session set \"_oracle_script\" = true", ora);
                query.ExecuteNonQuery();

                query = new OracleCommand("CREATE OR REPLACE DIRECTORY RESPALDO AS " + ruta + "'", ora);
                query.ExecuteNonQuery();


                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/C EXPDP SYSTEM/1234@XE FULL = Y DIRECTORY = RESPALDO DUMPFILE = RXE.DMP LOGFILE = RXE.LOG;";
                    process.Start();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

            ora.Close();

        }

       
            private void button2_Click(object sender, EventArgs e)
        {
            string sche = nomSchema.Text;
            string usuario = userSchema.Text;
            string pass = passUserSchema.Text;

            string ruta = "'C:\\Respaldos\\";

            ora.Open();

            try
            {
                query = new OracleCommand("alter session set \"_oracle_script\" = true", ora);
                query.ExecuteNonQuery();

                query = new OracleCommand("CREATE OR REPLACE DIRECTORY RESPALDO AS " + ruta + "'", ora);
                query.ExecuteNonQuery();
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/C EXPDP SYSTEM/1234@XE TABLES=" + sche +"."+pass+ " DIRECTORY=RESPALDO DUMPFILE=" + pass + ".DMP LOGFILE=" + pass + ".LOG;";
                    MessageBox.Show(process.StartInfo.Arguments);
                    process.Start();
                }

            }
            catch (Exception ew)
            {
                MessageBox.Show(ew.Message);
            }

            ora.Close();
        }

        private void CrearRespaldo_Load(object sender, EventArgs e)
        {

        }
    }

  

}
