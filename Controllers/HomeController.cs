using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _7_Dojo_Survey_with_Validations.Models;

namespace _7_Dojo_Survey_with_Validations.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public static List<Survey> FormLists = new List<Survey>();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("create/survey")]
    public IActionResult Create(Survey formData)
    {
        if(ModelState.IsValid)
        {
            FormLists.Add(formData);
            return RedirectToAction("Results");
        }
        else
        {
            return View("Index");
        }
    }

    [HttpGet("results")]
    public IActionResult Results()
    {
        return View("Results", FormLists);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
