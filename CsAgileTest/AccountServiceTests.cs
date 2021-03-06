﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsAgile;
using Moq;

namespace CsAgileTest
{
    [TestClass]
    public class AccountServiceTests
    {
        //[TestInitialize]
        //public void Setup()
        //{
        //    mockAccount = new Mock<Account>(AccountType.Silver);
        //    mockRepository = new Mock<IAccountRepository>();
        //    sut = new AccountService(mockRepository.Object);
        //}

        //private Mock<Account> mockAccount;
        //private Mock<IAccountRepository> mockRepository;
        //private AccountService sut;

        //[TestMethod]
        //public void AddingTransactionToAccountDelegatesToAccountInstance()
        //{
        //    //Arrange
        //    var account = new Account(AccountType.Silver);
        //    //var mockRepository = new Mock<IAccountRepository>();
        //    mockRepository.Setup(r => r.GetByName("Trading Account")).Returns(account);
        //    //var fakeRepository = new FakeAccountRepository(account);
        //    //var sut = new AccountService(mockRepository.Object);
        //    //var sut = new AccountService(fakeRepository);

        //    //Act
        //    sut.AddTransactionToAccount("Trading Account", 200m);

        //    //Assert
        //    Assert.AreEqual(200m, account.Balance);
        //}
        //[TestMethod]
        //[ExpectedException(typeof(ArgumentNullException))]
        //public void CannotCreateAccountServiceWithNullAccountRepository()
        //{
        //    //Arrange

        //    //Act
        //    new AccountService(null);

        //    //Assert
        //}

        ///// <summary>
        ///// 既沒有期望異常也沒有斷言的單元測試
        ///// </summary>
        //[TestMethod]
        //public void DoNotThrowWhenAccountIsNotFound()
        //{
        //    //Arrange
        //    //var mockRepository = new Mock<IAccountRepository>();
        //    //var sut = new AccountService(mockRepository.Object);

        //    //Act
        //    sut.AddTransactionToAccount("Trading Account", 100m);

        //    //Assert
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ServiceExceptions))]
        //public void AccountExceptionAreWrappedInThrowServiceException()
        //{
        //    //Arrange
        //    //var account = new Mock<Account>();
        //    mockAccount.Setup(a => a.AddTransaction(100m)).Throws<DomainException>();
        //    //var mockRepository = new Mock<IAccountRepository>();
        //    mockRepository.Setup(r => r.GetByName("Trading Account")).Returns(mockAccount.Object);
        //    //var sut = new AccountService(mockRepository.Object);

        //    //Act
        //    sut.AddTransactionToAccount("Trading Account", 100m);

        //    //Assert
        //}

        [TestMethod]
        public void CanCreateGoldAccount()
        {
            //Arrange
            var accountFactory = new Mock<IAccountFactory>();
            //var accountFactory = new AccountFactory();
            var accountRepository = new Mock<IAccountRepository>();
            //var accountRepository = new FakeAccountRepository();
            var sut = new AccountService(accountFactory.Object, accountRepository.Object);

            //Act
            sut.CreateAccount(AccountType.Gold);

            //Assert
            accountRepository.Verify(ar => ar.NewAccount(It.IsAny<AccountBase>()));
        }
    }
}
