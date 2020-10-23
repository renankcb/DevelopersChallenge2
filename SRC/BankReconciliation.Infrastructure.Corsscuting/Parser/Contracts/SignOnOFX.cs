using System.Xml.Serialization;

namespace BankReconciliation.Infrastructure.Corsscuting.Parser.Contracts
{
    public class SignOnOFX
    {
        [XmlElement("SONRS")]
        public SignOnInfoOFX SignOnInfo { get; set; }
    }
}
