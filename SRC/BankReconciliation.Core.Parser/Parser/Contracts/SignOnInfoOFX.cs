using System.Xml.Serialization;

namespace BankReconciliation.Core.Parser.Contracts
{
    public class SignOnInfoOFX
    {
        [XmlElement("STATUS")]
        public StatusOFX Status { get; set; }

        [XmlElement("DTSERVER")]
        public string ServerDate { get; set; }

        [XmlElement("LANGUAGE")]
        public string Language { get; set; }
    }
}
