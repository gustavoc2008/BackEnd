using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudM.Models;

namespace CrudM.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
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

    public IActionResult MinhaAcao()
    {
        return View();
    }    

    public IActionResult ListaNome()
    {
        string[] nomes = {"Gustavo", "Milena", "Rawany", "Guilherme", "Diogo", "Beatriz"};
        ViewBag.Teste = "Ola, eu vim atraves da ViewBag";
        ViewBag.nomes = nomes;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
