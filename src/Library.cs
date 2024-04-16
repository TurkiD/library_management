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

    public void deleteUser(Guid id){
        User userToBeDelete = _users.FirstOrDefault(i => i.id == id);
        _users.Remove(userToBeDelete);
        Console.WriteLine($"User Successfully deleted");
    }

    public void deleteBook(Guid id){
        Book bookToBeDelete = _books.FirstOrDefault(i => i.id == id);
        _books.Remove(bookToBeDelete);
        Console.WriteLine($"Book Successfully deleted");
    }

    public void displayUsers(){
        Console.WriteLine($"Users");
        
        foreach (var user in _users)
        {
            Console.WriteLine($"{user}");
        }
    }

    public void displayBooks(){
        Console.WriteLine($"Books");
        foreach (var book in _books)
        {
            Console.WriteLine($"{book}");
        }
    }
}