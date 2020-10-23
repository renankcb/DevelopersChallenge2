using System.Collections.Generic;
using System.Xml.Serialization;

namespace BankReconciliation.Infrastructure.Corsscuting.Parser.Contracts
{
    public class BrankTransactionsOFX
    {
        [XmlElement("DTSTART")]
        public string StartDate { get; set; }

        [XmlElement("DTEND")]
        public string EndDate { get; set; }

        [XmlElement("STMTTRN")]
        public List<TransactionOFX> Transactions { get; set; }
    }
}
