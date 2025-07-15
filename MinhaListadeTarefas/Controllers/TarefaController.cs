using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MinhaListadeTarefas.Models;
using MinhaListadeTarefas.Services;
using System.Data;

namespace MinhaListadeTarefas.Controllers
{
    public class TarefaController : Controller
    {
        private AppDbContext _context;
        private ServiceTarefa _serviceTarefa;

        public TarefaController(AppDbContext context)
        {
            _context = context;
            _serviceTarefa = new ServiceTarefa(_context);
        }

        public async Task CarregarCombos()
        {
            ViewData["Categorias"] = new SelectList(await _serviceTarefa.RptCategoria.ListarTodosAsync(), "Id", "Nome");
            ViewData["Prioridades"] = new SelectList(await _serviceTarefa.RptPrioridade.ListarTodosAsync(), "Id", "Nome");
            ViewData["Responsaveis"] = new SelectList(await _serviceTarefa.RptResponsavel.ListarTodosAsync(), "Id", "Nome");
            ViewData["Status"] = new SelectList(await _serviceTarefa.RptStatus.ListarTodosAsync(), "Id", "Nome");
        }

        public async Task<IActionResult> Index()
        {
            var listaTask = await _serviceTarefa.RptTarefa.ListarTodosAsync();
            return View(listaTask);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            await CarregarCombos();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tarefa tarefa)
        {
            await CarregarCombos();

            if (tarefa.DataFim < tarefa.DataInicio)
            {
                ModelState.AddModelError("DataFim", "The end date cannot be earlier than the start date.");
            }

            if (ModelState.IsValid)
            {
                ViewData["Message"] = "Dados salvos com sucesso.";
                await _serviceTarefa.RptTarefa.IncluirAsync(tarefa);
                return View(tarefa);
            }
            return View();
        }

        public async Task<IActionResult> Edit(int id)        
        {
            await CarregarCombos();

            var tarefa = await _serviceTarefa.RptTarefa.SelecionarChaveAsync(id);
            return View(tarefa);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Tarefa tarefa)
        {
            await CarregarCombos();

            if (tarefa.DataFim < tarefa.DataInicio)
            {
                ModelState.AddModelError("DataFim", "The end date cannot be earlier than the start date.");
            }
            if (ModelState.IsValid)
            {
                ViewData["Message"] = "a";
                await _serviceTarefa.RptTarefa.AlterarAsync(tarefa);
                return View(tarefa);
            }
            return View();
        }
    }
}