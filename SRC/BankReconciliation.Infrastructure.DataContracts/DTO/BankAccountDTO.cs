using System.Runtime.Serialization;

namespace BankReconciliation.Infrastructure.DataContracts.DTO
{
    [DataContract]
    public class BankAccountDTO
    {
        [DataMember]
        public int BankCode { get; set; }

        [DataMember]
        public long AccountId { get; set; }

        [DataMember]
        public string Type { get; set; }
    }
}
