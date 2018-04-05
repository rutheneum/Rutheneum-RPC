using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rutheneum.Helper;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Diagnostics;
using Newtonsoft.Json;

namespace Rutheneum
{
    public class Rutheneum
    {
        public string BaseUrl = "http://api.rutheneum.com";
        public bool EnsureSuccessStatusCode { get; set; }
        public int ThrottleRequests { get; set; }

        //Generate RTH address
        public Task<AddressViewModel> GenerateAddress()
        {
            return PostAsync<AddressViewModel>("api/v1/addrs", null);
        }

        //Get Balance for Address
        public Task<string> GetBalanceForAddress(string address)
        {
            return GetAsync<string>(string.Format("balance/{0}", address));
        }

        //Get Transactoin for Address
        public Task<AddressBalanceResponse> GetAddressTransactions(string address)
        {            
            return GetAsync<AddressBalanceResponse>(string.Format("/api/address/{0}", address));
        }

        //Get Transaction Detail
        public Task<TransactionResponse> GetTransactions(string tx)
        {
            return GetAsync<TransactionResponse>(string.Format("/api/tx/{0}", tx));
        }

        //Send RTH to other Address
        public async Task<CreateTransactionResponse> Send(string fromAddress, string toAddress, string fromPrivate,
                                                    string fromPublic, decimal amount)
        {
            CreateTransactionRequest create = new CreateTransactionRequest();
            create.fromAddress = fromAddress;
            create.toAddress = toAddress;
            create.fromPrivate = fromPrivate;
            create.fromPublic = fromPublic;
            create.toAddress = toAddress;
            create.value = amount;
            var transaction = await PostAsync<CreateTransactionResponse>("/api/v1/txs/create", create);

            return transaction;
        }

        #region Helpers
        internal async Task<T> GetAsync<T>(string url)
        {
            var client = GetClient();

            var response = await client.GetAsync(string.Format("{0}/{1}", BaseUrl, url));

            if (EnsureSuccessStatusCode)
                response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            if (ThrottleRequests > 0)
                await Task.Delay(ThrottleRequests);

            return content.FromJson<T>();
        }

        internal HttpClient GetClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        public static bool EnableLogging = true;
        public string LastResponse;

        internal async Task<T> PostAsync<T>(string url, object obj) where T : new()
        {
            var client = GetClient();

            string targetUrl = string.Format("{0}/{1}", BaseUrl, url);
            string requestJson = (obj ?? new object()).ToJson();
            if (EnableLogging)
                Debug.WriteLine("Rutheneum Request -> {0}\n{1}", targetUrl, requestJson);

            var response =
                await client.PostAsync(targetUrl, new StringContent(requestJson, Encoding.UTF8, "application/json"));
            string content = await response.Content.ReadAsStringAsync();
            LastResponse = content;
            if (EnableLogging)
                Debug.WriteLine("Rutheneum Response:\n{0}", content);

            if (EnsureSuccessStatusCode)
                response.EnsureSuccessStatusCode();

            if (ThrottleRequests > 0)
                await Task.Delay(ThrottleRequests);

            return content.FromJson<T>();
        }
        #endregion
    }
}
