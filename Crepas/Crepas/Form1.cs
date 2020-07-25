using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Tls;
using RestSharp;

namespace Crepas
{
        //EL NOMBRE DEL FORM ES EL PRIMERO QUE SALE EN ESTE CASO "INICIO"
    public partial class Inicio : Form
    {
        int contList = 0;
     
        
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            contList++;
            txt_cant.Clear();
            txt_cliente.Clear();
            txt_dic.Clear();
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
        //MUENU STRIP esta opción del botón secundario Opciones--->agregarcliente
        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 nForm4 = new Form4();
            nForm4.TopLevel = true;
            nForm4.Show();
            this.Hide();
        }

        //ESTA OPCION NOS DEJA SALIR DE LA APP Completamete y detiene la ejecución
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {

                int id_Ventas, FK_idProd, idPedidos, Cantidad, FK_idCli;
                id_Ventas = contList;
                FK_idProd = Convert.ToInt32(combo_productos.Text);
                string FechaV, Tipo_Pedido, Nombre, Direccion = " ", Estado_Pedido;
                FechaV = DateTime.Today.ToString("yyyy-MM-dd");
                Tipo_Pedido = combo_tipo.Text;
                Nombre = txt_cliente.Text;
                Direccion = txt_dic.Text;
                Estado_Pedido = "En proceso";
                Cantidad = Convert.ToInt32(txt_cant.Text);
                idPedidos = Convert.ToInt32(combo_productos.Text);

                Pedido pedido = new Pedido();
                Api api = new Api();
                Curl curl = new Curl();

                pedido.id_Ventas = id_Ventas;
                pedido.FechaV = FechaV;
                pedido.Tipo_Pedido = Tipo_Pedido;
                pedido.FK_idProd = FK_idProd;
                pedido.Nombre = Nombre;
                pedido.Direccion = Direccion;
                pedido.Estado_Pedido = Estado_Pedido;
                pedido.idPedidos = idPedidos;
                pedido.Cantidad = Cantidad;

                curl.verbo = Method.POST;
                curl.json = pedido;
                api.apicall(curl);

                this.Close();
              
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     
    }  
}
