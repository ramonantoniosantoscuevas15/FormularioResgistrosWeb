using System.ComponentModel.DataAnnotations;

namespace FormularioResgistrosWeb.Entidades
{
    public class Doctor
    {
        public int Id { get; set; }
        [StringLength(50)]
        public required string Nombre { get; set; }
        [StringLength(150)]
        public required string Especialidad { get; set; }
        public List<DoctorPaciente> DoctorPacientes { get; set; } = new List<DoctorPaciente>();

    }
}
