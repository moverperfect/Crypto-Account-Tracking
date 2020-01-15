using System;
using System.Collections.Generic;
using System.Linq;
using CryptoAccountTracking.Forms;

namespace CryptoAccountTracking.Objects
{
    /// <summary>
    /// Defines an account under the control of the user
    /// </summary>
    public class Account
    {
        /// <summary>
        /// The address of the account that is used for referencing
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The name of the account to be used for the user to give a purpose or location
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Notes for the account
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Default currency code for the account
        /// </summary>
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// Retrieves the holdings for the stated currency code up to the date given
        /// </summary>
        /// <param name="transactions">List of all transactions</param>
        /// <param name="date">The date to get the holdings up to</param>
        /// <param name="currencyCode">The currency code to search for</param>
        /// <returns>The total holdings of the given currency at the date given</returns>
        public decimal SingleCurrencyHoldingsAtDate(List<Transaction> transactions, DateTime date, string currencyCode)
        {
            decimal holdings = 0;

            foreach (var transaction in transactions.Where(transaction => transaction.Date <= date))
            {
                if (transaction.To == Address && transaction.ToCurrency == currencyCode)
                {
                    holdings += transaction.ToAmount;
                }

                if (transaction.From == Address)
                {
                    if (transaction.FromCurrency == currencyCode)
                    {
                        holdings -= transaction.FromAmount;
                    }

                    if (transaction.FeeCurrency == currencyCode)
                    {
                        holdings -= transaction.FeeAmount;
                    }
                }
            }

            return holdings;
        }

        internal List<CurrencyHolding> AllCurrencyHoldingsAtDate(List<Transaction> transactions, DateTime date)
        {
            var holdings = new List<CurrencyHolding>();
            foreach (var transaction in transactions.Where(transaction => transaction.Date <= date))
            {
                if (transaction.To == Address)
                {
                    var currHoldings = holdings.Find(t => t.Code == transaction.ToCurrency);
                    if (currHoldings == null)
                    {
                        holdings.Add(new CurrencyHolding()
                        {
                            Address = Address,
                            Code = transaction.ToCurrency,
                            Date = date,
                            Holdings = transaction.ToAmount
                        });
                    }
                    else
                    {
                        currHoldings.Holdings += transaction.ToAmount;
                    }
                }

                if (transaction.From == Address)
                {
                    var fromHoldings = holdings.Find(t => t.Code == transaction.FromCurrency);
                    if (fromHoldings == null)
                    {
                        holdings.Add(new CurrencyHolding()
                        {
                            Address = Address,
                            Code = transaction.FromCurrency,
                            Date = date,
                            Holdings = -transaction.FromAmount
                        });
                    }
                    else
                    {
                        fromHoldings.Holdings -= transaction.FromAmount;
                    }

                    var feeHoldings = holdings.Find(t => t.Code == transaction.FeeCurrency);
                    if (feeHoldings == null)
                    {
                        holdings.Add(new CurrencyHolding()
                        {
                            Address = Address,
                            Code = transaction.FeeCurrency,
                            Date = date,
                            Holdings = -transaction.FeeAmount
                        });
                    }
                    else
                    {
                        feeHoldings.Holdings -= transaction.FeeAmount;
                    }
                }
            }

            return holdings;
        }
    }
}
