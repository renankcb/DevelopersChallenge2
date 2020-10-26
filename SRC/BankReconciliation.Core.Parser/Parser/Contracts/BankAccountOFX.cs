using System.Xml.Serialization;

namespace BankReconciliation.Core.Parser.Contracts
{
    public class BankAccountOFX
    {
        [XmlElement("BANKID")]
        public int BankCode { get; set; }

        [XmlElement("ACCTID")]
        public long AccountId { get; set; }

        [XmlElement("ACCTTYPE")]
        public string Type { get; set; }

    }
}
