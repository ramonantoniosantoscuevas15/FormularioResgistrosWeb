namespace FormularioResgistrosWeb.Entidades
{
    public class Telefono
    {
        public int Id { get; set; }
        public required double Nuemro { get; set; }

        public int FormularioId { get; set; }
    }
}
