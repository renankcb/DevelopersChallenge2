﻿using System.Collections.Generic;

namespace BankReconciliation.Domain.Entities
{
    public class Extract
    {
        public Status Status { get; set; }

        public BankAccount BankAccount { get; set; }

        public string InitialDate { get; set; }

        public string FinalDate { get; set; }

        public List<Transaction> Transactions { get; set; }

        public Balance Balance { get; set; }

        public string Currency { get; set; }

        public string Name { get; set; }
    }
}
