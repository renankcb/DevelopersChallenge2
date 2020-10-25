using BankReconciliation.Domain.Entities;
using BankReconciliation.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BankReconciliation.Domain.Tests
{
    [TestClass]
    public class ReconciliationDomainTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_Exception_When_Extracts_Are_From_Drifferent_Banks()
        {
            // Arrange

            // extract 1
            var bank1 = new BankAccount()
            {
                AccountId = 1,
                BankCode = 1,
                Type = "CHECKING"
            };

            var extract1 = new Extract()
            {
                BankAccount = bank1
            };

            // extract 2
            var bank2 = new BankAccount()
            {
                AccountId = 2,
                BankCode = 1,
                Type = "CHECKING"
            };

            var extract2 = new Extract()
            {
                BankAccount = bank2
            };

            var extracts = new List<Extract>() { extract1, extract2 };

            // Test
            var reconciliationService = new BankOperationDomainService();
            reconciliationService.ConsolidateExtracts(extracts);
        }

        [TestMethod]
        public void Should_Not_Return_Duplicated_Transactions_When_Same_Transaction_In_Different_Files()
        {
            // Arrange

            //OFX 1
            var transaction1_ofx1 = new Transaction()
            {
                Date = "20140203100000[-03:EST]",
                Description = "Transacao 1",
                Type = "DEBIT",
                Value = 1
            };

            var transaction2_ofx1 = new Transaction()
            {
                Date = "20140204100000[-03:EST]",
                Description = "Transacao 1",
                Type = "CREDIT",
                Value = 1
            };

            var transaction3_ofx1 = new Transaction()
            {
                Date = "20140204100000[-04:EST]",
                Description = "Transacao 1",
                Type = "DEBIT",
                Value = 1
            };

            var extract1 = new Extract()
            {
                Transactions = new List<Transaction>()
                    {
                        transaction1_ofx1,
                        transaction2_ofx1,
                        transaction3_ofx1
                    }
            };

            //OFX 2
            var transaction1_ofx2 = new Transaction()
            {
                Date = "20140204100000[-03:EST]",
                Description = "Transacao 1",
                Type = "CREDIT",
                Value = 1
            };

            var transaction2_ofx2 = new Transaction()
            {
                Date = "20140205100000[-03:EST]",
                Description = "Transacao 1",
                Type = "DEBIT",
                Value = 1
            };

            var transaction3_ofx2 = new Transaction()
            {
                Date = "20140211100000[-03:EST]",
                Description = "Transacao 1",
                Type = "CREDIT",
                Value = 1
            };

            var extract2 = new Extract()
            {
                Transactions = new List<Transaction>()
                    {
                        transaction1_ofx2,
                        transaction2_ofx2,
                        transaction3_ofx2
                    }
            };

            var extracts = new List<Extract>()
            {
                extract1,
                extract2
            };

            // Test
            var reconciliationService = new BankOperationDomainService();
            var result = reconciliationService.ConsolidateExtracts(extracts);

            // Assert
            Assert.AreEqual(5, result.Transactions.Count);
        }
    }
}
