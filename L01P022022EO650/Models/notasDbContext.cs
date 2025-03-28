﻿using Microsoft.EntityFrameworkCore;

namespace L01P022022EO650.Models
{
    public class notasDbContext: DbContext
    {
        public notasDbContext(DbContextOptions<notasDbContext> options) : base(options)
        {

        }
        public DbSet<facultades> facultades { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<materias> materias { get; set; }
        public DbSet<alumnos> alumnos { get; set; }

    }
}
