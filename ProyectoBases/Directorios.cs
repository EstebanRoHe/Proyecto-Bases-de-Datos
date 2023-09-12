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
    public partial class Directorios : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = 192.168.0.23/xe ; PASSWORD=1234; USER ID = SYSTEM;");
        bool con = false;
        public Directorios()
        {
            InitializeComponent();
        }

        private void Directorios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                    OracleCommand query = new OracleCommand("SELECT * FROM ALL_DIRECTORIES", ora);
                    query.ExecuteNonQuery();

                    OracleDataAdapter adaptador = new OracleDataAdapter();

                    adaptador.SelectCommand = query;

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    DBA_USERS.DataSource = tabla;

                    ora.Close();
                    MessageBox.Show("Datos Cargados Exitosamente");
            }
            catch (Exception exe)
            {
                ora.Close();
                MessageBox.Show(exe.Message);
            }
            ora.Close();
        }
    }
}
