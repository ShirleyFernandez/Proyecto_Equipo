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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Direccion_Click(object sender, EventArgs e)
        {

        }
        //MUENU STRIP esta opción del botón secundario Opciones--->agregarcliente
        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 nForm4 = new Form4();
            nForm4.TopLevel = true;
            nForm4.Show();
            this.Hide();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Api apiCli = new Api();
            Curl curlCli = new Curl();

            string Nombre = txt_cliente.Text;
            string Direccion = txt_dic.Text;

            cliente.Nombre = Nombre;
            cliente.Direccion = Direccion;

            curlCli.verbo = Method.POST;
            curlCli.json = cliente;
            curlCli.url = "http://192.168.99.100/esp32-api/public/api/Clientes";
            apiCli.apicall(curlCli);

            txt_cliente.Clear();
            txt_dic.Clear();
        }
    }
}
