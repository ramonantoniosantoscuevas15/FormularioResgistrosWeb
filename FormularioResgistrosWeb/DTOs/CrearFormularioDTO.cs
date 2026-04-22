using Microsoft.EntityFrameworkCore;

namespace FormularioResgistrosWeb.DTOs
{
    public class CrearFormularioDTO
    {
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required double Cedula { get; set; }
        public required string Correo { get; set; }
        
        public IFormFile? Foto { get; set; }

        public List<CrearTelefonoDTO> Telefonos { get; set; } = new List<CrearTelefonoDTO>();
        public List<CrearDirreccionDTO> Dirrecciones { get; set; } = new List<CrearDirreccionDTO>();
        public List<int>? CategoriasIds { get; set; } 

    }
}
