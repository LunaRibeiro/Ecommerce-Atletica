using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Reflection;

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

        public bool ConfirmarPagamento(string numeroCartao)
        {
            //Codigo "secreto" para fins de validação, verificado que validar número de cartão é necessário conexão com API externa que validaria se cartão é válido
            if (numeroCartao == "1111111111111111"){ return false; }
            
            
            return true;
        }

        public bool GerarQRCode()
        {
                //Função com imagem de pix, por simulação temos acesso ao QR Code da atlética necessário implementação para salvar imagem no banco e usar puxando conversão de conversão em base 64 ou imagem diretamente
                Convert.FromBase64String(null/*string da imagem*/);                
                
                // ou 
                
                //Necessário esquema com classe de conversão direta de image = https://learn.microsoft.com/pt-br/dotnet/api/system.drawing.image?view=windowsdesktop-9.0&viewFallbackFrom=dotnet-plat-ext-8.0
                //Image qrCode = new Image("");//add string da imagem com .jpg/.png
                return true;
        }







    }
}