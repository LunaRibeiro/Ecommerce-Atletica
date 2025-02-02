using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_Atlética.model
{
    public class CupomDesconto
    {
            public int Id { get; set;}
            public int IdCliente { get; set;}
            public bool TipoCliente { get; set; }
            public double ValorDesconto { get; set; } = 0;


            
            public double GerarDesconto(string categoriaProduto, bool TipoCliente, /*Valor do produto sendo usado para retornar 
            diretamente o valor do produto com desconto caso existe*/double valorProduto)
            {
                if (TipoCliente == true){
                    //Switch com valor de desconto para cada categoria de produto ou definição geral para simplificar?
                }
                return valorProduto;
            }

    }
}