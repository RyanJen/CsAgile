using System;

namespace CsAgile
{
    public class AccountService : IAccountService
    {
        public AccountService(IAccountRepository repository)
        {
            this.repository = repository;
        }

        public void AddTransactionToAccount(string uniqueAccountName, decimal transactionAmount)
        {
            var account = repository.GetByName(uniqueAccountName);
            account.AddTransaction(transactionAmount);
        }

        private readonly IAccountRepository repository;
    }
}