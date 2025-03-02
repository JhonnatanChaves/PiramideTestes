namespace Piramide.Core.Domain
{
    public class PedidoItem
    {
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        public decimal CalcularSubtotal()
        {
            return Quantidade * PrecoUnitario;
        }
    }
}