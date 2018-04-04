using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Rutheneum.Helper
{
    public class AddressViewModel
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("publicKey")]
        public string publicKey { get; set; }

        [JsonProperty("privateKey")]
        public string PrivateKey { get; set; }

        [JsonProperty("wif")]
        public string Wif { get; set; }
    }
}
