using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutheneum.Helper
{
    public class CreateTransactionRequest
    {
        [JsonProperty("fromAddress")]
        public string fromAddress { get; set; }
        [JsonProperty("toAddress")]
        public string toAddress { get; set; }
        [JsonProperty("fromPrivate")]
        public string fromPrivate { get; set; }
        [JsonProperty("fromPublic")]
        public string fromPublic { get; set; }
        [JsonProperty("value")]
        public decimal value { get; set; }
    }

    public class CreateTransactionResponse
    {
        public string message { get; set; }
        public string status { get; set; }
        public TransactionViewModel Data { get; set; }
    }
}
