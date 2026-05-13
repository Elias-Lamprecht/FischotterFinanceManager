namespace FischotterFinanceManager.UI.Components;

public class MenuItem(string label, Action action, string category)
{
    #region properties

    public string Label { get; private set; } = label;
    public Action Action { get; private set; } = action;
    public string Category { get; private set; } = category;

    #endregion properties
}