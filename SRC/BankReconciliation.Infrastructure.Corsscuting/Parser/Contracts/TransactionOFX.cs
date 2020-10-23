using System.Xml.Serialization;

namespace BankReconciliation.Infrastructure.Corsscuting.Parser.Contracts
{
    public class TransactionOFX
    {
        [XmlElement("TRNTYPE")]
        public string Type { get; set; }

        [XmlElement("DTPOSTED")]
        public string Date { get; set; }

        [XmlElement("MEMO")]
        public string Description { get; set; }

        [XmlElement("TRNAMT")]
        public double Value { get; set; }
    }
}
