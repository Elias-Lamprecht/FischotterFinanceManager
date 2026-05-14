namespace FischotterFinanceManager.UI.Components;

public class MenuItem(string label, Action? action)
{
    #region properties

    public string Label { get; private set; } = label;
    public Action? Action { get; private set; } = action;

    #endregion properties
}