using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutheneum.Helper
{

    public class TransactionResponse
    {
        public string message { get; set; }
        public string status { get; set; }
        public TransactionViewModel Data { get; set; }
    }

    public class TransactionViewModel
    {
        [JsonProperty("block_height")]
        public string Block_Height { get; set; }

        [JsonProperty("block_hash")]
        public string Block_Hash { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("totalinput")]
        public Nullable<decimal> TotalInput { get; set; }

        [JsonProperty("totaloutput")]
        public Nullable<decimal> TotalOutput { get; set; }

        [JsonProperty("fees")]
        public Nullable<decimal> Fees { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("confirmed")]
        public string Confirmed { get; set; }

        [JsonProperty("received")]
        public string Received { get; set; }

        [JsonProperty("confirmation")]
        public string Confirmation { get; set; }

        [JsonProperty("transaction_date")]
        public Nullable<DateTime> TransactionDate { get; set; }

        [JsonProperty("amount")]
        public Nullable<Decimal> Amount { get; set; }

        [JsonProperty("inputs")]
        public List<Input> Inputs { get; set; }

        [JsonProperty("outputs")]
        public List<OutPut> OutPuts { get; set; }
    }
}
