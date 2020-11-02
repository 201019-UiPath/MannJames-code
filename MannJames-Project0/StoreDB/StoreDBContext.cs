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
                //entity.ToTable("CardPayment", "Customer");

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.BillingAddress)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.City)
                     .IsRequired()
                     .HasMaxLength(20);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CVV)
                    .IsRequired()
                    .HasMaxLength(4);

            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(10);

            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.LocationId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(l => l.Location)
                    .WithMany(m => m.Employees)
                    .HasForeignKey(l => l.LocationId);

            });

            modelBuilder.Entity<CustomerLogin>(entity =>
            {
                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<EmployeeLogin>(entity =>
            {
                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<InvProduct>(entity =>
            {
                entity.Property(e => e.IProductId)
                    .IsRequired()
                    .HasMaxLength(10);
                entity.Property(e => e.IProductName)
                    .IsRequired()
                    .HasMaxLength(15);
                entity.Property(e => e.LocationId)
                    .IsRequired()
                    .HasMaxLength(10);
                entity.Property(e => e.Quantity);
            });

            modelBuilder.Entity<OrdProduct>(entity =>
            {
                entity.Property(e => e.OProductId)
                    .IsRequired()
                    .HasMaxLength(10);
                entity.Property(e => e.OProductName)
                    .IsRequired()
                    .HasMaxLength(15);
                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(10);
                entity.Property(e => e.Quantity);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.LocationId)
                     .IsRequired()
                    .HasMaxLength(10);
                entity.Property(e => e.Address)
                     .IsRequired()
                    .HasMaxLength(25);
                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(20);
                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20);
                entity.Property(e => e.ZipCode)
                     .IsRequired()
                    .HasMaxLength(5);
                entity.Property(e => e.Hours)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(10);
                entity.Property(e => e.LocationId)
                    .IsRequired()
                    .HasMaxLength(10);
                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(10);
            });
        }
    }
}
