using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test1.Enum.TransactionStatus;
using test1.Infrastructure.EF.Mapping;
using test1.Models.Transactions;

namespace test1.Infrastructure.EF.Seeding
{
    public class SeedTransaction
    {
        public static void Seed(AssignmentDB context)
        {
            var customer1 = context.Customers.First();
            var customer2 = context.Customers.Last();

            var transaction1C1 = new Transaction()
            {
                CurrencyCode = "USD",
                Amount = 39.75,
                TransactionStatus = TransactionStatus.Success,
                DateTime = new DateTime(2016, 7, 15, 3, 15, 0),
                CustomerID = customer1.CustomerID
            };
            var transaction2C1 = new Transaction()
            {
                CurrencyCode = "THB",
                Amount = 105,
                TransactionStatus = TransactionStatus.Failed,
                DateTime = new DateTime(2016, 7, 15, 11, 15, 0),
                CustomerID = customer1.CustomerID
            };
            var transaction3C1 = new Transaction()
            {
                CurrencyCode = "EUR",
                Amount = 789.1,
                TransactionStatus = TransactionStatus.Canceled,
                DateTime = new DateTime(2016, 7, 15, 15, 15, 0),
                CustomerID = customer1.CustomerID
            };

            context.Add(transaction1C1);
            context.Add(transaction2C1);
            context.Add(transaction3C1);

            var transaction1C2 = new Transaction()
            {
                CurrencyCode = "GBP",
                Amount = 31239.75,
                TransactionStatus = TransactionStatus.Success,
                DateTime = new DateTime(2018, 7, 15, 15, 15, 0),
                CustomerID = customer2.CustomerID
            };
            var transaction2C2 = new Transaction()
            {
                CurrencyCode = "CNY",
                Amount = 3239.5,
                TransactionStatus = TransactionStatus.Failed,
                DateTime = new DateTime(2018, 7, 15, 15, 20, 0),
                CustomerID = customer2.CustomerID
            };
            var transaction3C2 = new Transaction()
            {
                CurrencyCode = "JYP",
                Amount = 12313,
                TransactionStatus = TransactionStatus.Canceled,
                DateTime = new DateTime(2018, 7, 15, 15, 55, 0),
                CustomerID = customer2.CustomerID
            };

            context.Add(transaction1C2);
            context.Add(transaction2C2);
            context.Add(transaction3C2);

            context.SaveChanges();
        }
    }
}
