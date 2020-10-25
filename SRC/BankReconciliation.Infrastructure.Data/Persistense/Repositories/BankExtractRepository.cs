using BankReconciliation.Domain.Entities;
using BankReconciliation.Domain.Repositories;
using BankReconciliation.Infrastructure.Data.Persistense.EF.Contexts;

namespace BankReconciliation.Infrastructure.Data.Persistense.Repositories
{
    public class BankExtractRepository : BaseRepository<BankConsolidateExtract>, IBankExtractRepository
    {
        #region Constructor

        public BankExtractRepository(BankReconciliationContext context) : base(context) { }

        #endregion
    }
}
