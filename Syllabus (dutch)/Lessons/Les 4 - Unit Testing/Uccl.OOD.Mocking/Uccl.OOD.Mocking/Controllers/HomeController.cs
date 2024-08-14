using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Uccl.OOD.Mocking.Data;
using Uccl.OOD.Mocking.Models;
using Uccl.OOD.Mocking.Services;

namespace Uccl.OOD.Mocking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CustomerOrderService _customerOrderService;

        public HomeController(ILogger<HomeController> logger,
            CustomerOrderService customerOrderService)
        {
            _logger = logger;
            _customerOrderService = customerOrderService;
        }

        public IActionResult Index()
        {
            var customers = _customerOrderService.GetCustomers();
            return View(customers);
        }

        public IActionResult Details(int customerId)
        {
            var model = _customerOrderService.GetCustomerDetailModel(customerId);
            return View(model);
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