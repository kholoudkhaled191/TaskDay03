using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configurationsclass
{
    internal class BookConfigurations : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");
            builder.HasKey(b => b.id);
            builder.Property(b => b.id)
                .UseIdentityColumn(1, 1);


            builder.Property(b => b.Title)
                .IsRequired(true)
                .HasMaxLength(150);


            builder.Property(b => b.Price)
                .HasColumnType("decimal(8,2)");


            builder.Property(b => b.PublishedDate)
                .IsRequired(false);


        }
    }
}
