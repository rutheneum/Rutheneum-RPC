using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutheneum.Helper
{
    public class BalanceViewModel
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("balance")]
        public decimal Balance { get; set; }

        [JsonProperty("finalbalance")]
        public decimal FinalBalance { get; set; }        

        [JsonProperty("n_tx")]
        public int TotalTransactions { get; set; }
    }
}
