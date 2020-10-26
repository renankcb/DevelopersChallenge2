using System.Xml.Serialization;

namespace BankReconciliation.Core.Parser.Contracts
{
    public class StatusOFX
    {
        [XmlElement("CODE")]
        public int Code { get; set; }

        [XmlElement("SEVERITY")]
        public string Severity { get; set; }
    }
}
