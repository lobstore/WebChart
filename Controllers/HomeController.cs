using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebChart.Models;

namespace WebChart.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<TemperatureData> temperatureData;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            temperatureData = new List<TemperatureData> {
                new TemperatureData { Year = 2000, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2001, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2002, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2003, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2004, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2005, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2006, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2007, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2008, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2009, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2010, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2011, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2012, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2013, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2014, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2015, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2016, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2017, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2018, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2019, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) },
                new TemperatureData { Year = 2020, AverageTemperature = 10 + (float)new Random().NextDouble()*(30-10) }
            };
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ShowData()
        {
            return View(temperatureData);
        }
    }
}