using Piramide.Core.Domain.Enums;
using Piramide.Core.Domain.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide.Core.Domain
{
    public class PizzaSimples : PedidoItem
    {
        public ESaborPizza Sabor { get; set; }
        public string? Ingredientes { get; set; }
        public EEspessuraMassa EspessuraMassa { get; set; }
        public ETamanhoPizza Tamanho { get; set; }

        public PizzaSimples(){}

        public PizzaSimples(int id, ESaborPizza sabor, EEspessuraMassa espessuraMassa, ETamanhoPizza tamanho, int quantidade)        
        {
            Id = id;
            Sabor = sabor;            
            EspessuraMassa = espessuraMassa;
            Tamanho = tamanho;
            Quantidade = quantidade;
            DefinirPrecoUnitarioPorTamanho();
        }

        private void DefinirPrecoUnitarioPorTamanho()
        {
            SaboresGroup saboresGroup = new SaboresGroup();

            switch (Tamanho)
            {
                case ETamanhoPizza.Pequena:
                    PrecoUnitario = saboresGroup.PrecosPizzaP[Sabor];
                    break;

                case ETamanhoPizza.Media:
                    PrecoUnitario = saboresGroup.PrecosPizzaM[Sabor];
                    break;

                case ETamanhoPizza.Grande:
                    PrecoUnitario = saboresGroup.PrecosPizzaG[Sabor];
                    break;                
            }            
        }
       
    }
}
