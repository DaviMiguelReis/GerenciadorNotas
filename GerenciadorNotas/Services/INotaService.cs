using GerenciadorNotas.Models;
using GerenciadorNotas.ViewModels;

namespace GerenciadorNotas.Services
{
    public interface INotaService
    {
        List<Nota> Listar();
        Nota? ObterPorId(int id);
        void Adicionar(NovaNotaViewModel model);
        bool Atualizar(EditarNotaViewModel model);
        bool Remover(int id);

        List<Nota> PesquisarPorTitulo(string? titulo);

        List<Nota> Ordenar(IEnumerable<Nota> projetos, string? ordenarPor);
    }
}
