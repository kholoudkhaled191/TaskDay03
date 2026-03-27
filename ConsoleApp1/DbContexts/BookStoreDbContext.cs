using ConsoleApp1.Configurationsclass;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DbContexts
{
    internal class BookStoreDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=BookStoreDB;trusted_connection=true;");
        }


        //  public DbSet<Book> Books 

        public DbSet<Book> Books  { get; set; }

        public DbSet<Author> Authors { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfigurations());
        }

    }
}
