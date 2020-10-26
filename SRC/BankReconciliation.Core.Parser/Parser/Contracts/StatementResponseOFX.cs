using System.Xml.Serialization;

namespace BankReconciliation.Core.Parser.Contracts
{
    public class StatementResponseOFX
    {
        [XmlElement("CURDEF")]
        public string Currency { get; set; }

        [XmlElement("BANKACCTFROM")]
        public BankAccountOFX BankAccount { get; set; }

        [XmlElement("BANKTRANLIST")]
        public BrankTransactionsOFX BankTransactionsData { get; set; }

        [XmlElement("LEDGERBAL")]
        public BalanceAggregateOFX Balance { get; set; }
    }
}
