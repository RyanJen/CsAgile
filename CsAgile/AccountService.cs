using System;

namespace CsAgile
{
    public class AccountService : IAccountService
    {
        public AccountService(IAccountRepository repository)
        {
            if (repository == null) throw new ArgumentNullException("repository", "A valid account repository must be supplied.");
            this.repository = repository;
        }

        public void AddTransactionToAccount(string uniqueAccountName, decimal transactionAmount)
        {
            var account = repository.GetByName(uniqueAccountName);
            if (account != null)
            {
                try
                {
                    account.AddTransaction(transactionAmount);
                }
                catch(DomainException domainException)
                {
                    throw new ServiceExceptions("An exception was throw by a domain object", domainException);
                }
            }
        }

        private readonly IAccountRepository repository;
    }
}