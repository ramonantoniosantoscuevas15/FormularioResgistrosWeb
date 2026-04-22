namespace FormularioResgistrosWeb.DTOs
{
    public class DirreccionDTO
    {
        public int Id { get; set; }
        public required string Lugar { get; set; }
        public int FormularioId { get; set; }
    }
}
