public class Book
{
    public string Id
    {
        get;
        private set;
    }
    public string Title
    {
        get;
        private set;
    }
    public DateTime Date { get; }

    public Book(string id, string title, DateTime date = default)
    {
        Id = id;
        Title = title;
        Date = date == default ? DateTime.Now : date;
    }
}