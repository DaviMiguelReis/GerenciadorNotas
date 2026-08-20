using System.ComponentModel.DataAnnotations;

namespace GerenciadorNotas.ViewModels
{
    public class EditarNotaViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o título da nota.")]
        [StringLength(100, ErrorMessage = "O título da nota deve ter no máximo 100 caracteres.")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o conteúdo da nota.")]
        public string Conteudo { get; set; } = string.Empty;

    }
}
