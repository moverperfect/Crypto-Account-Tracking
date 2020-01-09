using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CryptoAccountTracking
{
    internal class Profile
    {
        public string ProfileName { get; set; }

        public List<Account> Accounts { get; set; } = new List<Account>();

        [JsonIgnore]
        public List<NetCurrency> Currencies
        {
            get
            {
                {
                    var currencies = new List<NetCurrency>();
                    // Select unique currencies and add to the list
                    foreach (var address in Accounts.SelectMany(account => account.Addresses))
                    {
                        if (currencies.FirstOrDefault(i => i.IsoName == address.Currency.IsoName) != null) continue;
                        currencies.Add(address.Currency);
                    }

                    return currencies;
                }
            }
        }

        [JsonIgnore]
        public List<AccountAddress> AddressList =>
            (from account in Accounts
                from address in account.Addresses
                select new AccountAddress {Account = account, Address = address}).ToList();
    }

    internal class AccountAddress
    {
        internal Account Account { get; set; }

        internal NetAddress Address { get; set; }
    }

}
