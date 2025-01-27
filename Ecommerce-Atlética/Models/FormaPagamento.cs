using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Ecommerce_Atlética.model
{
    public class FormaPagamento
    {

        //IDs deve ser implementando apenas busca, geração deve vir do Banco quando inserido
        public int Id { get; private set; }
        public int IdPedido { get; private set; }


        public string DataPagamento { get; private set; } = "";
        public string MetodoPagamento { get; private set; } = "";
        public double ValorTotal { get; private set; }

        //Gerador de data baseado no sistema, necessário validação com banco para comprender formato preenchido interno para caso necessário gerar data em formato e converter
        public bool GerarDataPagamento()
        {
            try
            {
                DataPagamento = DateTime.Now.ToString();
                Console.WriteLine(DataPagamento);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool SetMetodoPagamento(/*Método deve vir direto do front, evitando erro de escrita com o banco*/string metodoPagamento)
        {
            try
            {
                //Função para inserir no banco
                
                return true;
            }catch
            { Console.WriteLine("Erro em preencher metodo de pagamento em banco de dados"); return false;}
        }







    }
}