using System;
using Abp.Domain.Entities.Auditing;

namespace VU.IMS.Entities.ChartOfAccounts
{
    public class ParentAccount : FullAuditedEntity
    {
        public ParentAccount()
        {
        }
        public string Title { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public AccountType AccountType { get; set; }

    }

    public enum AccountType
    {
        Asset,
        Liability,
        Equity,
        Revenue,
        Expense
    }
}
