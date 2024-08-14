using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers;

public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;
    private readonly UserRepository _userRepository;

    public UserController(ILogger<UserController> logger, UserRepository userRepository)
    {
        _logger = logger;
        _userRepository = userRepository;
    }
    public IActionResult Index()
    {
        var users = _userRepository.GetUsers();
        return View(users);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(User user)
    {
        _userRepository.AddUser(user);
        return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
        var user = _userRepository.GetUser(id);
        return View(user);
    }
}
