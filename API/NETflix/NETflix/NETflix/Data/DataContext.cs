using Microsoft.EntityFrameworkCore;
using NETflix.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETflix.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.UserName).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<User>()
                .Property(u => u.Password).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Movie>()
                .Property(m => m.MovieName).IsRequired().HasMaxLength(35);

            base.OnModelCreating(modelBuilder);
        }
    }
}
