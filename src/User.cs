public class User : LibraryData
{
    public string Name
    {
        get;
        private set;
    }

    public User(string name, DateTime? createdDate = null) : base(createdDate)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $" - {Name}, {createdDate}";
    }
}