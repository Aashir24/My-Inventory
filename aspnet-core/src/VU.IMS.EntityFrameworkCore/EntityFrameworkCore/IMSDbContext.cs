using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using VU.IMS.Authorization.Roles;
using VU.IMS.Authorization.Users;
using VU.IMS.MultiTenancy;
using VU.IMS.Entities.ChartOfAccounts;
using VU.IMS.Entities.Vouchers;
using VU.IMS.Entities;

namespace VU.IMS.EntityFrameworkCore
{
    public class IMSDbContext : AbpZeroDbContext<Tenant, Role, User, IMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public IMSDbContext(DbContextOptions<IMSDbContext> options)
            : base(options)
        {
        }

        public DbSet<ParentAccount> ParentAccounts { get; set; }
        public DbSet<ControlAccount> ControlAccounts { get; set; }
        public DbSet<LedgerAccount> LedgerAccounts { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<VoucherDetail> VoucherDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }
    }
}
