using System.ComponentModel.DataAnnotations;

namespace FormularioResgistrosWeb.DTOs
{
    public class DoctorDTO
    {
        
        public int Id { get; set; }
        
        public required string Nombre { get; set; }
        
        public required string Especialidad { get; set; }
    }
}
