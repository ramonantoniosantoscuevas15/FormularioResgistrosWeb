namespace FormularioResgistrosWeb.Entidades
{
    public class SangrePaciente
    {
        public int pacienteId { get; set; }
        public int sangreId { get; set; }
        public Paciente Paciente { get; set; }= null!;
        public Sangre TipoSanguineo { get; set; }= null!;
    }
}
