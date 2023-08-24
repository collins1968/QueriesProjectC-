using Microsoft.EntityFrameworkCore;
using QueriesProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QueriesProject
{
    public class MyDbContext : DbContext
    {
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Trainees> Trainees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=COLLO;Database=TestingDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trainer>()
              .HasMany(t => t.Trainees)
                .WithOne(t => t.Trainer)
                .HasForeignKey(t => t.TrainerId);
        }
    }
}
