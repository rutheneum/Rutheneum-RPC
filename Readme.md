# Rutheneum.NET 

The purpose of this code is primarily for signing transactions, and while the
code can do a bit more than what is shown here, at this stage, it may change
without warning. Only the Transaction signing api shown below has any
guarantees. While this is currently a low priority project, feel free to register
your interest at support@rutheneum.com

## Requirements

* Visual Studio 2015 or equivalent compiler with c#6 support
* .NET framework 4.5.0+

## Generate Address

```c#

// using Rutheneum;

var address = a.GenerateAddress();
Console.WriteLine(address.Address);
Console.WriteLine(address.PrivateKey);
Console.WriteLine(address.publicKey);
Console.WriteLine(address.Wif);

```

## Balance

```c#

// using Rutheneum;
var address=""
var balance = a.GetBalanceForAddress(address);
Console.WriteLine(balance);

```

## Transaction History

```c#

// using Rutheneum;
var address=""
var transaction = a.GetAddressTransactions(address);

```

## Create Transaction

```c#

// using Rutheneum
// using Newtonsoft.Json.Linq;

var fromAddress = "";
var toAddress = "";
var fromPrivate = "";
var fromPublic = "";
var value = "";
var createTransaction = a.Send(fromAddress, toAddress, fromPrivate, fromPublic, value);
Console.WriteLine(createTransaction);
Console.ReadKey();

```
