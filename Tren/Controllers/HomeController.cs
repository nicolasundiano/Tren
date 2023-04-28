using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tren.Extensions;
using Tren.Models;

namespace Tren.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var vm = new TrenViewModel();
        
        return View(vm);
    }
    
    [HttpPost]
    public IActionResult AddVagon(TrenViewModel vm)
    {
        vm.Tren = vm.TrenString.SplitToIntList();
        vm.Tren.AddElementToList(vm.Vagon, vm.InRight);
        vm.TrenString = vm.Tren.JoinToString('-');
        return View("Index", vm);
    }

    [HttpPost]
    public IActionResult RemoveVagon(TrenViewModel vm)
    {
        vm.Tren = vm.TrenString.SplitToIntList();
        vm.Tren.RemoveElementFromList(vm.InRight);
        vm.TrenString = vm.Tren.JoinToString('-');

        return View("Index", vm);
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