using Microsoft.AspNetCore.Mvc;

namespace MinhaListadeTarefas.Controllers
{
    public class TarefaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }



    }
}
