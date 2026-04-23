using FormularioResgistrosWeb.Entidades;
using FormularioResgistrosWeb.Utilidades;
using Microsoft.EntityFrameworkCore;

namespace FormularioResgistrosWeb
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {  

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyUtcDateTimeConverter();
            modelBuilder.Entity<EstadoPaciente>().HasKey(ep=> new {ep.pacienteId, ep.estadoId });
            modelBuilder.Entity<DoctorPaciente>().HasKey(dp => new { dp.doctorId, dp.pacienteId });
            modelBuilder.Entity<HospitalPaciente>().HasKey(hp => new { hp.hospitalId, hp.pacienteId });
            modelBuilder.Entity<CategoriaFormulario>().HasKey(cf => new { cf.CategoriaId, cf.FormularioId });
            modelBuilder.Entity<SangrePaciente>().HasKey(sp => new { sp.pacienteId, sp.sangreId });

        }
        public DbSet<Formulario> Formularios { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<Dirreccion> Dirrecciones { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CategoriaFormulario> CategoriaFormularios { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }
        public DbSet<Sangre> TipoSaguineos { get; set; }
        public DbSet<EstadoPaciente> EstadoPacientes { get; set; }
        public DbSet<DoctorPaciente> DoctorPacientes { get; set; }
        public DbSet<HospitalPaciente> HospitalPacientes { get; set; }
        public DbSet<SangrePaciente> SangrePacientes { get; set; }
    }
}
