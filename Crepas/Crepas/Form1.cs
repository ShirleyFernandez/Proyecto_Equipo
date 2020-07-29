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
        //EL NOMBRE DEL FORM ES EL PRIMERO QUE SALE EN ESTE CASO "INICIO"
    public partial class Inicio : Form
    {
        int ventasCont = 1;
        int pedidosCont = 0;
        int total = 0;


        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
            try
            {

                //PRODUCTOS
                Producto producto = new Producto();
                Api apiprod = new Api();
                Curl curlprod = new Curl
                {
                    url = "http://192.168.99.100/esp32-api/public/api/Productos",
                    verbo = Method.GET,
                    json = producto
                };
                
                string pruebaprod = apiprod.apiDes(curlprod);
                Producto [] productos = System.Text.Json.JsonSerializer.Deserialize<Producto[]>(pruebaprod);
                //api.apiDes(curl);
                //MessageBox.Show(productos[2].Nombre+productos[2].Precio);
                // MessageBox.Show(producto.Nombre);

                DataTable dtprod = new DataTable();
                dtprod.Columns.Add("idProductos");
                dtprod.Columns.Add("Nombre");
                dtprod.Columns.Add("Precio");
                dtprod.Columns.Add("categoria");
                for (int i = 0; i < productos.Length; i++)
                {
                    DataRow dRowprod = dtprod.NewRow();
                    dRowprod["idProductos"] = productos[i].idProductos.ToString();
                    dRowprod["Nombre"] = productos[i].Nombre;
                    dRowprod["Precio"] = productos[i].Precio.ToString();
                    dRowprod["categoria"] = productos[i].categoria;
                    dtprod.Rows.Add(dRowprod);
                }

                combo_productos.ValueMember = "idProductos";
                combo_productos.DisplayMember = "Nombre";
                combo_productos.DataSource = dtprod;
                
                //CLIENTES

                Cliente cliente = new Cliente();
                Api apiCli = new Api();
                Curl curlCli = new Curl()
                {
                    url = "http://192.168.99.100/esp32-api/public/api/Clientes",
                    verbo = Method.GET,
                    json = cliente
                };

                string cliTemp = apiCli.apiDes(curlCli);
                Cliente [] clientes = System.Text.Json.JsonSerializer.Deserialize<Cliente[]>(cliTemp);

                DataTable dtCli = new DataTable();
                dtCli.Columns.Add("idClientes");
                dtCli.Columns.Add("Nombre");
                dtCli.Columns.Add("Direccion");
                for(int i = 0; i < clientes.Length; i++)
                {
                    DataRow dataRowCli = dtCli.NewRow();
                    dataRowCli["idClientes"] = clientes[i].idClientes.ToString();
                    dataRowCli["Nombre"] = clientes[i].Nombre;
                    dataRowCli["Direccion"] = clientes[i].Direccion;
                    dtCli.Rows.Add(dataRowCli);
                }

                combo_Cliente.ValueMember = "idClientes";
                combo_Cliente.DisplayMember = "Nombre";
                combo_Cliente.DataSource = dtCli;

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
                for(int i = 0; i <= pedidos.Length; i++)
                {
                    pedidosCont = i;
                }

                //Ventas

                Venta venta = new Venta();
                Api apiven = new Api();
                Curl curlven = new Curl()
                {
                    url = "http://192.168.99.100/esp32-api/public/api/Ventas",
                    verbo = Method.GET,
                    json = venta
                };

                string venTemp = apiven.apiDes(curlven);
                Venta [] ventas = System.Text.Json.JsonSerializer.Deserialize<Venta[]>(venTemp);
                for (int i = 0; i == ventas.Length; i++)
                {
                    ventasCont = i;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ventasCont++;
            checkedListBox1.Items.Clear();
        }

        private void txt_cant_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valida.SoloNumeros(e);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido = new Pedido();
                Api api = new Api();
                Curl curl = new Curl();

                //Insertar pedido a la bd
                int idPedidos = pedidosCont;
                string c = txt_cant.Text;
                int Cantidad = Convert.ToInt32(c);
                string Tipo_Pedido = combo_tipo.SelectedItem.ToString();
                string Estado_Pedido = "PREPARACIÓN";
                string p = combo_productos.SelectedValue.ToString();
                int FK_idProd = Convert.ToInt32(p);
                string cl = combo_Cliente.SelectedValue.ToString();
                int FK_idCli = Convert.ToInt32(cl);

                pedido.idPedidos = idPedidos;
                pedido.Cantidad = Cantidad;
                pedido.Tipo_Pedido = Tipo_Pedido;
                pedido.Estado_Pedido = Estado_Pedido;
                pedido.FK_idProd = FK_idProd;
                pedido.FK_idCli = FK_idCli;


                curl.verbo = Method.POST;
                curl.json = pedido;
                api.apicall(curl);
                
                //Agregar producto a la lista
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

                int clb = 0;
                string orden = productos[FK_idProd - 1].Nombre;
                int costo = +(productos[FK_idProd - 1].Precio * Cantidad);
                checkedListBox1.Items.Insert(clb,idPedidos+" | "+(FK_idProd)+" | "+orden+" x "+Cantidad+" = "+costo );
                clb++;
                total = total + costo;
                lbl_total.Text = total.ToString();

                pedidosCont++;

                //Agregar venta
                
                Venta venta = new Venta();
                Api apiven = new Api();
                Curl curlvent = new Curl();

                DateTime dateTime = DateTime.UtcNow.Date;
                string fecha = dateTime.ToString("yyyy-MM-dd");

                venta.id_Ventas = ventasCont;
                venta.FechaV = fecha;
                venta.FK_idPedidos = idPedidos;
                venta.FK_idProd = FK_idProd;
                venta.FK_idCli = FK_idCli;

                curlvent.verbo = Method.POST;
                curlvent.json = venta;
                curlvent.url = "http://192.168.99.100/esp32-api/public/api/Ventas";
                apiven.apicall(curlvent);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: "+ ex);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //BOTON QUE ABRE LA VENTANA "PEDIDOS"
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 nForm2 = new Form2();
            nForm2.TopLevel = true;
            nForm2.Show();
            this.Hide();
        }

        //BOTÓN QUE ABRE LA VENTANA CLIENTES
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 nForm4 = new Form4();
            nForm4.TopLevel = true;
            nForm4.Show();
            this.Hide();
        }

        //BOTÓN QUE ABRE LA VENTANA CUENTAS
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 nForm3 = new Form3();
            nForm3.TopLevel = true;
            nForm3.Show();
            this.Hide();
        }
        //BOTÓN CIERRA LA VENTANA "SALIR"
        private void button5_Click(object sender, EventArgs e)
        {
            //Application.ExitThread();
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            String substring = null;
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                string texto = itemChecked.ToString();
                int startIndex = 0;
                int length = 2;
                substring = texto.Substring(startIndex, length);
                //MessageBox.Show(substring);
            }
            //Restar total
            Pedido pedidototal = new Pedido();
            Api apiped = new Api();
            Curl curlped = new Curl()
            {
                verbo = Method.GET,
                json = pedidototal,
                url = "http://192.168.99.100/esp32-api/public/api/Pedidos"
            };

            string pruebaped = apiped.apiDes(curlped);
            Pedido[] pedidos = System.Text.Json.JsonSerializer.Deserialize<Pedido[]>(pruebaped);

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

            for(int i = 0; i < pedidos.Length; i++)
            {
                int s1, s2;
                if(pedidos[i].idPedidos == Convert.ToInt32(substring))
                {
                    s1 = productos[pedidos[i].FK_idProd - 1].Precio;
                    s2 = pedidos[i].Cantidad;

                    total -= (s1 * s2);
                    lbl_total.Text = total.ToString();
                }
            }

            Venta venta = new Venta();
            Api apiven = new Api();
            Curl curlvent = new Curl();

            venta.FK_idPedidos = Convert.ToInt32(substring);

            curlvent.verbo = Method.DELETE;
            curlvent.json = venta;
            curlvent.url = "http://192.168.99.100/esp32-api/public/api/Ventas";
            apiven.apicall(curlvent);

            Pedido pedido = new Pedido();
            Api api = new Api();
            Curl curl = new Curl();

            pedido.idPedidos = Convert.ToInt32(substring);


            curl.verbo = Method.DELETE;
            curl.json = pedido;
            api.apicall(curl);

            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);

        }
    }  
}
