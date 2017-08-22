using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsAgile;
using Moq;

namespace CsAgileTest
{
    [TestClass]
    public class AccountServiceTests
    {
        [TestMethod]
        public void AddingTransactionToAccountDelegatesToAccountInstance()
        {
            //Arrange
            var account = new Account();
            var mockRepository = new Mock<IAccountRepository>();
            mockRepository.Setup(r => r.GetByName("Trading Account")).Returns(account);
            //var fakeRepository = new FakeAccountRepository(account);
            var sut = new AccountService(mockRepository.Object);
            //var sut = new AccountService(fakeRepository);

            //Act
            sut.AddTransactionToAccount("Trading Account", 200m);

            //Assert
            Assert.AreEqual(200m, account.Balance);
        }
    }
}
