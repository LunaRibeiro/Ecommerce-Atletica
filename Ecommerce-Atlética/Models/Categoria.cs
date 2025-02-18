namespace Ecommerce_Atletica.Models
{
    public class Categoria
{
        public int ID { get; set; }
        public string TipoProduto { get; set; }
        public bool Roupas { get; set; }
        public bool Acessórios { get; set; }
        public bool Associação { get; set; }
        public bool Eventos { get; set; }

        public void CadastrarCategoria(string tipoProduto, bool roupas, bool acessorios, bool associacao, bool eventos)
        {
            TipoProduto = tipoProduto;
            Roupas = roupas;
            Acessórios = acessorios;
            Associação = associacao;
            Eventos = eventos;
            Console.WriteLine("Categoria cadastrada com sucesso!");
        }

        public void AlterarCategoria(string tipoProduto, bool roupas, bool acessorios, bool associacao, bool eventos)
        {
            TipoProduto = tipoProduto;
            Roupas = roupas;
            Acessórios = acessorios;
            Associação = associacao;
            Eventos = eventos;
            Console.WriteLine("Categoria alterada com sucesso!");
        }

        public void ExcluirCategoria()
        {
            Console.WriteLine("Categoria excluída com segurança.");
        }
    }
}