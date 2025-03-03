using Piramide.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide.Testes.UnitTests
{
    public class PedidosTestes
    {
        [Fact]
        public void Pedido_SemItens_DeveSerInvalido()
        {
            var pedido = new Pedido();

            Assert.False(pedido.ValidarPedido());
        }

        [Fact]
        public void Pedido_ComItens_QuantidadeZero_DeveSerInvalido()
        {
            var pedido = new Pedido();

            pedido.Itens.Add(new PedidoItem { ProdutoId = 1, Quantidade = 0, PrecoUnitario = 10 });

            Assert.False(pedido.ValidarPedido());
        }

        [Fact]
        public void Pedido_CalcularTotal_DeveRetornarValorCorreto()
        {
            var pedido = new Pedido();

            pedido.Itens.Add(new PedidoItem { ProdutoId = 1, Quantidade = 1, PrecoUnitario = 20 });
            pedido.Itens.Add(new PedidoItem { ProdutoId = 2, Quantidade = 20, PrecoUnitario = 3 });

            Assert.Equal(80, pedido.CalcularTotal());
        }
    }
}
