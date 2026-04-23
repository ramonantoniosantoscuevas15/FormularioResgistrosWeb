namespace FormularioResgistrosWeb.Entidades
{
    public class EstadoPaciente
    {
        public int pacienteId { get; set; }
        public int estadoId { get; set; }
        public Paciente Paciente { get; set; }= null!;
        public Estado Estado { get; set; }= null!;
    }
}
