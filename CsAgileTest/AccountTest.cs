using CsAgile;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsAgileTest
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void AddingTransactionChangesBalance()
        {
            //Arrange
            var account = new Account(AccountType.Silver);

            //Act
            account.AddTransaction(200m);

            //Assert
            Assert.AreEqual(200m, account.Balance);
        }

        [TestMethod]
        public void AccountsHaveAnOpeningBalanceOfZero()
        {
            //Arrange

            //Act
            var account = new Account(AccountType.Silver);

            //Assert
            Assert.AreEqual(0m, account.Balance);
        }

        [TestMethod]
        public void Adding100TransactionChangesBalance()
        {
            //Arrange
            var account = new Account(AccountType.Silver);

            //Act
            account.AddTransaction(100m);

            //Assert
            Assert.AreEqual(100m, account.Balance);
        }

        [TestMethod]
        public void AddingTwoTransactionCreatesSummationBalance()
        {
            //Arrange
            var account = new Account(AccountType.Silver);
            account.AddTransaction(50m);

            //Act
            account.AddTransaction(75m);

            //Assert
            Assert.AreEqual(125m, account.Balance);
        }
    }
}
