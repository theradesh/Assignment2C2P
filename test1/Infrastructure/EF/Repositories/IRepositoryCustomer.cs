using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test1.Models.Customers;

namespace test1.Infrastructure.EF.Repositories
{
    public interface IRepositoryCustomer
    {
        Task<Customer> GetById(int id);
        Task<Customer> GetByEmail(string email);
        Task<Customer> GetByEmailAndId(string email, int id);
    }
}
