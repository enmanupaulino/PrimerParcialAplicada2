using Microsoft.EntityFrameworkCore;
using PrimerParcialAplic2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcialAplic2.Data
{
    public class Contexto :DbContext
    {
        public DbSet<Inscripciones> inscripciones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source= inscripcionesdb");
        }
    }
}
