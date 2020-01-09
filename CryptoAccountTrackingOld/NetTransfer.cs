using System;

namespace CryptoAccountTracking
{
    public class NetTransfer
    {
        public NetTransfer()
        {

        }

        public NetTransfer(NetTransfer other)
        {
            TransactionHash = other.TransactionHash;
            Date = other.Date;
            From = other.From;
            To = other.To;
            Amount = other.Amount;
            Fee = other.Fee;
        }

        public string TransactionHash { get; set; }

        public DateTime Date { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public decimal Amount { get; set; }

        public decimal Fee { get; set; }
    }
}
