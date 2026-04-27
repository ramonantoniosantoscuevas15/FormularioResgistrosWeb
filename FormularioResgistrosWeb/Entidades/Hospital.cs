using System.ComponentModel.DataAnnotations;

namespace FormularioResgistrosWeb.Entidades
{
    public class Hospital
    {
        [Required]
        public int Id { get; set; }
        [StringLength(150)]
        public required string NombreHospital { get; set; }
        public List<HospitalPaciente> HospitalPacientes { get; set; } = new List<HospitalPaciente>();

    }
}
