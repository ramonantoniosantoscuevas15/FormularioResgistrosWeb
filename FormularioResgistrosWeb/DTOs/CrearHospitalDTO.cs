using System.ComponentModel.DataAnnotations;

namespace FormularioResgistrosWeb.DTOs
{
    public class CrearHospitalDTO
    {
        [Required]
        
        [StringLength(150)]
        public required string NombreHospital { get; set; }
    }
}
