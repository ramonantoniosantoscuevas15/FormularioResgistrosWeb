using FormularioResgistrosWeb.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FormularioResgistrosWeb
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Formulario> Formularios { get; set; }
    }
}
