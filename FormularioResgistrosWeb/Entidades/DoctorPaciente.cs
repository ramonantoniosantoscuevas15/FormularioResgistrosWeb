namespace FormularioResgistrosWeb.Entidades
{
    public class DoctorPaciente
    {
        public int doctorId { get; set; }
        public int pacienteId { get; set; }
        public Doctor Doctor { get; set; }= null!;
        public Paciente Paciente { get; set; }= null!;

    }
}
