namespace myWebApplicationMVC.Services
{
    public interface IGreetingService
    {
        string GetWelcomeMessage();
        string GetWelcomeMessage(DateTime dateTime);
    }
}