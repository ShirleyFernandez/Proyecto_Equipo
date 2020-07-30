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
            Fecha fecha = new Fecha();
            Api apifech = new Api();
            Curl curlfech = new Curl()
            {
                url = "http://192.168.99.100/esp32-api/public/api/Fechas",
                verbo = Method.GET,
                json = fecha
            };

            string fechTemp = apifech.apiDes(curlfech);
            Fecha[] fechas = System.Text.Json.JsonSerializer.Deserialize<Fecha[]>(fechTemp);

            DataTable dtfecha = new DataTable();
            dtfecha.Columns.Add("FechaV");

            for (int i = 0; i < fechas.Length; i++)
            {
                DataRow dataRowVent = dtfecha.NewRow();
                dataRowVent["FechaV"] = fechas[i].FechaV;
                dtfecha.Rows.Add(dataRowVent);
            }

            comboBox1.ValueMember = "FechaV";
            comboBox1.DisplayMember = "FechaV";
            comboBox1.DataSource = dtfecha;
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            int ganancia = 0;
            string fecha = comboBox1.Text;

            Caja caja = new Caja();
            caja.FechaV = fecha;
            Api apicaj = new Api();
            Curl curlcaj = new Curl()
            {
                url = "http://192.168.99.100/esp32-api/public/api/Cajas",
                verbo = Method.GET,
                json = caja.FechaV
            };

            string cajTemp = apicaj.apiDes(curlcaj);
            //Caja[] Cajas = System.Text.Json.JsonSerializer.Deserialize<Caja[]>(cajTemp);

            MessageBox.Show(caja.FechaV);
/*
            DataTable dtcaja = new DataTable();
            dtcaja.Columns.Add("id_Ventas");
            dtcaja.Columns.Add("Nombre");
            dtcaja.Columns.Add("FK_idPedidos");
            dtcaja.Columns.Add("Precio");
            dtcaja.Columns.Add("Cantidad");
            dtcaja.Columns.Add("FechaV");
            dtcaja.Columns.Add("Total");

            for (int i = 0; i < Cajas.Length; i++)
            {
                
                DataRow dataRowVent = dtcaja.NewRow();
                dataRowVent["id_Ventas"] = Cajas[i].id_Ventas;
                dataRowVent["Nombre"] = Cajas[i].Nombre;
                dataRowVent["FK_idPedidos"] = Cajas[i].FK_idPedidos;
                dataRowVent["Precio"] = Cajas[i].Precio;
                dataRowVent["Cantidad"] = Cajas[i].Cantidad;
                dataRowVent["FechaV"] = Cajas[i].FechaV;
                dataRowVent["Total"] = (Cajas[i].Precio + Cajas[i].Cantidad);
                dtcaja.Rows.Add(dataRowVent);
            }

            listBox1.ValueMember = "id_Ventas";
            listBox1.DisplayMember = "id_Ventas";
            listBox1.DataSource = dtcaja;
         */
        }
    }
}
