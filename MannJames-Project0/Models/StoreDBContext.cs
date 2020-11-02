using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Models
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
                optionsBuilder.UseSqlServer(connectionString);
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
                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<EmployeeLogin>(entity =>
            {
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

            /*
                        modelBuilder.Entity<OrderPizza>(entity =>
                {
                    entity.ToTable("OrderPizza", "Order");

                    entity.HasOne(d => d.Order)
                        .WithMany(p => p.OrderPizza)
                        .HasForeignKey(d => d.OrderId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_OrderPizza_OrderId");

                    entity.HasOne(d => d.Pizza)
                        .WithMany(p => p.OrderPizza)
                        .HasForeignKey(d => d.PizzaId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_OrderPizza_PizzaId");
                });
            */

        }
    }
}
