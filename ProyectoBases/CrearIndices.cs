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
    public partial class CrearIndices : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = 192.168.0.23/xe ; PASSWORD=1234; USER ID = SYSTEM;");
        OracleCommand query;

        public CrearIndices()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomIndice = nombreIndice.Text;
            string nomTabla = Tabla.Text;
            string col = Columnas.Text;

            
            ora.Open();
            try
            {
                query = new OracleCommand("CREATE INDEX " + nomIndice + " ON " + nomTabla + "(" + col + ")", ora);
                query.ExecuteNonQuery();
                MessageBox.Show("Indice creado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ora.Close();
        }
    }
}
