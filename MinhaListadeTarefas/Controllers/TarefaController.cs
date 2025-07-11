using Microsoft.AspNetCore.Mvc;
using MinhaListadeTarefas.Models;

namespace MinhaListadeTarefas.Controllers
{
    public class TarefaController : Controller
    {
        public IActionResult Index()
        {
            var list = new List<Tarefa>();
            list.Add(new Tarefa { Id = 1, Descricao = "Tarefa 1", DataInicio = DateTime.Now, DataFim = DateTime.Now.AddDays(1) });
            list.Add(new Tarefa { Id = 2, Descricao = "Tarefa 2", DataInicio = DateTime.Now.AddDays(1), DataFim = DateTime.Now.AddDays(2) });
            list.Add(new Tarefa { Id = 3, Descricao = "Tarefa 3", DataInicio = DateTime.Now.AddDays(2), DataFim = DateTime.Now.AddDays(3) });
            list.Add(new Tarefa { Id = 4, Descricao = "Tarefa 4", DataInicio = DateTime.Now.AddDays(3), DataFim = DateTime.Now.AddDays(4) });

            return View(list);
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

        public IActionResult Edit(int id)
        {

            var list = new List<Tarefa>();
            list.Add(new Tarefa { Id = 1, Descricao = "Tarefa 1", DataInicio = DateTime.Now, DataFim = DateTime.Now.AddDays(1) });
            list.Add(new Tarefa { Id = 2, Descricao = "Tarefa 2", DataInicio = DateTime.Now.AddDays(1), DataFim = DateTime.Now.AddDays(2) });
            list.Add(new Tarefa { Id = 3, Descricao = "Tarefa 3", DataInicio = DateTime.Now.AddDays(2), DataFim = DateTime.Now.AddDays(3) });
            list.Add(new Tarefa { Id = 4, Descricao = "Tarefa 4", DataInicio = DateTime.Now.AddDays(3), DataFim = DateTime.Now.AddDays(4) });

            // Simulate fetching the task from a database
            var tarefa = (from p in list where p.Id == id select p).FirstOrDefault();

            return View(tarefa);
        }
    }
}
