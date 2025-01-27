using Ecommerce_Atletica.Models;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa { Id = 1, Nome = "João", Email = "joao@email.com" };

        Categoria categoria = new Categoria { Id = 1, Nome = "Eletrônicos" };

        Produto produto1 = new Produto { Id = 1, Nome = "Celular", Preco = 1500.00m, CategoriaId = 1 };
        Produto produto2 = new Produto { Id = 2, Nome = "Notebook", Preco = 4500.00m, CategoriaId = 1 };

        Carrinho carrinho = new Carrinho();
        carrinho.Produtos.Add(produto1);
        carrinho.Produtos.Add(produto2);

        Console.WriteLine($"Cliente: {pessoa.Nome} - Email: {pessoa.Email}");
        Console.WriteLine($"Produtos no carrinho: {carrinho.Produtos.Count}");
        Console.WriteLine($"Total: R$ {carrinho.Total}");
    }
}
