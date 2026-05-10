using FischotterFinanceManager.Entities;

namespace FischotterFinanceManager.Models;

public class Payment(Guid id, string title, string description, decimal amount) : NamedEntity(id, title, description)
{
    #region properties

    public decimal Amount { get; set; } = amount;

    #endregion properties
}
