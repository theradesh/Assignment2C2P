using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test1.Models.Customers;

namespace test1.Infrastructure.EF.Repositories
{
    public class RepositoryCustomer : IRepositoryCustomer
    {
        public AssignmentDB context { get; set; }

        public RepositoryCustomer(AssignmentDB context)
        {
            this.context = context;
        }
        public async Task<Customer> GetByEmail(string email)
        {
            return await context.Customers
                .Include(x => x.Transactions)
                .SingleOrDefaultAsync(x => x.Email == email);
        }

        public async Task<Customer> GetByEmailAndId(string email, int id)
        {
            return await context.Customers
                .Include(x => x.Transactions)
                .SingleOrDefaultAsync(x => x.Email == email && x.CustomerID == id);
        }

        public async Task<Customer> GetById(int id)
        {
            return await context.Customers
                .SingleOrDefaultAsync(x => x.CustomerID == id);
        }
    }
}
