using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using test1.Models.Customers;

namespace test1.Infrastructure.EF.Mapping
{
    public static class MapCustomer
    {
        public static ModelBuilder CustomerMapping(this ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Customer>();
            entity.ToTable("Customers");
            entity.Property(c => c.CustomerID).ValueGeneratedOnAdd().HasMaxLength(10);
            entity.Property(c => c.Name).HasMaxLength(30);
            entity.Property(c => c.Email).HasMaxLength(25);
            entity.Property(c => c.MobileNumber).HasMaxLength(10);
            entity.HasMany(c => c.Transactions).WithOne(c => c.Customer).HasForeignKey(c => c.CustomerID);
            return modelBuilder;
        }
    }
}
