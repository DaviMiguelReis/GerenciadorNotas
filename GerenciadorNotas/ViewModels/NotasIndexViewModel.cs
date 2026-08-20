using GerenciadorNotas.Models;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorNotas.ViewModels
{
    public class NotasIndexViewModel
    {
        public List<Nota> Notas { get; set; } = [];
        public string? TextoPesquisa { get; set; }
        public int QuantidadeTotal { get; set; }
        public string? OrdenarPor { get; set; }
    }
}
