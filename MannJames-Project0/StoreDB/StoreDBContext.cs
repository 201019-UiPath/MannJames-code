using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Models;

namespace StoreDB
{
    class StoreDBContext : DbContext
    {
        public StoreDBContext()
        {
        }

        public StoreDBContext(
            DbContextOptions<StoreDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CardPayment> CardPayment { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerLogin> CustomerLogin { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeLogin> EmployeeLogin { get; set; }
        public virtual DbSet<InvProduct> InvProducts { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrdProduct> OrdProduct { get; set; }

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
            modelBuilder.Entity<CardPayment>(entity =>
            {
                entity.Property(e => e.CardNumber)
                    .HasMaxLength(15);
                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10);
                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(10);
                entity.Property(e => e.City)
                     .HasMaxLength(20);
                entity.Property(e => e.State)
                    .HasMaxLength(20);
                entity.Property(e => e.ZipCode)
                    .HasMaxLength(5);
                entity.Property(e => e.CVV)
                    .HasMaxLength(4);

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

            modelBuilder.Entity<CustomerLogin>(entity =>
            {
                entity.Property(e => e.Username)
                    .HasMaxLength(10);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10);

                entity.Property(e => e.Password)
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<EmployeeLogin>(entity =>
            {
                entity.Property(e => e.Username)
                    .HasMaxLength(10);
                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(10);
                entity.Property(e => e.Role)
                    .HasMaxLength(10);
                entity.Property(e => e.Password)
                    .HasMaxLength(15);
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
                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10);
                entity.Property(e => e.LocationId)
                    .HasMaxLength(10);
                entity.Property(e => e.OrderId)
                    .HasMaxLength(10);
            });
        }
    }
}
