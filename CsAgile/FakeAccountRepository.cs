using System;

namespace CsAgile
{
    public class FakeAccountRepository : IAccountRepository
    {
        public FakeAccountRepository(Account account)
        {
            this.account = account;
        }

        public Account GetByName(string accountName)
        {
            return account;
        }

        private Account account;
    }
}