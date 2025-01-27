using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_Atlética.model
{
    public class Pedido
    {
        public int ID { get; set; }
        public int IdCliente { get; set; }
        public string DataPedido { get; set; } = string.Empty;
        public double ValorTotal { get; set; }
        public string StatusPedido  { get; set; } = "";
        public string[] ListaCarrinho { get; set; } = new string[0];

        

    }
}