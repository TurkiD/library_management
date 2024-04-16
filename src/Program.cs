internal class Program
{
    private static void Main()
    {
        var user1 = new User("Alice", new DateTime(2023, 1, 1));

        var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));

        Console.WriteLine($"{user1.Name}");
        
    }
}