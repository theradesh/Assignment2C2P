using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test1.Models.Transactions;

namespace test1.Models.Customers
{
    public class Customer
    {
        public long CustomerID { get; set; } // Numberic max 10 chars
        public string Name { get; set; } // Character max 30 chars
        public string Email { get; set; } //Character max 25 digits
        public string MobileNumber { get; set; } // Numeric only 10 digits
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>(); // max 5 records


        public CustomerDTO CustomerToDTO()
        {
            var transactions = new List<TransactionDTO>();
            foreach (var t in this.Transactions)
            {
                var dto = Transaction.TransactionToDTO(t);
                transactions.Add(dto);
            }

            return new CustomerDTO()
            {
                CustomerID = this.CustomerID,
                Name = this.Name,
                MobileNumber = this.MobileNumber,
                Email = this.Email,
                Transactions = transactions
            };
        }
    }
}

