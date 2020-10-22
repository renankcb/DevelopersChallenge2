using System;
using System.Collections.Generic;
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
        public DateTime InitialDate { get; set; }

        [DataMember]
        public DateTime FinalDate { get; set; }

        [DataMember]
        public List<TransactionDTO> Transactions { get; set; }
    }
}
