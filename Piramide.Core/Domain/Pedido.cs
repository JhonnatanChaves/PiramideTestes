using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide.Core.Domain
{
    public class Pedido
    {
        public int Id { get; set; }

        public List<PedidoItem> Itens { get; set; } = new List<PedidoItem>();

        public bool IndEntrega { get; set; }

        private const decimal TAXA_ENTREGA = 5.00m;


        public decimal CalcularTotal()
        {
            if(IndEntrega)
                return Itens.Sum(item => item.CalcularSubtotal()) + TAXA_ENTREGA;

            return Itens.Sum(item => item.CalcularSubtotal());
        }

        public bool ValidarPedido()
        {
            return Itens.Count > 0 && Itens.All(item => item.Quantidade > 0);
        }

    }
}
