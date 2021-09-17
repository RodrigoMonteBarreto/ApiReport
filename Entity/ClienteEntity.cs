using System.Collections.Generic;

namespace ApiFastReport.Entity
{
    public class ClienteEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public IEnumerable<VendaEntity> Vendas { get; set; }
    }
}