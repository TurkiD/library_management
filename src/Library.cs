public class Library
{
    private List<Book> _books;
    private List<User> _users;

    public Library()
    {
        _books = new List<Book>();
        _users = new List<User>();
    }

    public void addUser(User user)
    {
        _users.Add(user);
    }

    public void addBook(Book book)
    {
        _books.Add(book);
    }

    public User findUserByName(string name)
    {
        return _users.FirstOrDefault(i => i.Name == name);
    }

    public Book findBookByTitle(string title)
    {
        return _books.FirstOrDefault(i => i.Title == title);
    }

    public void deleteUser(Guid id)
    {
        User userToBeDelete = _users.FirstOrDefault(i => i.id == id);
        _users.Remove(userToBeDelete);
        Console.WriteLine($"User Successfully deleted");
    }

    public void deleteBook(Guid id)
    {
        Book bookToBeDelete = _books.FirstOrDefault(i => i.id == id);
        _books.Remove(bookToBeDelete);
        Console.WriteLine($"Book Successfully deleted");
    }

    public List<Book> getAllBooks(int pageNumber, int limitPerPage)
    {
        Console.WriteLine($"Page number {pageNumber}");
        return _books.OrderByDescending(book => book.createdDate).Skip((pageNumber - 1) * limitPerPage).Take(limitPerPage).ToList();
    }

    public List<User> getAllUsers(int pageNumber, int limitPerPage)
    {
        Console.WriteLine($"Page number {pageNumber}");
        return _users.OrderByDescending(user => user.createdDate).Skip((pageNumber - 1) * limitPerPage).Take(limitPerPage).ToList();
    }
}