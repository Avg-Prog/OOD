using Microsoft.AspNetCore.Mvc;
using MyExampleAPI;
using System.Diagnostics;
using Ucll.OOD.Exceptions.Models;
using Ucll.OOD.Exceptions.Services;

namespace Ucll.OOD.Exceptions.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApiCallerService _apiService;

        public HomeController(ILogger<HomeController> logger, ApiCallerService fileService)
        {
            _logger = logger;
            _apiService = fileService;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var results = await _apiService.GetWeatherForecastAsync();
            return View(results);
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
    }
}