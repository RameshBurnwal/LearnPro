using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RameshWorkBook.DAL.Entity;

namespace RameshWorkBook.DAL.DBContext
{
    public class WorkBookDBContext : DbContext
    {
        public WorkBookDBContext(DbContextOptions<WorkBookDBContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
