using BankReconciliation.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankReconciliation.Infrastructure.Data.Persistense.EF.Contexts
{
    public class BankReconciliationContext : DbContext
    {
        public BankReconciliationContext(DbContextOptions<BankReconciliationContext> options) : base(options) { }

        public DbSet<BankConsolidateExtract> BankExtracts { get; set; }

        public DbSet<BankAccount> BankAccounts { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Balance> Balances { get; set; }
    }
}
