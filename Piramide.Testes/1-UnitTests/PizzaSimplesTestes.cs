using Piramide.Core.Domain;
using Piramide.Core.Domain.Enums;
using Piramide.Core.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide.Testes._1_UnitTests
{
    public class PizzaSimplesTestes
    {
        [Fact]
        public void PizzaSimples_ComDadosValidos_DeveRetornarValorCorreto()
        {
            var pizza = new PizzaSimples(1, ESaborPizza.Calabresa, EEspessuraMassa.Tradicional, ETamanhoPizza.Grande, 1);

            Assert.True(VerificaDadosPizza.Validar((int)pizza.Sabor, (int)pizza.EspessuraMassa, (int)pizza.Tamanho, pizza.Quantidade));
        }
    }
}
