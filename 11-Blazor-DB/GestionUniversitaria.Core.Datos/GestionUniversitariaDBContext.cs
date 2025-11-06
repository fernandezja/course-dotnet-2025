using GestionUniversitaria.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUniversitaria.Core.Datos
{
    internal class GestionUniversitariaDBContext: DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("GestionUniversitariaDB");
        }

    }
}
