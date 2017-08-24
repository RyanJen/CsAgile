using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CsAgile
{
    public class AccountFactory : IAccountFactory
    {
       public AccountBase CreateAccount(AccountType accountType)
        {
            return AccountBase.CreateAccount(accountType);
        }
}
}