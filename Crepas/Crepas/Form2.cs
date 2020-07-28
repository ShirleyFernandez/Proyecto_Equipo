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
using RestSharp.Serialization.Json;

namespace Crepas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //ELEMENTOS DEL MENUSTRIP, enlazado los otros forms en el para poderlos visualizar

        //MenuStrip esta es la opcion de INICIO
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio nForm1 = new Inicio();
            nForm1.TopLevel = true;
            nForm1.Show();
            this.Hide();
        }
        //MenuStrip esta es la opcion de CUENTAS
        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 nForm3 = new Form3();
            nForm3.TopLevel = true;
            nForm3.Show();
            this.Hide();
        }

        //MenuStrip esta es la opcion de PEDIDOS COCINA
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

        //Este no cuenta xd
        private void Form2_Load(object sender, EventArgs e)
        {
            int index = 0;

            //Producto
            Producto producto = new Producto();
            Api apiprod = new Api();
            Curl curlprod = new Curl
            {
                url = "http://192.168.99.100/esp32-api/public/api/Productos",
                verbo = Method.GET,
                json = producto
            };

            string pruebaprod = apiprod.apiDes(curlprod);
            Producto[] productos = System.Text.Json.JsonSerializer.Deserialize<Producto[]>(pruebaprod);

            //Pedidos
            Pedido pedido = new Pedido();
            Api apiped = new Api();
            Curl curlped = new Curl()
            {
                url = "http://192.168.99.100/esp32-api/public/api/Pedidos",
                verbo = Method.GET,
                json = pedido
            };


            string pedTemp = apiped.apiDes(curlped);
            Pedido[] pedidos = System.Text.Json.JsonSerializer.Deserialize<Pedido[]>(pedTemp);
            for (int i = 0; i < pedidos.Length; i++)
            {
                if(pedidos[i].Estado_Pedido == "PREPARACIÓN")
                {
                    checkedListBox1.Items.Insert(index,pedidos[i].idPedidos +" | "+productos[pedidos[i].FK_idProd-1].Nombre +" | "+pedidos[i].Estado_Pedido);
                    index++;
                }
            }

        }
        //MUENU STRIP esta opción del botón secundario Opciones--->agregarcliente
        private void registroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 nForm4 = new Form4();
            nForm4.TopLevel = true;
            nForm4.Show();
            this.Hide();
        }

        private void btn_terminar_Click(object sender, EventArgs e)
        {
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                string texto = itemChecked.ToString();
                int startIndex = 0;
                int length = 2;
                String substring = texto.Substring(startIndex, length);
                //MessageBox.Show(substring);

                Pedido pedido = new Pedido();
                Api api = new Api();
                Curl curl = new Curl();

                pedido.idPedidos = Convert.ToInt32(substring);
                pedido.Estado_Pedido = "LISTO";


                curl.verbo = Method.PATCH;
                curl.json = pedido;
                api.apicall(curl);
            }

            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
        }
    }
}
