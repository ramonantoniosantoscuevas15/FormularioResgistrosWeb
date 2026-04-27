using FormularioResgistrosWeb.Utilidades;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FormularioResgistrosWeb.DTOs
{
    public class CrearPacienteDTO
    {
        [Required]
        public required string Nombre { get; set; }
        [StringLength(50)]
        public required string Apellido { get; set; }
        public required DateTime FechaNacimiento { get; set; }
        public required int Cedula { get; set; }
        public required string Correo { get; set; }
        public required double Telefono { get; set; }
        [StringLength(150)]
        public required string Direccion { get; set; }
        [StringLength(50)]
        public string Alegias { get; set; } = null!;
        [StringLength(150)]
        public string NotasMedicas { get; set; } = null!;
        [ModelBinder(BinderType =typeof(TypeBinder))]
        public List<int>? estadoId { get; set; }
        [ModelBinder(BinderType = typeof(TypeBinder))]
        public List<int>? doctorId { get; set; }
        [ModelBinder(BinderType = typeof(TypeBinder))]
        public List<int>? hospitalId { get; set; }

    }
}
