using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test1.Models.Transactions;

namespace test1.Models.Customers
{
    public class CustomerDTO
    {
        public long CustomerID { get; set; } // Numberic max 10 chars
        public string Name { get; set; } // Character max 30 chars
        public string Email { get; set; } //Character max 25 digits
        public string MobileNumber { get; set; } // Numeric only 10 digits
        public List<TransactionDTO> Transactions { get; set; } = new List<TransactionDTO>(); // max 5 records
    }
}
