using FischotterFinanceManager.UI.Components;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            _menu.DisplayMenu();
        }
    }

    #region fields

    private static readonly Menu _menu = new();

    #endregion fields
}