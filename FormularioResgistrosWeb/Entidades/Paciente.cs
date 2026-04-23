using System.ComponentModel.DataAnnotations;

namespace FormularioResgistrosWeb.Entidades
{
    public class Paciente
    {
        public int Id { get; set; }
        [StringLength(50)]
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
        [StringLength(50)]
        public required string NombreContacto { get; set; }
        public required double TelefonoContacto { get; set; }
        public List<EstadoPaciente> EstadoPacientes { get; set; } = new List<EstadoPaciente>();
        public List<DoctorPaciente> DoctorPacientes { get; set; } = new List<DoctorPaciente>();
        public List<HospitalPaciente> HospitalPacientes { get; set; } = new List<HospitalPaciente>();
        public List<SangrePaciente> SangrePacientes { get; set; } = new List<SangrePaciente>();
    }
}
