namespace FormularioResgistrosWeb.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public required string Tipo { get; set; }
        public List<CategoriaFormulario> CategoriaFormularios { get; set; } = new List<CategoriaFormulario>();
    }
}
