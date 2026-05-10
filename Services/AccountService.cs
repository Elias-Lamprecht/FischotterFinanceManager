using FischotterFinanceManager.Models;

namespace FischotterFinanceManager.Services;

public class AccountService
{
    #region properties

    public List<Account> Accounts { get; private init; } = [];

    #endregion properties

    #region methods

    public Account CreateAccount(Guid id, string title, string description)
    {
        Account account = new(id, title, description);
        Accounts.Add(account);
        return account;
    }

    public void DeleteAccount(Account account)
    {
        Accounts.Remove(account);
    }

    #endregion methods
}
