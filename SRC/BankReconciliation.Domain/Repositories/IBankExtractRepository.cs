using BankReconciliation.Domain.Entities;
using System.Threading.Tasks;

namespace BankReconciliation.Domain.Repositories
{
    public interface IBankExtractRepository
    {
        Task AddAsync(BankConsolidateExtract result);
    }
}
