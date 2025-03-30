using Piramide.Core.Domain.Enums;
using Piramide.Core.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide.Core.Domain
{
    public class PizzaMista : PedidoItem 
    {
        public ESaborPizza Sabor1 { get; set; }
        public ESaborPizza Sabor2 { get; set; }
        public string? Ingredientes { get; set; }
        public EEspessuraMassa EspessuraMassa { get; set; }
        public ETamanhoPizza Tamanho { get; set; }


        public bool MontarPizzaMista(int id, ESaborPizza sabor1, ESaborPizza sabor2, EEspessuraMassa espessuraMassa, ETamanhoPizza tamanho, int quantidade)
        {
            if (!VerificaDadosPizza.Validar((int)sabor1, (int)espessuraMassa, (int)tamanho, quantidade,  (int)sabor2))
                return false;

            Id = id;
            Sabor1 = sabor1;
            Sabor2 = sabor2;
            EspessuraMassa = espessuraMassa;
            Tamanho = tamanho;
            Quantidade = quantidade;

            CalcularValor();

            return true;
        }


        public void CalcularValor()
        {
            var precoSabor1 = DefinirPrecoUnitarioPorTamanho(Sabor1);
            var precoSabor2 = DefinirPrecoUnitarioPorTamanho(Sabor2);

            PrecoUnitario = (precoSabor1 + precoSabor2) / 2;          
        }

        private decimal DefinirPrecoUnitarioPorTamanho(ESaborPizza sabor)
        {
            SaboresGroup saboresGroup = new SaboresGroup();


            if(Tamanho == ETamanhoPizza.Pequena)
                return saboresGroup.PrecosPizzaP[sabor];

            if(Tamanho == ETamanhoPizza.Media)
                return saboresGroup.PrecosPizzaM[sabor];
           
            return saboresGroup.PrecosPizzaG[sabor];

        }

         
    }
}
