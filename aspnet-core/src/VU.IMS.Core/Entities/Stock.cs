using System;
using Abp.Domain.Entities.Auditing;

namespace VU.IMS.Entities
{
    public class Stock : FullAuditedEntity
    {
        public Stock()
        {
        }
        public Product Product { get; set; }
        public DateTime Date { get; set; }
        public StockType Type { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
    }

    public enum StockType
    {
        In,
        Out
    }
}
