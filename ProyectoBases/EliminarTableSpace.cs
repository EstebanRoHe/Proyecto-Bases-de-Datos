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
    public partial class EliminarTableSpace : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = 192.168.0.23/xe ; PASSWORD=1234; USER ID = SYSTEM;");
        bool con = false;
        OracleCommand query;
        public EliminarTableSpace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string schem = schema.Text;
            ora.Open();
            try
            {
                query = new OracleCommand("DROP TABLESPACE " + schem + " INCLUDING CONTENTS AND DATAFILES", ora);
                
                query.ExecuteNonQuery();

                MessageBox.Show("¡Tablespace eliminado correctamente!");
                this.Close();
            }
            catch (Exception ex)
            {
                ora.Close();
                MessageBox.Show(ex.Message);
            }
            ora.Close();
        }
    }
}
