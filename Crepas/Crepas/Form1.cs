using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Crepas
{
    public partial class Inicio : Form
    {
        MySqlConnection conexion = new MySqlConnection();
        String Cadenaconexion;
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Cadenaconexion = "Server = 192.168.99.100; User id=root; Database=crepas; Password=123456789";
            conexion.ConnectionString = Cadenaconexion;
            MySqlCommand comandobus = new MySqlCommand("select Nombre from Productos ;");
            comandobus.Connection = conexion;
            conexion.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(comandobus);
            DataTable dt = new DataTable();
            da.Fill(dt);
            combo_productos.DisplayMember = "Nombre";
            combo_productos.DataSource = dt;
            conexion.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Cadenaconexion = "Server = 192.168.99.100; User id=root; Database=crepas; Password=123456789";
            conexion.ConnectionString = Cadenaconexion;
            MySqlCommand comandobus = new MySqlCommand("select Nombre from Productos ;");
            comandobus.Connection = conexion;
            conexion.Open();
            MySqlDataReader myreader = comandobus.ExecuteReader();
            try
            {
                if (myreader.HasRows)
                {
                    while (myreader.Read())
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error" + ex + "");
            }
            conexion.Close();
        }

        private void txt_cant_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valida.SoloNumeros(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valida.SoloLetras(e);
        }

        private void combo_tipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (combo_tipo.SelectedItem.ToString() == "Local")
            {
                txt_dic.ReadOnly = true;
            }
            else
            {
                txt_dic.ReadOnly = false;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }  
}
