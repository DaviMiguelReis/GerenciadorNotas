namespace GerenciadorNotas.ViewModels
{
    public class NovaNotaViewModel
    {
        public string Titulo { get; set; } = string.Empty;
        public string Conteudo { get; set; } = string.Empty;

        public DateTime? DataCriacao { get; set; } = DateTime.Now;
    }
}
