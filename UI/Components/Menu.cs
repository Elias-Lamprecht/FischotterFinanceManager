using Spectre.Console;

namespace FischotterFinanceManager.UI.Components;

public class Menu()
{
    #region methods

    /// <summary>
    /// Runs the main menu loop and handles exception catching.
    /// </summary>
    public void DisplayMenu()
    {
        MenuItem selectedOption = AskUserForMenuOption();

        try
        {
            selectedOption.Action!();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    /// <summary>
    /// Displays all menu options.
    /// </summary>
    public MenuItem AskUserForMenuOption()
    {
        DisplayHeader();

        var prompt = new SelectionPrompt<MenuItem>()
            .Title("Menu Choices:")
            .PageSize(10)
            .MoreChoicesText("[gray](Move up or down with the arrow keys to see the rest)[/]")
            .EnableSearch()
            .SearchPlaceholderText("Type to search options...")
            .WrapAround()
            .Mode(SelectionMode.Leaf)
            .HighlightStyle(new Style(Color.BlueViolet, decoration: Decoration.Bold))
            .UseConverter(menuItem => $"{menuItem.Label}")
            .AddChoiceGroup(new MenuItem("Account Options", null), new[]
            {
                new MenuItem("Create Account", CreateAccount),
                new MenuItem("Delete Account", DeleteAccount)
            });

        var entry = AnsiConsole.Prompt(prompt);

        return entry;
    }

    /// <summary>
    /// Prints the application header.
    /// </summary>
    public static void DisplayHeader()
    {
        FigletText headerText = new FigletText("FFM") { Justification = Justify.Center }
            .Color(Color.Purple);

        AnsiConsole.Write(headerText);
    }

    public void CreateAccount() { }

    public void DeleteAccount() { }

    #endregion methods
}