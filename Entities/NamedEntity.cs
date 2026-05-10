namespace FischotterFinanceManager.Entities;

public class NamedEntity : BaseEntity
{
    #region properties

    public string Title 
    { 
        get => _title; 
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("title", "Title can't be null, empty or whitespace.");

            if (value.Length > 32)
                throw new Exception("Title can't be longer than 32 Characters.");
        }
    }
    private string _title { get; set; }

    public string Description 
    { 
        get => _description; 
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("description", "Description can't be null, empty or whitespace.");

            if (value.Length > 128)
                throw new Exception("Description can't be longer than 128 Characters.");
        }
    }
    private string _description { get; set; }

    #endregion properties

    #region ctor

    public NamedEntity(Guid id, string title, string description) : base(id)
    {
        Title = title;
        Description = description;
    }

    #endregion ctor
}
