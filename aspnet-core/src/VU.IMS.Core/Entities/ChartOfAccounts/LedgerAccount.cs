using System;
using Abp.Domain.Entities.Auditing;

namespace VU.IMS.Entities.ChartOfAccounts
{
    public class LedgerAccount : FullAuditedEntity
    {
        public LedgerAccount()
        {
        }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ControlAccount ControlAccount { get; set; }
    }
}
