using System;
using System.Collections.Generic;

namespace ApiFastReport.Entity
{
    public class VendaEntity : BaseEntity
    {
        public int ClienteId { get; set; }
        public ClienteEntity Cliente { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal Totalvenda { get; set; }
        public IEnumerable<VendaItemEntity> VendaItem { get; set; }
    }
}