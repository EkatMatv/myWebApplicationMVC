using Microsoft.AspNetCore.Mvc;
using myWebApplicationMVC.Services;

namespace myWebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGreetingService _greetingService;

        public HomeController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        public string Index()
        {
            return "Hello, world!";
        }

        // Действие Welcome только для GET запросов
        [HttpGet]
        public string Welcome()
        {
            var now = DateTime.Now;
            string greeting = _greetingService.GetWelcomeMessage();

            return $"""
                   {greeting}
                   
                   Текущее время: {now:HH:mm:ss}
                   Текущая дата: {now:dd.MM.yyyy}
                   День недели: {GetRussianDayOfWeek(now.DayOfWeek)}
                   """;
        }

        [HttpGet]
        public string Time()
        {
            return $"Текущее время: {DateTime.Now:HH:mm:ss}";
        }

        private string GetRussianDayOfWeek(DayOfWeek dayOfWeek)
        {
            return dayOfWeek switch
            {
                DayOfWeek.Monday => "Понедельник",
                DayOfWeek.Tuesday => "Вторник",
                DayOfWeek.Wednesday => "Среда",
                DayOfWeek.Thursday => "Четверг",
                DayOfWeek.Friday => "Пятница",
                DayOfWeek.Saturday => "Суббота",
                DayOfWeek.Sunday => "Воскресенье",
                _ => "Неизвестно"
            };
        }
    }
}