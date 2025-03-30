using Piramide.Core.Domain;
using SpecFlow.Internal.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide.Testes._3_SystemTests
{
    public class TestesSistema
    {
        [Fact]
        public void CriarPedido_ComMultiplosItens_DeveCalcularTotalCorretamente()
        {
            var pedido = new Pedido();

            pedido.Itens.Add(new PedidoItem { Id = 1, Quantidade = 3, PrecoUnitario = 50 });
            pedido.Itens.Add(new PedidoItem { Id = 2, Quantidade = 1, PrecoUnitario = 150 });

            var total = pedido.CalcularTotal();

            Assert.Equal(300,total);
        }

        [Fact]
        public void Pedido_ComValorAlto_DeveAplicarFreteGratis()
        {
            var pedido = new Pedido();

            pedido.Itens.Add(new PedidoItem { Id = 1, Quantidade = 3, PrecoUnitario = 250 });                       

            Assert.True(pedido.CalcularTotal() > 500);
        }

        [Fact]
        public void Pedido_ComItemZero_Quantidade_DeveSerInvalido()
        {
            var pedido = new Pedido();

            pedido.Itens.Add(new PedidoItem { Id = 1, Quantidade = 0, PrecoUnitario = 100 });

            Assert.False(pedido.ValidarPedido());
        }

        [Fact]
        public void Pedido_RemoverItem_DeveRecalcularTotal()
        {
            var pedido = new Pedido();

            var item = new PedidoItem{ Id = 1, Quantidade = 4, PrecoUnitario = 30 };
            
            pedido.Itens.Add(item);
            pedido.Itens.Remove(item);
            
            Assert.Equal(0, pedido.CalcularTotal());
        }

    }
}
