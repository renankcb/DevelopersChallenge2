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
            source == null ? null : new Extract()
            {
                BankAccount = source.BankInfo?.Statement?.BankStatementResponse?.BankAccount?.ToDomain(),
                FinalDate = source.BankInfo?.Statement?.BankStatementResponse?.BankTransactionsData?.EndDate,
                InitialDate = source.BankInfo?.Statement?.BankStatementResponse?.BankTransactionsData?.StartDate,
                Transactions = source.BankInfo?.Statement?.BankStatementResponse?.BankTransactionsData?.Transactions?.Select(t => t.ToDomain()).ToList(),
                Balance = source.BankInfo?.Statement?.BankStatementResponse?.Balance?.ToDomain(),
                Currency = source.BankInfo?.Statement.BankStatementResponse.Currency,
                Name = source.Name
            };

        public static BankAccount ToDomain(this BankAccountOFX source) =>
            source == null ? null : new BankAccount()
            {
                AccountId = source.AccountId,
                BankCode = source.BankCode,
                Type = source.Type
            };

        public static Transaction ToDomain(this TransactionOFX source) =>
            source == null ? null : new Transaction()
            {
                Date = source.Date,
                Description = source.Description,
                Type = source.Type,
                Value = source.Value
            };

        public static Balance ToDomain(this BalanceAggregateOFX source) =>
            source == null ? null : new Balance()
            {
                Date = source.Date,
                Value = source.Balance
            };

        #endregion

        #region Map To DTO

        public static ExtractDTO ToDTO(this Extract source) =>
            source == null ? null : new ExtractDTO()
            {
                BankAccount = source.BankAccount?.ToDTO(),
                FinalDate = source.FinalDate,
                InitialDate = source.InitialDate,
                Status = source.Status?.ToDTO(),
                Transactions = source.Transactions?.Select(t => t.ToDTO()).ToList(),
                Balance = source.Balance?.ToDTO(),
                Currency = source.Currency
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

        public static BalanceDTO ToDTO(this Balance source) =>
            source == null ? null : new BalanceDTO()
            {
                Date = source.Date,
                Value = source.Value
            };

        public static BankConsolidateExtractDTO ToDTO(this BankConsolidateExtract source) =>
            source == null ? null : new BankConsolidateExtractDTO()
            {
                BankAccount = source.BankAccount.ToDTO(),
                ExtractsName = source.ExtractsName,
                Transactions = source.Transactions.Select(t => t.ToDTO()).ToList(),
                Balance = source.Balance.ToDTO()
            };

        #endregion

    }
}
