using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MinhaListadeTarefas.Models;
using System.Data;

namespace MinhaListadeTarefas.Controllers
{
    public class TarefaController : Controller
    {
        private AppDbContext _context;

        public TarefaController(AppDbContext context)
        {
            _context = context;
        }

        public void CarregarCombos()
        {
            ViewData["Categorias"] = new SelectList(_context.Categorias.ToList(), "Id", "Nome");
            ViewData["Prioridades"] = new SelectList(_context.Prioridade.ToList(), "Id", "Nome");
            ViewData["Responsaveis"] = new SelectList(_context.Responsaveis.ToList(), "Id", "Nome");
            ViewData["Status"] = new SelectList(_context.Statuses.ToList(), "Id", "Nome");
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            CarregarCombos();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {
            CarregarCombos();

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

            return View();
        }
    }
}
