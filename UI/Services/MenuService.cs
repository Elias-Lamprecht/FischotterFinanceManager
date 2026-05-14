using FischotterFinanceManager.Models;
using FischotterFinanceManager.Services;
using Spectre.Console;

namespace FischotterFinanceManager.UI.Services;

public static class MenuService
{
    #region fields

    private static readonly AccountService _accountService = AccountService.Instance(); 

    #endregion fields

    public static void CreateAccount()
    {
        var accountTitle = new TextPrompt<string>("Enter Account title: ")
            .Validate(input => input.Length > 0 && string.IsNullOrWhiteSpace(input),
            "[red]Account title can't be empty or only whitespace!");

        var accountTitleResult = AnsiConsole.Prompt(accountTitle);

        var accountDescription = new TextPrompt<string?>("Enter Account description:")
            .DefaultValue(null)
            .ShowDefaultValue();

        var accountDescriptionResult = AnsiConsole.Prompt(accountDescription);


        _accountService.CreateAccount(Guid.NewGuid(), accountTitleResult, accountDescriptionResult);
    }

    public static void DeleteAccount()
    {
        var account = AnsiConsole.Prompt(
            new SelectionPrompt<Account>()
                .Title("Select which account to [red]delete[/]:")
                .AddChoices(_accountService.Accounts));

        _accountService.DeleteAccount(account);

        AnsiConsole.MarkupLine("Successfully deleted the Account.");
    }
}
