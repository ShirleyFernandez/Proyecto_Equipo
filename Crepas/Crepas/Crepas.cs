using System;
using System.IO;
using System.Net;
using RestSharp;
using System.Text.Json;

namespace Crepas
{
    class Api
    {
        public string apicall(Curl datos)
        {
            var cliente = new RestClient(datos.url);
            var request = new RestRequest(datos.verbo);
            request.AddHeader("Content-Type", "Application/Json");
            string json = JsonSerializer.Serialize(datos.json);
            request.AddJsonBody(json);
            //Console.WriteLine(json);
            IRestResponse response = cliente.Execute(request);
            return response.Content;
        }

        public string apiDes(Curl datos)
        {
            var cliente = new RestClient(datos.url);
            var request = new RestRequest(datos.verbo);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "Application/Json"; };
            var queryResult = cliente.Execute(request);
            //datos.json = queryResult.Request;
            return queryResult.Content;
        }
    }

    class Pedido
    {
        public int idPedidos { set; get; }

        public int Cantidad { set; get; }

        public string Tipo_Pedido { set; get; }

        public string Estado_Pedido { set; get; }

        public int FK_idProd { set; get; }

        public int FK_idCli { set; get; }

    }

    class Producto
    {
        public int idProductos { set; get; }

        public string Nombre { set; get; }

        public int Precio { set; get; }

        public string categoria { set; get; }
    }

    class Cliente
    {
        public int idClientes { set; get; }

        public string Nombre { set; get; }

        public string Direccion { set; get; }
    }

    class Venta
    {
        public int id_Ventas { set; get; }

        public string FechaV { set; get; }

        public int FK_idPedidos { set; get; }

        public int FK_idProd { set; get; }

        public int FK_idCli { set; get; }
    }

    class Fecha
    {
        public string FechaV { set; get; }
    }

    class Caja
    {
        public int id_Ventas { set; get; }

        public string Nombre { set; get; }

        public int FK_idPedidos { set; get; }

        public int Precio { set; get; }

        public int Cantidad { set; get; }

        public string FechaV { set; get; }
    }

    class Ultimop
    {
        public int id_Ventas { set; get; }

        public int idPedidos { set; get; }
    }
    class Curl
    {
        public string url { set; get; }

        public Method verbo { set; get; }

        public object json { set; get; }

        public Curl()
        {
            this.url = "http://192.168.99.100/esp32-api/public/api/Pedidos";
        }
    }

}
