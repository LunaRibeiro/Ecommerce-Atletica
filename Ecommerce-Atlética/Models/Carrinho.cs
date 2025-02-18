using System.Collections.Generic;

namespace Ecommerce_Atletica.Models
{
    public class Carrinho
    {
        public int ID { get; set; }
        public int IDCliente { get; set; }
        public List<Produto> ListaProdutos { get; set; } = new List<Produto>();
        public Dictionary<int, int> QuantidadePorProduto { get; set; } = new Dictionary<int, int>();
        public decimal ValorTotalCarrinho { get; private set; }

        public void CadastrarListaProdutos(Produto produto, int quantidade)
        {
            if (ListaProdutos.Contains(produto))
            {
                QuantidadePorProduto[produto.ID] += quantidade;
            }
            else
            {
                ListaProdutos.Add(produto);
                QuantidadePorProduto[produto.ID] = quantidade;
            }
            AtualizarValorTotal();
            Console.WriteLine("Produto adicionado ao carrinho com sucesso!");
        }

        public void AlterarListaProdutos(int produtoID, int novaQuantidade)
        {
            if (QuantidadePorProduto.ContainsKey(produtoID))
            {
                QuantidadePorProduto[produtoID] = novaQuantidade;
                AtualizarValorTotal();
                Console.WriteLine("Quantidade do produto alterada com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado no carrinho.");
            }
        }

        public void SalvarListaCarrinho()
        {
            Console.WriteLine("Carrinho salvo no banco de dados e carregado com a troca de usuário.");
        }

        private void AtualizarValorTotal()
        {
            ValorTotalCarrinho = 0;
            foreach (var produto in ListaProdutos)
            {
                if (QuantidadePorProduto.ContainsKey(produto.ID))
                {
                    ValorTotalCarrinho += produto.PrecoUnitario * QuantidadePorProduto[produto.ID];
                }
            }
        }
    }
}
