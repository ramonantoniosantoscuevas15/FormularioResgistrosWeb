using Microsoft.EntityFrameworkCore;

namespace FormularioResgistrosWeb.DTOs
{
    public class FormularioDTO
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required double Cedula { get; set; }
        public required string Correo { get; set; }
        
        public string? Foto { get; set; }

        public List<TelefonoDTO> Telefonos { get; set; } = new List<TelefonoDTO>();
        public List<DirreccionDTO> Dirrecciones { get; set; } = new List<DirreccionDTO>();
        public List<CategoriaDTO> Categorias { get; set; } = new List<CategoriaDTO>();
    }
}
