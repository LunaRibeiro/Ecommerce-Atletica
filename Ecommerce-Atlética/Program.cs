using System;
using ECommerce;

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente();
        cliente.CadastrarCliente(
            "João Silva", "joaosilva", "senha123", "joao@email.com",
            "123.456.789-00", "Rua das Flores, 123", new DateTime(1995, 5, 10),
            "11987654321", true
        );

        Console.WriteLine($"Nome: {cliente.Nome}");
        Console.WriteLine($"Idade: {cliente.Idade}");
        Console.WriteLine($"Ativo: {cliente.Ativo}");

        cliente.AlterarDadosCliente("Av. Paulista, 456", "11999998888", false);
        cliente.ExcluirCliente();
    }
}
