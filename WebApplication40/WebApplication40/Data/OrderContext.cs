using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication40.Models;

namespace WebApplication40.Data
{
    public class OrderContext: DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Product>().ToTable("Product");

        }


    }
}
