using GerenciadorNotas.Services;
using GerenciadorNotas.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorNotas.Controllers
{
    public class NotasController : Controller
    {
        private readonly NotaService _notaService;

        // O construtor recebe o serviço injetado automaticamente
        public NotasController(NotaService notaService)
        {
            _notaService = notaService;
        }

        // Exibe a tela de listagem (GET)
        [HttpGet]
        public IActionResult Index()
        {
            var projetos = _notaService.ObterTodos();
            return View(projetos);
        }

        // Exibe o formulário vazio (GET)
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        // Recebe os dados preenchidos no formulário (POST)
        [HttpPost]
        public IActionResult Cadastrar(NovaNotaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _notaService.Adicionar(viewModel);
                // Após salvar, redireciona de volta para a listagem
                return RedirectToAction(nameof(Index));
            }

            // Se der erro de validação, volta pra mesma tela mostrando o formulário preenchido
            return View(viewModel);
        }


    }
}
