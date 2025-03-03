using Piramide.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit.Extensions;

namespace Piramide.Testes._5_Steps
{
    [Binding]
    public class PedidoSteps
    {
        private Pedido _pedido = new Pedido();

        [Given(@"que eu tenha um novo pedido")]
        public void DadoQueEuTenhaUmNovoPedido()
        {
            _pedido = new Pedido();
        }

        [When(@"eu adicionar um item com quantidade (.*) e preço unitário de (.*)")]
        public void QuandoEuAdicionarUmItem(int quantidade, decimal precoUnitario)
        {
            _pedido.Itens.Add(new PedidoItem
            {
                ProdutoId = 1,
                Quantidade = quantidade,
                PrecoUnitario = precoUnitario
            });
        }

        [Then(@"o valor total do pedido deve ser (.*)")]
        public void EntaoOValorTotalDoPedidoDeveSer(decimal valorEsperado)
        {
            Assert.Equal(valorEsperado, _pedido.CalcularTotal());
        }

        [Then(@"o pedido deve ser considerado inválido")]
        public void EntaoOPedidoDeveSerConsideradoInvalido()
        {
            Assert.False(_pedido.ValidarPedido());
        }

        [Then(@"o frete deve ser grátis")]
        public void EntaoOFreteDeveSerGratis()
        {
            Assert.True(_pedido.CalcularTotal() > 500);
        }
    }
}
