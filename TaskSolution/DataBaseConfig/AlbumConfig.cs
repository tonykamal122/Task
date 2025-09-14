using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskSolution.Models;

namespace TaskSolution.DataBaseConfig
{
    public class AlbumConfig : IEntityTypeConfiguration<Album>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Album> B)
        {
            B.HasKey(A => A.AlbumIndetifier);
            B.Property(A => A.Title).HasMaxLength(20).IsRequired(false);
            B.Property(A => A.CopyrightDate).HasComputedColumnSql("GETDATE()");
            B.Property(A => A.Price).HasPrecision(6, 2);
            B.Ignore(B => B.Duration);
        }
    }
}