using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskSolution.Models;

namespace TaskSolution.DataBaseConfig
{
    public class MusicianConfig : IEntityTypeConfiguration<Musician>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Musician> B)
        {
            B.HasKey(b => b.MusId);
            B.Property(b => b.MusId).UseIdentityColumn(10, 10);
            B.Property(b => b.FirstName).IsRequired().HasMaxLength(20);
            B.Property(b => b.LastName).HasMaxLength(20);
            B.Ignore(b => b.FullName);
            B.Property(b => b.Password).HasAnnotation("Password", "******");
        }
    }
}