namespace FormularioResgistrosWeb.Entidades
{
    public class Dirreccion
    {
        public int Id { get; set; }
        public required string Lugar { get; set; }
        public int FormularioId { get; set; }
    }
}
