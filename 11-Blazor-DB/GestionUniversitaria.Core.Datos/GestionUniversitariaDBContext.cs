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
        public Config ConfigActual { get; set; }

        public DbSet<Alumno> Alumnos { get; set; }

        public GestionUniversitariaDBContext(Config configActual)
        {
            ConfigActual = configActual;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(ConfigActual.ConnectionString);
        }

    }
}
