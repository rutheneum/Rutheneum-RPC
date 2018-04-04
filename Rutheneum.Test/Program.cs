using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rutheneum.Helper;
using Rutheneum;

namespace Rutheneum.Test
{
    class Program
    {
        private static void Main(string[] args)
        {
            var a = new Rutheneum();
            var address = "";
            //Generate Address
            //var address = a.GenerateAddress().Result;

            //Wallet Address Balance
            //var balance = a.GetBalanceForAddress(address).Result;

            //Address Transaction History
            //var transaction = a.GetAddressTransactions(address).Result;

            //Transaction Detail
            var hash = "";
            //var transaction = a.GetTransactions(hash).Result;            

            //Create Transaction
            var fromAddress = "";
            var toAddress = "";
            var fromPrivate = "";
            var fromPublic = "";
            var value = 1;
            var createTransaction = a.Send(fromAddress, toAddress, fromPrivate, fromPublic, value);
            Console.WriteLine(createTransaction);
            Console.ReadKey();
        }
    }
}
