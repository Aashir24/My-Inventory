using System;
using Abp.Domain.Entities.Auditing;

namespace VU.IMS.Entities.ChartOfAccounts
{
    public class ControlAccount : FullAuditedEntity
    {
        public ControlAccount()
        {
        }

        public string Title { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public AccountNature Nature { get; set; }
        public ParentAccount ParentAccount { get; set; }

    }

    public enum AccountNature
    {
        Asset,
        Expense,
        Inventory
    }
}
