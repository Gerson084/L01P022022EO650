using Microsoft.EntityFrameworkCore;

namespace L01P022022EO650.Models
{
    public class notasDbContext: DbContext
    {
        public notasDbContext(DbContextOptions<notasDbContext> options) : base(options)
        {

        }
        public DbSet<Facultad> Facultades { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }

    }
}
