using System.ComponentModel.DataAnnotations;

namespace FormularioResgistrosWeb.DTOs
{
    public class HospitalDTO
    {
        
        public int Id { get; set; }
        
        public required string NombreHospital { get; set; }

    }
}
