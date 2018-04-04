using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutheneum.Helper
{
    public class AddressBalanceResponse
    {
        public string message { get; set; }
        public string status { get; set; }
        public AddressBalance Data { get; set; }
    }

    public class AddressBalance
    {
        public string Address { get; set; }
        public int TotalTransactions { get; set; }
        public Nullable<Decimal> Reveived { get; set; }
        public Nullable<Decimal> Balance { get; set; }
        public List<AddressTransaction> Transaction { get; set; }
    }

    public class AddressTransaction
    {
        public string Hashcode { get; set; }
        public Nullable<DateTime> TransactionDate { get; set; }
        public Nullable<Decimal> Fees { get; set; }
        public Nullable<Decimal> Value { get; set; }
        public List<Input> Inputs { get; set; }
        public List<OutPut> OutPuts { get; set; }
    }
}
