namespace myWebApplicationMVC.Services
{
    public class GreetingService : IGreetingService
    {
        public string GetWelcomeMessage()
        {
            return GetWelcomeMessage(DateTime.Now);
        }

        public string GetWelcomeMessage(DateTime dateTime)
        {
            int hour = dateTime.Hour;

            if (hour >= 6 && hour < 12)
            {
                return "Доброе утро!";
            }
            else if (hour >= 12 && hour < 18)
            {
                return "Добрый день!";
            }
            else if (hour >= 18 && hour < 23)
            {
                return "Добрый вечер!";
            }
            else
            {
                return "Доброй ночи!";
            }
        }
    }
}