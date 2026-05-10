using FischotterFinanceManager.Entities;

namespace FischotterFinanceManager.Models;

public class Account(Guid id, string title, string description) : NamedEntity(id, title, description)
{
    #region properties

    #region navigationProperties

    public List<Payment> Payments { get; private init; } = [];

    #endregion navigationProperties

    #endregion properties
}
