namespace Piramide.Core.Domain
{
    public class PedidoItem
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        public decimal CalcularSubtotal()
        {
            return Quantidade * PrecoUnitario;
        }       
    }
}