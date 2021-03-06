﻿using Microsoft.EntityFrameworkCore;
using UserManagementMicroservice.Entities;

namespace UserManagementMicroservice.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
