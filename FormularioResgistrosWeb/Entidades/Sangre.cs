using System.ComponentModel.DataAnnotations;

namespace FormularioResgistrosWeb.Entidades
{
    public class Sangre
    {
        public int Id { get; set; }
        [StringLength(4)]
        public required string TipoSangre { get; set; }
        public List<SangrePaciente> SangrePacientes { get; set; } = new List<SangrePaciente>();
    }
}
