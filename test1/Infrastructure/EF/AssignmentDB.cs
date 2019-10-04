using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test1.Infrastructure.EF.Mapping;
using test1.Models.Customers;
using test1.Models.Transactions;

namespace test1.Infrastructure.EF
{
    public class AssignmentDB : DbContext
    {
        public AssignmentDB(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.CustomerMapping();
            modelBuilder.TransactionMapping();
            base.OnModelCreating(modelBuilder);
        }
    }
}
