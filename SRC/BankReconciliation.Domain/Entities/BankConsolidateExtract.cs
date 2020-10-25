using System.Collections.Generic;

namespace BankReconciliation.Domain.Entities
{
    public class BankConsolidateExtract
    {
        public BankAccount BankAccount { get; set; }

        public List<string> ExtractsName { get; set; }

        public List<Transaction> Transactions { get; set; }

        public Balance Balance { get; set; }
    }
}
