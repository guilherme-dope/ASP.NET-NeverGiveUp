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
           if (tarefa.DataFim < tarefa.DataInicio)
            {
                ModelState.AddModelError("DataFim", "The end date cannot be earlier than the start date.");
            } 

           if (ModelState.IsValid)
            {
                ViewData["Message"] = "Dados salvos com sucesso.";
                return View(tarefa);
            }
            return View();
        }

    }
}
