using System;
using System.Collections.Generic;

namespace BankReconciliation.Domain.Entities
{
    public class Extract
    {
        public Status Status { get; set; }

        public BankAccount BankAccount { get; set; }

        public DateTime InitialDate { get; set; }

        public DateTime FinalDate { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
