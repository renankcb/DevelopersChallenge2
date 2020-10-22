using System;
using System.Runtime.Serialization;

namespace BankReconciliation.Infrastructure.DataContracts.DTO
{
    [DataContract]
    public class TransactionDTO
    {
        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public double Value { get; set; }
    }
}
