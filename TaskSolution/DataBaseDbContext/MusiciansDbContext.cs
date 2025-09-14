using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskSolution.DataBaseConfig;
using TaskSolution.Models;

namespace TaskSolution.DataBaseDbContext
{
    public class MusiciansDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.,1433;Database=Musicans;User Id=sa;Password=Tony@12345;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder B)
        {
            B.ApplyConfiguration(new AlbumConfig());
            B.ApplyConfiguration(new InstrumentConfig());
            B.ApplyConfiguration(new MusicianConfig());
        }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
    }
}