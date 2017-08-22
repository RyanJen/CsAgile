using System;

namespace CsAgile
{
    public class Account
    {
        public void AddTransaction(decimal amount)
        {
            Balance += amount;
        }

        public decimal Balance { get; private set; }
    }
}