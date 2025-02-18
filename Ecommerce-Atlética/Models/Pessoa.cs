namespace Ecommerce_Atletica.Models
{
    public class Pessoa
{
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        private string Senha { get; set; }
        public string Email { get; set; }

        public void AlterarSenha(string novaSenha)
        {
            if (!string.IsNullOrWhiteSpace(novaSenha) && novaSenha.Length >= 6)
            {
                Senha = novaSenha;
                Console.WriteLine("Senha alterada com sucesso!");
            }
            else
            {
                Console.WriteLine("Senha inválida! A senha deve ter pelo menos 6 caracteres.");
            }
        }

        public void AlterarEmail(string novoEmail)
        {
            if (novoEmail.Contains("@") && novoEmail.Contains("."))
            {
                Email = novoEmail;
                Console.WriteLine("E-mail alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("E-mail inválido!");
            }
        }
    }
}