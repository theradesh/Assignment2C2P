using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test1.Infrastructure.EF.Mapping;
using test1.Models.Customers;

namespace test1.Infrastructure.EF.Seeding
{
    public class SeedCustomer
    {
        public static void Seed(AssignmentDB context)
        {
            var customer1 = new Customer()
            {
                Name = "Customer1",
                Email = "customer1@customer.com",
                MobileNumber = "(+66)1150",
            };

            var customer2 = new Customer()
            {
                Name = "Customer2",
                Email = "customer2@customer.com",
                MobileNumber = "(+66)1112",
            };

            context.Add(customer1);
            context.Add(customer2);
            context.SaveChanges();

        }
    }
}
