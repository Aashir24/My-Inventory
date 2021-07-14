using System;
using Abp.Domain.Entities.Auditing;

namespace VU.IMS.Entities
{
    public class Product : FullAuditedEntity
    {
        public Product()
        {

        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
    }
}
