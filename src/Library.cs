public class Library
{
    private List<Book> _books;
    private List<User> _users;

    public Library() {
        _books = new List<Book>();
        _users = new List<User>();
    }

    public void addUser(User user) {
        _users.Add(user);
    }

    public void addBook(Book book) {
        _books.Add(book);
    }

    public User findUserByName(string name) {
        return _users.FirstOrDefault(i => i.Name == name);
    }

    public Book findBookByTitle(string title) {
        return _books.FirstOrDefault(i => i.Title == title);
    }
}