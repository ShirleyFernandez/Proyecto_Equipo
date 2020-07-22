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
using Org.BouncyCastle.Crypto.Tls;

namespace Crepas
{
        //EL NOMBRE DEL FORM ES EL PRIMERO QUE SALE EN ESTE CASO "INICIO"
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

        private void Pedidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        //ELEMENTOS DEL MENUSTRIP, enlazado los otros forms en el para poderlos visualizar
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio nForm1 = new Inicio();
            nForm1.TopLevel = true;
            nForm1.Show();
            this.Hide();
        }

        //MENUSTRIP Esta es la opción de CUENTAS
        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 nForm3 = new Form3();
            nForm3.TopLevel = true;
            nForm3.Show();
            this.Hide();
            
        }
        //MENUSTRIP Esta es la opción del "botón" PedidosCocina
        private void pedidosCocinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 nForm2 = new Form2();
            nForm2.TopLevel = true;
            nForm2.Show();
            this.Hide();
        }

        //ESTA OPCION NOS DEJA SALIR DE LA APP Completamete y detiene la ejecución
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }  
}
