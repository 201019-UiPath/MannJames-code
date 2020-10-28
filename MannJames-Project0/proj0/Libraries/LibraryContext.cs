using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libraries
{
    public class LibraryContext: DbContext
    {
        public DbSet<CardPayment> Card { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<InvProduct> InvProject { get; set; }
        public DbSet<OrdProduct> OrdProject { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Order> Order { get; set; }

    }
}
