using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OracleClient;



namespace ProyectoBases
{
    
    public partial class Form1 : Form
    { 
        bool con = false;
        string usuario = "";
        string pass = "";
        OracleConnection ora;
        OracleCommand query;
        public Form1()
        {
 
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (con)
            {
                CrearUsuario c = new CrearUsuario();
                c.Show();
            }
            else
            {
                MessageBox.Show("La conexión esta cerrada");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (con)
            {
                EliminarTableSpace ets = new EliminarTableSpace();
                ets.Show();
            }
            else
            {
                MessageBox.Show("La conexión esta cerrada");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (con)
            {
                EliminarUsuario eu = new EliminarUsuario();
                eu.Show();
            }
            else
            {
                MessageBox.Show("La conexión esta cerrada");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (con)
            {
                CambiarContraseña cc = new CambiarContraseña();
                cc.Show();
            }
            else
            {
                MessageBox.Show("La conexión esta cerrada");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            usuario = textUsuario.Text;
            pass = textContraseña.Text;
           
               
            
            if (!con)
            {
                try
                {
                    ora = new OracleConnection("DATA SOURCE = 192.168.0.23/xe ; PASSWORD=" + pass + "; USER ID =" + usuario + ";");
                    ora.Open();
                    MessageBox.Show("Conexión Exitosa");

                    con = true;
                }
                catch (Exception ew)
                {
                    MessageBox.Show(ew.Message);
                }
            }
            else
            {
                MessageBox.Show("Error Conexión Ya Iniciada");
            }
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!con)
            {
                    try
                    {    
                        query = new OracleCommand("Audit connect;", ora);
                        query.ExecuteNonQuery();
                        query = new OracleCommand("audit session;", ora);
                        query.ExecuteNonQuery();
                        query = new OracleCommand("audit session whenever not successful;", ora);
                        query.ExecuteNonQuery();
                        query = new OracleCommand("audit session whenever successful;", ora);
                        query.ExecuteNonQuery();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    con = true;
            }
            else
            {
                MessageBox.Show("Error ");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (con)
            {
                CrearTableSpace cts = new CrearTableSpace();
                cts.Show();
            }
            else
            {
                MessageBox.Show("La conexión esta cerrada");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (con)
                {
                    OracleCommand query = new OracleCommand("select * from dba_users", ora);
                    query.ExecuteNonQuery();

                    OracleDataAdapter adaptador = new OracleDataAdapter();

                    adaptador.SelectCommand = query;

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    DBA_USERS.DataSource = tabla;

                    //ora.Close();
                    MessageBox.Show("Datos Cargados Exitosamente");
                }
                else
                {
                    MessageBox.Show("La conexión esta cerrada");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ora.Close();
            MessageBox.Show("Desconexión Exitosa Exitosa");
            con = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (con)
            {
                Directorios direc = new Directorios();
                direc.Show();
            }
            else
            {
                MessageBox.Show("La conexión esta cerrada");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (con)
            {
                CrearRespaldo siuu = new CrearRespaldo();
                siuu.Show();
            }
            else
            {
                MessageBox.Show("La conexión esta cerrada");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (con)
            {
                CrearRole siuu = new CrearRole();
                siuu.Show();
            }
            else
            {
                MessageBox.Show("La conexión esta cerrada");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (con)
            {
                CrearIndices siuu = new CrearIndices();
                siuu.Show();
            }
            else
            {
                MessageBox.Show("La conexión esta cerrada");
            }
        }
    }
}
