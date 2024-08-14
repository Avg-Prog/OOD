using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Ucll.OOD.Logging.Models;

namespace Ucll.OOD.Logging.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogTrace("Logging a Trace level logline");
            _logger.LogDebug("Logging a Debug level logline");
            _logger.LogInformation("Logging an Information level logline");
            _logger.LogWarning("Logging a Warn level logline");
            _logger.LogError("Logging an Error level logline");
            _logger.LogCritical("Logging a Critical level logline");
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
    }
}