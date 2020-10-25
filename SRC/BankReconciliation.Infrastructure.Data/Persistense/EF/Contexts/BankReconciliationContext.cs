using BankReconciliation.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankReconciliation.Infrastructure.Data.Persistense.EF.Contexts
{
    public class BankReconciliationContext : DbContext
    {
        public BankReconciliationContext(DbContextOptions<BankReconciliationContext> options) : base(options) { }

        public DbSet<BankConsolidateExtract> BankExtracts { get; set; }
    }
}
