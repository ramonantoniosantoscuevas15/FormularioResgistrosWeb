using System.ComponentModel.DataAnnotations;

namespace FormularioResgistrosWeb.DTOs
{
    public class CrearEstadoDTO
    {
        [Required]
       
        [StringLength(10)]
        public required string TipoEstado { get; set; }
    }
}
