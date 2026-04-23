namespace FormularioResgistrosWeb.Entidades
{
    public class HospitalPaciente
    {
        public int pacienteId { get; set; }
        public int hospitalId { get; set; }
        public Paciente Paciente { get; set; }= null!;
        public Hospital Hospital { get; set; }= null!;

    }
}
