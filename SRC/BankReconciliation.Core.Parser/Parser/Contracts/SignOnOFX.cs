using System.Xml.Serialization;

namespace BankReconciliation.Core.Parser.Contracts
{
    public class SignOnOFX
    {
        [XmlElement("SONRS")]
        public SignOnInfoOFX SignOnInfo { get; set; }
    }
}
