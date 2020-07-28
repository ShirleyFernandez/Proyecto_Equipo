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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //ELEMENTOS DEL MENUSTRIP, enlazado los otros forms en el para poderlos visualizar
        //MenuStrip esta es la opcion INICIO
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

        //MenuStrip esta es la opcion de PEIDDOS COCINA
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
        //MUENU STRIP esta opción del botón secundario Opciones--->agregarcliente
        private void registroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 nForm4 = new Form4();
            nForm4.TopLevel = true;
            nForm4.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            Api apiven = new Api();
            Curl curlven = new Curl()
            {
                url = "http://192.168.99.100/esp32-api/public/api/Ventas",
                verbo = Method.GET,
                json = venta
            };

            string venTemp = apiven.apiDes(curlven);
            Venta[] ventas = System.Text.Json.JsonSerializer.Deserialize<Venta[]>(venTemp);

            DataTable dtvent = new DataTable();
            dtvent.Columns.Add("FechaV");

            for (int i = 0; i < ventas.Length; i++)
            {
                for (int j = 0; j < ventas.Length; j++) {
                    if (i != j)
                    {
                        if (ventas[i].FechaV == ventas[j].FechaV)
                        {
                            ventas[i].FechaV = "";
                        }
                    }
                }
            }

            for(int k = 0; k < ventas.Length; k++)
            {
                if (ventas[k].FechaV != "")
                {
                    DataRow dataRowVent = dtvent.NewRow();
                    dataRowVent["FechaV"] = ventas[k].FechaV;
                    dtvent.Rows.Add(dataRowVent);
                }
            }

            comboBox1.ValueMember = "FechaV";
            comboBox1.DisplayMember = "FechaV";
            comboBox1.DataSource = dtvent;
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            int ganancia = 0;
            string fecha = comboBox1.Text;
            
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

            //Pedido
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

            //Venta
            Venta venta = new Venta();
            Api apiven = new Api();
            Curl curlven = new Curl()
            {
                url = "http://192.168.99.100/esp32-api/public/api/Ventas",
                verbo = Method.GET,
                json = venta
            };
            int index = 0;
            string venTemp = apiven.apiDes(curlven);
            Venta[] ventas = System.Text.Json.JsonSerializer.Deserialize<Venta[]>(venTemp);
            for (int i = 0; i < ventas.Length; i++)
            {
                if (ventas[i].FechaV == fecha)
                {
                    
                    int cant = pedidos[ventas[i].FK_idPedidos-1].Cantidad;
                    int precio = productos[ventas[i].FK_idProd].Precio;
                    int total = cant * precio;
                    listBox1.Items.Insert(index, ventas[i].id_Ventas + " | " + productos[ventas[i].FK_idProd].Nombre + " | " + cant + " | " + total);
                    index++;
                    ganancia = ganancia + total;
                    
                    
                }
            }

            lbl_gan.Text = ganancia.ToString();
        }
    }
}
