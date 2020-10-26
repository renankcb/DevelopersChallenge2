using System.Xml.Serialization;

namespace BankReconciliation.Core.Parser.Contracts
{
    public class BalanceAggregateOFX
    {
        [XmlElement("BALAMT")]
        public double Balance { get; set; }

        [XmlElement("DTASOF")]
        public string Date { get; set; }
    }
}
