using Microsoft.EntityFrameworkCore;
using OnSale.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>()
                .HasIndex(t => t.Name)
                .IsUnique();
        
      
          base.OnModelCreating(modelBuilder);

              modelBuilder.Entity<Country>()
                  .HasIndex(t => t.Name)
                  .IsUnique();

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>()
                .HasIndex(t => t.Name)
                .IsUnique();

        }
      } 

    }
