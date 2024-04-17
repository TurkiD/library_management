public interface INotificationService
{
    void SendNotificationOnSuccess(string successMessage);
    void SendNotificationOnFailure(string failureMessage);
}

public class EmailNotificationService : INotificationService
{
    public void SendNotificationOnSuccess(string successMessage)
    {
        Console.WriteLine($"Email notification on success : {successMessage}");
    }
    public void SendNotificationOnFailure(string failureMessage)
    {
        Console.WriteLine($"Email notification on success : {failureMessage}");
    }
}
public class SMSNotificationService : INotificationService
{
    public void SendNotificationOnSuccess(string successMessage)
    {
        Console.WriteLine($"SMS notification on success : {successMessage}");
    }
    public void SendNotificationOnFailure(string failureMessage)
    {
        Console.WriteLine($"SMS notification on success : {failureMessage}");
    }
}