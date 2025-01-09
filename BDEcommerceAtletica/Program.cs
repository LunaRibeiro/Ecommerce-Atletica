using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        // String de conexão com o MySQL
        string connectionString = "Server=localhost; Database=BDEcommerceAtletica; Uid=root; Pwd=utfpr;";

        // Estabelecer a conexão
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();  // Abrir a conexão
                Console.WriteLine("Conexão com MySQL bem-sucedida!");

                // Exemplo de comando SQL: Listar as tabelas no banco de dados
                string sqlQuery = "SHOW TABLES;";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0)); // Exibir nome das tabelas
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar: " + ex.Message);
            }
        }
    }
}
