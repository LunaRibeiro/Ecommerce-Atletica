using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using Ecommerce_Atletica.Models;

namespace Ecommerce_Atlética.model
{
    public class Pedido
    {
        public int ID { get; set; }
        public int IdCliente { get; set; }
        public string DataPedido { get; set; } = string.Empty;
        public double ValorTotal { get; set; }
        public string StatusPedido { get; set; } = "";
        public string[] ListaCarrinho { get; set; } = new string[0];


        //Métodos

        //Implemetanação com TRUE de ConfirmarPagamento de Classe FormaPagamento
        public static void FazerPedido()
        {

            Console.WriteLine("Pedido feito");

        }

        public bool darBaixaProduto(Produto produtoPedido)
        {
            //Conexão com produto para classe produto tirar quantidade do produtoPedido no banco sendo a quantidade de produtoPedido

            return true;
        }

        public void GerarStatusPedido()
        {
            Console.WriteLine("Pedido confirmad");

            Task.Delay(10 * 1000).Wait();

            Console.WriteLine("Separando pedido");

            Task.Delay(10 * 1000).Wait();

            Console.WriteLine("Pedido a caminho");

            Task.Delay(10 * 1000).Wait();

            Console.WriteLine("Pedido entregue");
        }


    }
}