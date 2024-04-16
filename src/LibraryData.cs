public abstract class LibraryData
{
    public Guid id;
    public DateTime createdDate;

    public LibraryData(DateTime? date = null)
    {
        id = Guid.NewGuid();
        createdDate = date ?? DateTime.Now;
    }
}