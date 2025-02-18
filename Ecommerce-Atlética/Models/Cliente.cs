using System;
using Ecommerce_Atletica.Models;

namespace ECommerce
{
    public class Cliente : Pessoa
    {
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade => CalcularIdade(); 
        public bool Ativo { get; private set; } = true;
        public string Telefone { get; set; }
        public bool Associado { get; set; }

        public Cliente()
        {
            Ativo = true;
        }

        private int CalcularIdade()
        {
            int idade = DateTime.Now.Year - DataNascimento.Year;
            if (DateTime.Now < DataNascimento.AddYears(idade))
                idade--; 
            return idade;
        }

        public bool ValidarIdade()
        {
            return Idade >= 18;
        }

        public void CadastrarCliente(string nome, string usuario, string senha, string email, string cpf, string endereco, DateTime dataNascimento, string telefone, bool associado)
        {
            Nome = nome;
            Usuario = usuario;
            AlterarSenha(senha);
            AlterarEmail(email);
            CPF = cpf;
            Endereco = endereco;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Associado = associado;

            Console.WriteLine("Cliente cadastrado com sucesso!");
        }

        public void AlterarDadosCliente(string novoEndereco, string novoTelefone, bool novoAssociado)
        {
            Endereco = novoEndereco;
            Telefone = novoTelefone;
            Associado = novoAssociado;
            Console.WriteLine("Dados do cliente alterados com sucesso!");
        }

        public void ExcluirCliente()
        {
            Ativo = false;
            Console.WriteLine("Cliente marcado como inativo no banco de dados.");
        }
    }
}
