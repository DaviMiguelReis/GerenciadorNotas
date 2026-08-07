using GerenciadorNotas.Models;
using GerenciadorNotas.ViewModels;

namespace GerenciadorNotas.Services
{
    public class NotaService
    {
        private readonly List<Nota> _Notas = new();
        private int _proximoId = 1;

        public List<Nota> ObterTodos() => _Notas;

        public void Adicionar(NovaNotaViewModel vm)
        {
            _Notas.Add(new Nota
            {
                Id = _proximoId++,
                Titulo = vm.Titulo,
                Conteudo = vm.Conteudo,
                DataCriacao = vm.DataCriacao
            });
        }
    }
}
