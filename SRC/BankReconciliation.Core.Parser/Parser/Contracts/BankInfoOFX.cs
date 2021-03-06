﻿using System.Xml.Serialization;

namespace BankReconciliation.Core.Parser.Contracts
{
    public class BankInfoOFX
    {
        [XmlElement("STMTTRNRS")]
        public StatementOFX Statement { get; set; }
    }

    public class StatementOFX
    {
        [XmlElement("STMTRS")]
        public StatementResponseOFX BankStatementResponse { get; set; }
    }
}
