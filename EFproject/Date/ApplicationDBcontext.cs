using EFproject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFproject.Date
{
    internal class ApplicationDBcontext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
       public DbSet <Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-7D13UVG2;Initial Catalog=EfProject;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;");
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .HasColumnType("varchar(100)");
        }
        
       */

        /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
              base.OnModelCreating(modelBuilder);
              modelBuilder.Entity<Employee>()
                  .Property(e => e.Name)
                  .HasMaxLength(100)
                  .IsUnicode(false);
          }
        */
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()

                .Property(e => e.Name)
                .HasColumnType("varchar")
                .HasMaxLength(100);
        }
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()

                .ToTable("Customers");
                }
    }
}
