using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModel.Models;
using ViewModel.ViewModel;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OrderRepository _orderRepository;

        public HomeController(ILogger<HomeController> logger, OrderRepository orderRepository)
        {
            _logger = logger;
            _orderRepository = orderRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult NetPriceOrderDetail()
        {
           var modelList = new List<NetPriceViewModel>();
            var orders = _orderRepository.GetOrders();
            foreach (var order in orders)
            {
                var details = _orderRepository.GetDetailOrdersForOrder(order.Id);
                foreach (var detail in details)
                {
                    var model = new NetPriceViewModel
                    {
                        Id = order.Id,
                        CustomerName = order.CustomerName,
                        Item = detail.ItemCode,
                        Price = detail.UnitPrice,
                        Quantity = detail.Quantity
                    };
                    modelList.Add(model);
                }
                

            }

            return View(modelList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}