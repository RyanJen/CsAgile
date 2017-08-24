namespace CsAgile
{
    public interface IAccountRepository
    {
        Account GetByName(string v1);

        void NewAccount(AccountBase v1);
    }
}