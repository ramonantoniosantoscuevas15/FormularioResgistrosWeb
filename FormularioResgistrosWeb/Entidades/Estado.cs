using System.ComponentModel.DataAnnotations;

namespace FormularioResgistrosWeb.Entidades
{
    public class Estado
    {
        [Required]
        public int Id { get; set; }
        [StringLength(10)]
        public required string TipoEstado { get; set; }
        public List<EstadoPaciente> EstadoPacientes { get; set; } = new List<EstadoPaciente>();
    }
}
