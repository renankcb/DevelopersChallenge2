using BankReconciliation.Domain.Entities;
using System.Collections.Generic;

namespace BankReconciliation.Domain.Services
{
    public interface IReconciliationDomainService
    {
        Reconciliation Reconciliate(List<Extract> extracts);
    }
}
