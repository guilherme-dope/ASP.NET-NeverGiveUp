using Microsoft.AspNetCore.Mvc;
using MinhaListadeTarefas.Models;

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

        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {
           if (ModelState.IsValid)
            {
               
            }
            return View();
        }

    }
}
