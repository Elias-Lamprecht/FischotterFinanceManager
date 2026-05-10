namespace FischotterFinanceManager.Entities;

public class BaseEntity(Guid Id)
{
    #region properties

    public Guid Id { get; init; } = Id;

    #endregion properties
}
