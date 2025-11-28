using Microsoft.AspNetCore.Mvc;
using CrudM.Models;

namespace CrudM.Controllers
{
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;
        
        public static List<Fruta> ListaDeFrutas = new List<Fruta>
        {
            new Fruta{ Id = 1, Nome = "Morango", Preco = 5.99f, Quantidade = 10, Categoria = "Tropical"},
            new Fruta{ Id = 2, Nome = "Tangerina", Preco = 5.20f, Quantidade = 70, Categoria = "Citrica"},
            new Fruta{ Id = 3, Nome = "Maracuja", Preco = 10f, Quantidade = 12, Categoria = "Tropical"},
            new Fruta{ Id = 4, Nome = "Laranja", Preco = 2.60f, Quantidade = 100, Categoria = "Citrica"}
        };

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarFrutas()
        {
            ViewBag.Fruta = ListaDeFrutas;

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        //Salvar as frutas na Lista de Frutas
        //Em seguida, redireciona para a lista/tela de ListarFrutas
        [HttpPost]
        public IActionResult SalvarFruta(Fruta frutaCadastrada)
        {
            //criar um id novo
            frutaCadastrada.Id = ListaDeFrutas.Max(f => f.Id) + 1;
            //Salvar os dados da fruta na listaDeFrutas
            ListaDeFrutas.Add(frutaCadastrada);
            //voltar para a tela de listagem de frutas
            return RedirectToAction(nameof (ListarFrutas));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}