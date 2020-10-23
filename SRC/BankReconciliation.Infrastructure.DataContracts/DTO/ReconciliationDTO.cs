using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BankReconciliation.Infrastructure.DataContracts.DTO
{
    [DataContract]
    public class ReconciliationDTO
    {
        [DataMember]
        public BankAccountDTO BankAccount { get; set; }

        [DataMember]
        public List<string> ExtractsName { get; set; }

        [DataMember]
        public List<TransactionDTO> Transactions { get; set; }

        [DataMember]
        public BalanceDTO Balance { get; set; }
    }
}
