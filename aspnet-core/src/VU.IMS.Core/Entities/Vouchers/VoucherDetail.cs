using System;
using Abp.Domain.Entities.Auditing;
using VU.IMS.Entities.ChartOfAccounts;

namespace VU.IMS.Entities.Vouchers
{
    public class VoucherDetail : FullAuditedEntity
    {
        public VoucherDetail()
        {
        }
        public LedgerAccount LedgerAccount { get; set; }
        public Voucher Voucher { get; set; }
        public string Detail { get; set; }
        public decimal DebitAmount { get; set; }
        public decimal CreditAmount { get; set; }
    }
}
