using BankReconciliation.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankReconciliation.Domain.Services
{
    public interface IBankOperationDomainService
    {
        BankConsolidateExtract ConsolidateExtracts(List<Extract> extracts);

        Task AddAsync(BankConsolidateExtract result);
    }
}
