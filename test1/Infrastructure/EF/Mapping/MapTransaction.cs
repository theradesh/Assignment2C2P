using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test1.Models.Transactions;

namespace test1.Infrastructure.EF.Mapping
{
    public static class MapTransaction
    {
        public static ModelBuilder TransactionMapping(this ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Transaction>();
            entity.ToTable("Transactions");
            entity.Property(c => c.TransactionID).ValueGeneratedOnAdd();
            return modelBuilder;
        }
    }
}
