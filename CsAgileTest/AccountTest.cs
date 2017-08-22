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

        [TestMethod]
        public void AddingTransactionChangesRewardPoints()
        {
            //Arrange
            var account = new Account(AccountType.Silver);

            //Act
            account.AddTransaction(10000m);

            //Assert
            Assert.AreEqual(1000m, account.RewardPoints);
        }

        [TestMethod]
        public void AccountsHaveAnOpeningRewardPointsOfZero()
        {
            //Arrange

            //Act
            var account = new Account(AccountType.Silver);

            //Assert
            Assert.AreEqual(0m, account.RewardPoints);
        }

        [TestMethod]
        public void Adding20000TransactionChangesBalance()
        {
            //Arrange
            var account = new Account(AccountType.Silver);

            //Act
            account.AddTransaction(20000m);

            //Assert
            Assert.AreEqual(2000m, account.RewardPoints);
        }

        [TestMethod]
        public void AddingTwoTransactionCreatesSummationRewardPoints()
        {
            //Arrange
            var account = new Account(AccountType.Silver);
            account.AddTransaction(10000m);

            //Act
            account.AddTransaction(20000m);

            //Assert
            Assert.AreEqual(3000m, account.RewardPoints);
        }

        [TestMethod]
        public void AddingTransactionChangesRewardPointsGoldType()
        {
            //Arrange
            var account = new Account(AccountType.Gold);
            account.AddTransaction(10000m);

            //Act
            account.AddTransaction(10000m);

            //Assert
            Assert.AreEqual(4005m, account.RewardPoints);
        }

        [TestMethod]
        public void AddingTransactionChangesRewardPointsPlatinumType()
        {
            //Arrange
            var account = new Account(AccountType.Platinum);
            account.AddTransaction(10000m);

            //Act
            account.AddTransaction(10000m);

            //Assert
            Assert.AreEqual(10010m, account.RewardPoints);
        }
    }
}
