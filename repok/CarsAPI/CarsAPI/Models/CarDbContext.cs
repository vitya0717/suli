﻿using Microsoft.EntityFrameworkCore;

namespace CarsAPI.Models
{
    public class CarDbContext : DbContext
    {
        protected string conn = "server=10.169.91.114; database=Cars; user=root; password=password";

        public CarDbContext(DbContextOptions options) : base(options)
        {

        }

        public CarDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
            }
        }

        public DbSet<Car> Cares { get; set; } = null!;

    }
}
