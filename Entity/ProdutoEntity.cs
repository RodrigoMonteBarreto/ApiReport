namespace ApiFastReport.Entity
{
    public class ProdutoEntity : BaseEntity
    {
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string Ean { get; set; }
        public int CategoriaId { get; set; }
        public CategoriaEntity Categoria { get; set; }
    }
}