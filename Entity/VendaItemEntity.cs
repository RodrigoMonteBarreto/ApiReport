namespace ApiFastReport.Entity
{
    public class VendaItemEntity : BaseEntity
    {
        public int VendaId { get; set; }
        public VendaEntity Venda { get; set; }
        public int ProdutoId { get; set; }
        public ProdutoEntity Produto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorProduto { get; set; }
        public decimal TotalProduto { get; set; }
    }
}