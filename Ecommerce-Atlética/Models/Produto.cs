namespace Ecommerce_Atletica.Models
{
    public class Produto
{
        public int ID { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public string Categoria { get; set; }
        public bool Ativo { get; private set; }

        public Produto()
        {
            Ativo = true;
        }

        public void CadastrarProduto(string nome, string descricao, decimal preco, int quantidade, string categoria)
        {
            NomeProduto = nome;
            Descricao = descricao;
            PrecoUnitario = preco;
            Quantidade = quantidade;
            Categoria = categoria;
            Ativo = true;
            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        public void AlterarProduto(string nome, string descricao, decimal preco, int quantidade, string categoria)
        {
            if (!Ativo)
            {
                Console.WriteLine("Não é possível alterar um produto inativo.");
                return;
            }
            
            NomeProduto = nome;
            Descricao = descricao;
            PrecoUnitario = preco;
            Quantidade = quantidade;
            Categoria = categoria;
            Console.WriteLine("Produto alterado com sucesso!");
        }

        public void ExcluirProduto()
        {
            if (Quantidade > 0)
            {
                Console.WriteLine("Não é possível excluir um produto com estoque. Considere dar baixa no estoque antes de excluir.");
                return;
            }
            
            Ativo = false;
            Console.WriteLine("Produto excluído com segurança.");
        }

        public void DarBaixaProduto(int quantidadeBaixa)
        {
            if (quantidadeBaixa <= 0)
            {
                Console.WriteLine("A quantidade a dar baixa deve ser maior que zero.");
                return;
            }
            
            if (Quantidade >= quantidadeBaixa)
            {
                Quantidade -= quantidadeBaixa;
                Console.WriteLine($"Baixa de {quantidadeBaixa} unidades realizada com sucesso. Estoque atual: {Quantidade}");
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente no estoque.");
            }
        }
    }
}
