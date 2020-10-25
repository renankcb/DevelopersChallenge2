using BankReconciliation.Domain.Repositories;
using System.Threading.Tasks;

namespace BankReconciliation.Infrastructure.Data.Persistense.EF.Contexts
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BankReconciliationContext _context;

        public UnitOfWork(BankReconciliationContext context)
        {
            this._context = context;
        }

        public async Task Commit()
        {
            await this._context.SaveChangesAsync();
        }

        public void Rollback()
        {
            //
        }
    }
}
