using Microsoft.EntityFrameworkCore;

namespace FormularioResgistrosWeb.Entidades
{
    public class Formulario
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; } 
        public required double  Cedula { get; set; }
        public required string  Correo { get; set; } 
        [Unicode(false)]
        public string? Foto { get; set; } 
        public List<Telefono> Telefonos { get; set; } = new List<Telefono>();
        public List<Dirreccion> Dirrecciones { get; set; } = new List<Dirreccion>();
        public List<CategoriaFormulario> CategoriaFormularios { get; set; } = new List<CategoriaFormulario>();

    }
}
