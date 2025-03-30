using Piramide.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide.Testes.IntegrationTests
{
    public class PedidoTestesIntegracao
    {
        [Fact]
        public void Pedido_ComItens_DeveCalcularTotalCorretamente()
        {
            var pedido = new Pedido();

            pedido.Itens.Add(new PedidoItem { Id = 1, Quantidade = 3, PrecoUnitario = 20 });
            pedido.Itens.Add(new PedidoItem { Id = 2, Quantidade = 1, PrecoUnitario = 100 });

            var total = pedido.CalcularTotal();

            Assert.Equal(160, total);
        }

        [Fact]
        public void Pedido_SemItens_DeveSerInvalido()
        {
            var pedido = new Pedido();

            Assert.False(pedido.ValidarPedido());
        }

        [Fact]
        public void Pedido_QuantidadeZero_DeveSerInvalido()
        {
            var pedido = new Pedido();

            pedido.Itens.Add(new PedidoItem { Id = 1, Quantidade = 0, PrecoUnitario = 20 });

            Assert.False(pedido.ValidarPedido());
        }

        [Fact]
        public void Pedido_RemoverItem_DeveAtualizarTotal()
        {
            var pedido = new Pedido();

            var item = new PedidoItem { Id = 1, Quantidade = 0, PrecoUnitario = 20 };

            pedido.Itens.Add(item);
            pedido.Itens.Remove(item);

            Assert.Equal(0, pedido.CalcularTotal());
        }

    }
}
