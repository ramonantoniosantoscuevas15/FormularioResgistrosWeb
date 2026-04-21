namespace FormularioResgistrosWeb.Entidades
{
    public class CategoriaFormulario
    {
        public int FormularioId { get; set; }
        public int CategoriaId { get; set; }
        public Formulario Formulario { get; set; } = null!;
        public Categoria Categoria { get; set; } = null!;
    }
}
