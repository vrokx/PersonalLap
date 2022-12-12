using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Codefirstapproach.Models
{
    public class ShoppyDataContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; } 
        public DbSet<Role> Role { get; set; }
        
        public DbSet<PreviousOrder> PreviousOrders { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Wallet> Wallet { get; set; }

    }
}