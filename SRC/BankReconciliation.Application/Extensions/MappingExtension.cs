using BankReconciliation.Domain.Entities;
using BankReconciliation.Infrastructure.Corsscuting.Parser.Contracts;
using BankReconciliation.Infrastructure.DataContracts.DTO;
using System.Linq;

namespace BankReconciliation.Application.Extensions
{
    public static class MappingExtension
    {
        #region Map To Domain

        public static Extract ToDomain(this ExtractOFX source) =>
            source == null ? null : new Extract();

        #endregion

        #region Map To DTO

        public static ExtractDTO ToDTO(this Extract source) =>
            source == null ? null : new ExtractDTO()
            {
                BankAccount = source.BankAccount?.ToDTO(),
                FinalDate = source.FinalDate,
                InitialDate = source.InitialDate,
                Status = source.Status?.ToDTO(),
                Transactions = source.Transactions?.Select(t => t.ToDTO()).ToList()
            };

        public static BankAccountDTO ToDTO(this BankAccount source) =>
            source == null ? null : new BankAccountDTO()
            {
                AccountId = source.AccountId,
                BankCode = source.BankCode,
                Type = source.Type
            };

        public static StatusDTO ToDTO(this Status source) =>
            source == null ? null : new StatusDTO()
            {
                Code = source.Code,
                Severity = source.Severity
            };

        public static TransactionDTO ToDTO(this Transaction source) =>
            source == null ? null : new TransactionDTO()
            {
                Date = source.Date,
                Type = source.Type,
                Description = source.Description,
                Value = source.Value
            };

        #endregion

    }
}
