using Piramide.Core.Domain.Enums;
using Piramide.Core.Domain.Helpers;
using Piramide.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide.Testes._1_UnitTests
{
    public class PizzaMistaTestes
    {
        [Fact]
        public void Pizza_ComValoresValidos_DeveRetornarValorCorreto()
        {
            PizzaMista pizzaMista = new PizzaMista();
            
            bool indValida = pizzaMista.MontarPizzaMista(1, ESaborPizza.Calabresa, ESaborPizza.CarneSeca, EEspessuraMassa.Tradicional, ETamanhoPizza.Grande, 1);

            Assert.True(indValida);
        }
    }
}
