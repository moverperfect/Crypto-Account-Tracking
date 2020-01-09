using System;
using System.Collections.Generic;

namespace CryptoAccountTracking
{
    internal class NetAddress
    {
        public string AddressName { get; set; }

        public NetCurrency Currency { get; set; }

        public string Address { get; set; }

        public List<NetTransfer> Transfers { get; set; } = new List<NetTransfer>();

        public List<NetTrade> Trades { get; set; } = new List<NetTrade>();

        public decimal HoldingsAtDate(DateTime date)
        {
            decimal holdings = 0;

            var transactions = Transfers.FindAll(t => t.Date <= date);

            foreach (var transaction in transactions)
            {
                if (transaction.To == AddressName)
                {
                    holdings += transaction.Amount;
                }
                else
                {
                    holdings -= (transaction.Amount + transaction.Fee);
                }
            }
            return holdings;
        }

        /// <summary>
        /// Custom Bubble sort that loops backwards
        /// </summary>
        public void SortTransactions()
        {
            /*
             * The Bubble sort is used and written this way because the chances are
             * that most of the time the new transaction at the end of the list will
             * be the only one that isn't sorted.
             * */

            var n = Transfers.Count;

            for (var i = 0;i < n; i++)
            {
                var changed = false;

                for (var y = n - 1; y >=0; y--)
                {
                    if (Transfers[y].Date > Transfers[y - 1].Date) continue;
                    var temp = new NetTransfer(Transfers[y]);
                    Transfers[y] = new NetTransfer(Transfers[y - 1]);
                    Transfers[y - 1] = temp;
                    changed = true;
                }

                if (!changed)
                {
                    return;
                }
            }
        }
    }
}
