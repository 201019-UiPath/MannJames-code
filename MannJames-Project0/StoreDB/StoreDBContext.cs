using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Models;

namespace StoreDB
{
    public class StoreDBContext : DbContext
    {
        private readonly ILoggerFactory loggerFactory;

        public StoreDBContext()
        {
        }
        public StoreDBContext(
            DbContextOptions<StoreDBContext> options, ILoggerFactory loggerFactory)
            : base(options)
        {
            this.loggerFactory = loggerFactory;
        }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<InvProduct> InvProducts { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrdProduct> OrdProduct { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }

        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration
                    .GetConnectionString("StoreDB");
                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manager>(entity =>
            {
                entity.Property(e => e.ManagerId)
                    .HasMaxLength(10);
                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10);
                entity.Property(e => e.FirstName)
                    .HasMaxLength(15);
                entity.Property(e => e.LastName)
                    .HasMaxLength(15);
                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10);

            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(10);
                entity.Property(e => e.FirstName)
                    .HasMaxLength(15);
                entity.Property(e => e.LastName)
                    .HasMaxLength(15);
                entity.Property(e => e.LocationId)
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<InvProduct>(entity =>
            {
                entity.Property(e => e.IProductId)
                    .HasMaxLength(10);
                entity.Property(e => e.IProductName)
                    .HasMaxLength(15);
                entity.Property(e => e.LocationId)
                    .HasMaxLength(10);
                entity.Property(e => e.Quantity);
            });

            modelBuilder.Entity<OrdProduct>(entity =>
            {
                entity.Property(e => e.OProductId)
                    .HasMaxLength(10);
                entity.Property(e => e.OProductName) 
                    .HasMaxLength(15);
                entity.Property(e => e.OrderId)
                    .HasMaxLength(10);
                entity.Property(e => e.Quantity);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.LocationId)
                    .HasMaxLength(10);
                entity.Property(e => e.Address)
                    .HasMaxLength(25);
                entity.Property(e => e.City)
                    .HasMaxLength(20);
                entity.Property(e => e.State)
                    .HasMaxLength(20);
                entity.Property(e => e.ZipCode)
                    .HasMaxLength(5);
                entity.Property(e => e.Hours)
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId)
                    .HasMaxLength(10);
                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10);
                entity.Property(e => e.LocationId)
                    .HasMaxLength(10);
                entity.Property(e => e.OrderDate)
                    .HasMaxLength(20);
            });
        }
    }
}
