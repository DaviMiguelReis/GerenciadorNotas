using GerenciadorNotas.Models;
using GerenciadorNotas.ViewModels;
//using System.Xml.Linq;

namespace GerenciadorNotas.Services
{
    public class NotaService : INotaService
    {
        private readonly List<Nota> _projetos =
    [
        new Nota
        {
            Id = 1,
            Titulo = "Sistema de Biblioteca Escolar",
            Conteudo = "Aplicação para controle de livros e empréstimos.",
            DataCriacao = DateTime.Now
        },
        new Nota
        {
            Id = 2,
            Titulo = "Portal de Projetos Acadêmicos",
            Conteudo = "Sistema para divulgação de projetos desenvolvidos pelos estudantes.",
            DataCriacao = DateTime.Now
        }

        ];


        public List<Nota> Listar()
        {
            return _projetos;
        }

        public Nota? ObterPorId(int id)
        {
            return _projetos.FirstOrDefault(projeto => projeto.Id == id);
        }

        public void Adicionar(NovaNotaViewModel vm)
        {
            var novoProjeto = new Nota
            {
                Id = GerarNovoId(),
                Titulo = vm.Titulo,
                Conteudo = vm.Conteudo,
                DataCriacao = vm.DataCriacao
            };

            _projetos.Add(novoProjeto);
        }

        public bool Atualizar(EditarNotaViewModel model)
        {
            var projeto = ObterPorId(model.Id);

            if (projeto is null)
                return false;

            projeto.Titulo = model.Titulo;
            projeto.Conteudo = model.Conteudo;
            projeto.DataCriacao = model.DataCriacao;

            return true;
        }

        public bool Remover(int id)
        {
            var projeto = ObterPorId(id);

            if (projeto is null)
                return false;

            _projetos.Remove(projeto);
            return true;
        }
        private int GerarNovoId()
        {
            return _projetos.Count == 0 ? 1 : _projetos.Max(projeto => projeto.Id) + 1;
        }
    }
}
