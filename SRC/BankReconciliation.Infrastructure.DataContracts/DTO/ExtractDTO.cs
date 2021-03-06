﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BankReconciliation.Infrastructure.DataContracts.DTO
{
    [DataContract]
    public class ExtractDTO
    {
        [DataMember]
        public StatusDTO Status { get; set; }

        [DataMember]
        public BankAccountDTO BankAccount { get; set; }

        [DataMember]
        public string InitialDate { get; set; }

        [DataMember]
        public string FinalDate { get; set; }

        [DataMember]
        public List<TransactionDTO> Transactions { get; set; }

        [DataMember]
        public BalanceDTO Balance { get; set; }

        [DataMember]
        public string Currency { get; set; }
    }
}
