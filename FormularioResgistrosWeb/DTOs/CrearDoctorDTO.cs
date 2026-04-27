using System.ComponentModel.DataAnnotations;

namespace FormularioResgistrosWeb.DTOs
{
    public class CrearDoctorDTO
    {
        [Required]
        [StringLength(50)]
        public required string Nombre { get; set; }
        [StringLength(150)]
        public required string Especialidad { get; set; }
    }
}
