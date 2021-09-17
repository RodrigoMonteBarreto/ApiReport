using System.Collections.Generic;

namespace ApiFastReport.Entity
{
    public class CategoriaEntity : BaseEntity
    {
        public string Descricao { get; set; }
        public IEnumerable<ProdutoEntity> Produtos { get; set; }
    }
}