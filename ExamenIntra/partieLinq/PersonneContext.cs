using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenIntra.partieLinq
{
    public class PersonneContext : DbContext
    {
        public DbSet<Personne> Personnes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ExamBD;Trusted_Connection=True;");

    }
}
