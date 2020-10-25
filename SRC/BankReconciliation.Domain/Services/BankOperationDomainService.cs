using BankReconciliation.Domain.Entities;
using BankReconciliation.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankReconciliation.Domain.Services
{
    public class BankOperationDomainService : IBankOperationDomainService
    {
        #region Fields

        private readonly IBankExtractRepository _bankReconciliationRepository;

        #endregion

        #region Constructors

        public BankOperationDomainService(IBankExtractRepository bankReconciliationRepository)
        {
            this._bankReconciliationRepository = bankReconciliationRepository;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Bank Reconciliation from unique Bank Account
        /// </summary>
        /// <param name="extracts"></param>
        /// <returns></returns>
        public BankConsolidateExtract ConsolidateExtracts(List<Extract> extracts)
        {
            // Validate Extracts
            this.Validate(extracts);

            // Remove duplicated transactions
            var distinctTransactions = extracts.SelectMany(e => e.Transactions).Distinct().ToList();

            var response = new BankConsolidateExtract()
            {
                Transactions = distinctTransactions,
                ExtractsName = extracts.Select(e => e.Name).ToList(),
                BankAccount = extracts.Select(e => e.BankAccount).FirstOrDefault(),
                Balance = extracts.Select(e => e.Balance).FirstOrDefault()
            };

            return response;
        }

        public async Task AddAsync(BankConsolidateExtract result)
        {
            await this._bankReconciliationRepository.AddAsync(result);
        }

        #endregion

        #region Non-Public Methods

        /// <summary>
        /// Extract Validations
        /// </summary>
        /// <param name="extracts"></param>
        private void Validate(List<Extract> extracts)
        {
            // Validate if extracts are from same bank account
            if (extracts.Select(e => e.BankAccount).Distinct().Skip(1).Any())
                throw new ArgumentException("Extratos são de bancos distintos");
        }

        #endregion
    }
}
