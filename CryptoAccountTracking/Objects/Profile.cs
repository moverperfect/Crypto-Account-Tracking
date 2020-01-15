using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CryptoAccountTracking.Objects
{
    /// <summary>
    /// A profile contains all the information for a single portfolio
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// Name of the profile
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// All of the accounts held by the profile
        /// </summary>
        public List<Account> Accounts { get; set; } = new List<Account>();

        /// <summary>
        /// All of the transactions associated with the user profile
        /// </summary>
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        /// <summary>
        /// All of the currencies that are stored in this profile
        /// </summary>
        public List<Currency> Currencies { get; set; } = new List<Currency>();

        /// <summary>
        /// Sorts the transaction list into date order
        /// </summary>
        public void SortTransactions()
        {
            /*
             * The Bubble sort is used and written this way because the chances are
             * that most of the time the new transaction at the end of the list will
             * be the only one that isn't sorted.
             * */

            var n = Transactions.Count;

            for (var i = 0; i < n; i++)
            {
                var changed = false;

                for (var y = n - 1; y >= 1; y--)
                {
                    if (Transactions[y].Date > Transactions[y - 1].Date) continue;
                    var temp = new Transaction(Transactions[y]);
                    Transactions[y] = new Transaction(Transactions[y - 1]);
                    Transactions[y - 1] = temp;
                    changed = true;
                }

                if (!changed)
                {
                    return;
                }
            }
        }

        public Dictionary<string, decimal> ListAllCurrencyTotals()
        {
            var currencyTotals = Currencies.ToDictionary(currency => currency.Ticker, currency => 0M);

            foreach (var transaction in Transactions)
            {
                if (Accounts.Exists(t => t.Address == transaction.From))
                {
                    currencyTotals[transaction.FromCurrency] -= transaction.FromAmount;
                    currencyTotals[transaction.FeeCurrency] -= transaction.FeeAmount;
                }

                if (Accounts.Exists(t => t.Address == transaction.To))
                {
                    currencyTotals[transaction.ToCurrency] += transaction.ToAmount;
                }
            }

            return currencyTotals;
        }
    }
}
