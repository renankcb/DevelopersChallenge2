using System.Runtime.Serialization;

namespace BankReconciliation.Infrastructure.DataContracts.DTO
{
    [DataContract]
    public class StatusDTO
    {
        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public string Severity { get; set; }
    }
}
