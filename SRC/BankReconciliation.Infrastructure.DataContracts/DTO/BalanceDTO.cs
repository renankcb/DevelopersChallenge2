using System.Runtime.Serialization;

namespace BankReconciliation.Infrastructure.DataContracts.DTO
{
    [DataContract]
    public class BalanceDTO
    {
        [DataMember]
        public double Value { get; set; }

        [DataMember]
        public string Date { get; set; }
    }
}
