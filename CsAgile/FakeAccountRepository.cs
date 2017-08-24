using System;

namespace CsAgile
{
    public class FakeAccountRepository : IAccountRepository
    {
        public FakeAccountRepository()
        {
            
        }

        public FakeAccountRepository(Account account)
        {
            this.account = account;
        }

        public Account GetByName(string accountName)
        {
            return account;
        }

        public void NewAccount(AccountBase account)
        {

        }

        private Account account;
    }
}