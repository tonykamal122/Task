using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskSolution.Models;
using Microsoft.EntityFrameworkCore;

namespace TaskSolution.DataBaseConfig
{
    public class InstrumentConfig : IEntityTypeConfiguration<Instrument>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Instrument> B)
        {
            B.HasKey(I => I.Name);
            B.Property(I => I.Name).HasMaxLength(20);
            B.Property(I => I.MusicialKey).IsRequired().HasMaxLength(5);
            B.Property<int>("Code");
            B.HasCheckConstraint("CodeCheck", "[Code] BETWEEN 1 AND 100");
        }
    }
}