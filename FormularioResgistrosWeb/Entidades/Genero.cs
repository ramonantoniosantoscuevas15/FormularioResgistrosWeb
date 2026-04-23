using System.ComponentModel.DataAnnotations;

namespace FormularioResgistrosWeb.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        [StringLength(50)]
        public required string TipoGenero { get; set; } 

    }
}
