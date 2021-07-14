using System;
using System.Collections.Generic;
using Abp.Domain.Entities.Auditing;

namespace VU.IMS.Entities.Vouchers
{
    public class Voucher: FullAuditedEntity
    {
        public Voucher()
        {
        }
        public DateTime Date { get; set; }
        public string VoucherNo { get; set; }
        public string Detail { get; set; }
        public decimal Amount { get; set; }
        public ICollection<VoucherDetail> VoucherDetails { get; set; }
    }
}
