public class User
{
    public string Id
    {
        get;
        private set;
    }
    public string Name
    {
        get;
        private set;
    }
    public DateTime Date { get; }

    public User(string id, string name, DateTime date = default)
    {
        Id = id;
        Name = name;
        Date = date == default ? DateTime.Now : date;
    }
}