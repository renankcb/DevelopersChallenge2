using BankReconciliation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankReconciliation.Domain.Services
{
    public class ReconciliationDomainService : IReconciliationDomainService
    {
        #region Public Methods

        /// <summary>
        /// Bank Reconciliation from unique Bank Account
        /// </summary>
        /// <param name="extracts"></param>
        /// <returns></returns>
        public Extract Reconciliate(List<Extract> extracts)
        {
            // Validate Extracts
            this.Validate(extracts);

            // Remove duplicated transactions
            var distinctTransactions = extracts.SelectMany(e => e.Transactions).Distinct().ToList();

            var response = new Extract()
            {
                Transactions = distinctTransactions
            };

            return response;
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
