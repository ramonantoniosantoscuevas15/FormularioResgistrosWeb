using FormularioResgistrosWeb.Entidades;
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
            modelBuilder.Entity<CategoriaFormulario>().HasKey(cf => new { cf.CategoriaId, cf.FormularioId });
        }
        public DbSet<Formulario> Formularios { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<Dirreccion> Dirrecciones { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CategoriaFormulario> CategoriaFormularios { get; set; }
    }
}
