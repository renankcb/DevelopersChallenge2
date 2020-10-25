using BankReconciliation.Domain.Entities;
using System.Collections.Generic;

namespace BankReconciliation.Domain.Services
{
    public interface IBankOperationDomainService
    {
        BankConsolidateExtract ConsolidateExtracts(List<Extract> extracts);
    }
}
