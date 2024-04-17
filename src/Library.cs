public class Library
{
    private List<Book> _books;
    private List<User> _users;
    private INotificationService notificationService;

    public Library(INotificationService notificationService)
    {
        _books = new List<Book>();
        _users = new List<User>();
        this.notificationService = notificationService;
    }

    public void addUser(User user)
    {
        if (!user.Equals(null))
        {
            _users.Add(user);
            if (notificationService.ToString() == "EmailNotificationService")
            {
                notificationService.SendNotificationOnSuccess($"Hello, a new user '{user.Name}' has been successfully added to the Library. If you have any queries or feedback, please contact our support team at support@library.com.");
            }
            else
            {
                notificationService.SendNotificationOnSuccess($"User '{user.Name}' added to Library. Thank you!");
            }
        }
        else
        {
            if (notificationService.ToString() == "EmailNotificationService")
            {
                notificationService.SendNotificationOnFailure($"We encountered an issue adding user. Please review the input data. For more help, visit our FAQ at library.com/faq.");
            }
            else
            {
                notificationService.SendNotificationOnFailure($"Error adding User. Please email support@library.com.");
            }
        }

    }

    public void addBook(Book book)
    {
        if (!book.Equals(null))
        {
            _books.Add(book);
            if (notificationService.ToString() == "EmailNotificationService")
            {
                notificationService.SendNotificationOnSuccess($"Hello, a new book titled '{book.Title}' has been successfully added to the Library. If you have any queries or feedback, please contact our support team at support@library.com.");
            }
            else
            {
                notificationService.SendNotificationOnSuccess($"Book '{book.Title}' added to Library. Thank you!");
            }
        }
        else
        {
            if (notificationService.ToString() == "EmailNotificationService")
            {
                notificationService.SendNotificationOnSuccess($"We encountered an issue adding book. Please review the input data. For more help, visit our FAQ at library.com/faq.");
            }
            else
            {
                notificationService.SendNotificationOnFailure($"Error adding Book. Please email support@library.com.");
            }
        }
    }

    public User findUserByName(string name)
    {
        var searchedUser = _users.FirstOrDefault(i => i.Name == name);
        if (searchedUser == null)
        {
            notificationService.SendNotificationOnFailure($"User with name '{name}' not exist");
            return null;
        }
        else
        {
            return searchedUser;
        }
    }

    public Book findBookByTitle(string title)
    {
        var searchedBook = _books.FirstOrDefault(i => i.Title == title);
        if (searchedBook == null)
        {
            notificationService.SendNotificationOnFailure($"Book with title '{title}' not exist");
            return null;
        }
        else
        {
            return searchedBook;
        }
    }

    public void deleteUser(Guid id)
    {
        var userToBeDelete = _users.FirstOrDefault(i => i.id == id);
        if (!userToBeDelete.Equals(null))
        {
            _users.Remove(userToBeDelete);
            notificationService.SendNotificationOnSuccess("User Successfully deleted");
        }
        else
        {
            notificationService.SendNotificationOnFailure("ERROR: Can not delete User");
        }
    }

    public void deleteBook(Guid id)
    {
        var bookToBeDelete = _books.FirstOrDefault(i => i.id == id);
        if (!bookToBeDelete.Equals(null))
        {
            _books.Remove(bookToBeDelete);
            notificationService.SendNotificationOnSuccess("Book Successfully deleted");
        }
        else
        {
            notificationService.SendNotificationOnFailure("ERROR: Can not delete the book");
        }
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