using Piramide.Core.Domain;
using Piramide.Core.Domain.Enums;
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

            pedido.Itens.Add(new PedidoItem { Id = 1, Quantidade = 0, PrecoUnitario = 10 });

            Assert.False(pedido.ValidarPedido());
        }

        [Fact]
        public void Pedido_CalcularTotal_DeveRetornarValorCorreto()
        {
            var pedido = new Pedido();

            pedido.Itens.Add(new PedidoItem { Id = 1, Quantidade = 1, PrecoUnitario = 20 });
            pedido.Itens.Add(new PedidoItem { Id = 2, Quantidade = 20, PrecoUnitario = 3 });

            Assert.Equal(80, pedido.CalcularTotal());
        }

        [Fact]
        public void Pedidos_ComEntrega_PizzaSimples_DevemAcrescentarTaxa()
        {
            var pedido = new Pedido { IndEntrega = true};

            pedido.Itens.Add(new PizzaSimples(1, ESaborPizza.Calabresa, EEspessuraMassa.Tradicional, ETamanhoPizza.Grande, 1));

            Assert.Equal(39.90m, pedido.CalcularTotal());
        }

        [Fact]
        public void Pedidos_ComEntrega_PizzaMista_DevemAcrescentarTaxa()
        {
            var pedido = new Pedido { IndEntrega = true };            
            var pizzaMista = new PizzaMista();

            pizzaMista.MontarPizzaMista(1, ESaborPizza.Calabresa, ESaborPizza.CarneSeca, EEspessuraMassa.Tradicional, ETamanhoPizza.Grande,1);

            pedido.Itens.Add(pizzaMista);

            Assert.Equal(44.90m, pedido.CalcularTotal());
        }

        [Fact]
        public void Pedidos_SemEntrega_PizzaSimples_DevemAcrescentarTaxa()
        {
            var pedido = new Pedido { IndEntrega = false };

            pedido.Itens.Add(new PizzaSimples(1, ESaborPizza.Calabresa, EEspessuraMassa.Tradicional, ETamanhoPizza.Grande, 1));

            Assert.Equal(34.90m, pedido.CalcularTotal());
        }

        [Fact]
        public void Pedidos_SemEntrega_PizzaMista_DevemAcrescentarTaxa()
        {
            var pedido = new Pedido { IndEntrega = false };
            var pizzaMista = new PizzaMista();

            pizzaMista.MontarPizzaMista(1, ESaborPizza.Calabresa, ESaborPizza.CarneSeca, EEspessuraMassa.Tradicional, ETamanhoPizza.Grande, 1);

            pedido.Itens.Add(pizzaMista);

            Assert.Equal(39.90m, pedido.CalcularTotal());
        }

    }
}
