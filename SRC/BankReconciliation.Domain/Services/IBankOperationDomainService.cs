using BankReconciliation.Domain.Entities;
using System.Collections.Generic;

namespace BankReconciliation.Domain.Services
{
    public interface IBankOperationDomainService
    {
        Reconciliation ConsolidateExtracts(List<Extract> extracts);
    }
}
