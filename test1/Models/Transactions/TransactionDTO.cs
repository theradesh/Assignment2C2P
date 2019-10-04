using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test1.Enum.TransactionStatus;

namespace test1.Models.Transactions
{
    public class TransactionDTO
    {
        public long TransactionID { get; set; } // Numeric dont have max limit
        public DateTime DateTime { get; set; } // DD/MM/YY HH:MM e.g. 31/02/2018 21:34
        public double Amount { get; set; } // 2 decimal points
        public string CurrencyCode { get; set; } // have only 3 characters
        public TransactionStatus TransactionStatus { get; set; } // have 3 formats
        // public long CustomerID { get; set; }
        // public Customer Customer { get; set; }
    }
}
