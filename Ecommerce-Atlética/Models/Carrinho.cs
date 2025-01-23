using System.Collections.Generic;

namespace Ecommerce_Atletica.Models
{
    public class Carrinho
    {
        public int Id { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();
        public decimal Total => CalcularTotal();

        private decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var produto in Produtos)
            {
                total += produto.Preco;
            }
            return total;
        }
    }
}
