using System.Xml.Serialization;

namespace BankReconciliation.Infrastructure.Corsscuting.Parser.Contracts
{
    [XmlRoot("OFX")]
    public class ExtractOFX
    {
        [XmlElement("SIGNONMSGSRSV1")]
        public SignOnOFX SignOn { get; set; }

        [XmlElement("BANKMSGSRSV1")]
        public BankInfoOFX BankInfo { get; set; }

        public string Name { get; set; }
    }
}
