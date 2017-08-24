namespace CsAgile
{
    public interface IAccountFactory
    {
        AccountBase CreateAccount(AccountType accountType);
    }
}