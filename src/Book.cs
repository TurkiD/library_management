public class Book : LibraryData
{
   public string Title
    {
        get;
        private set;
    }
    public Book(string title, DateTime? createdDate = null) : base(createdDate)
    {
        Title = title;
    }
}