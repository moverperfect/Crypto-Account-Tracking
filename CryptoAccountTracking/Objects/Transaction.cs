using System;
using Newtonsoft.Json;

namespace CryptoAccountTracking.Objects
{
    /// <summary>
    /// A single transaction between one address and another. Trades between currencies are transactions
    /// </summary>
    public class Transaction
    {
        internal Transaction()
        {

        }

        internal Transaction(Transaction transaction)
        {
            Hash = transaction.Hash;
            Date = transaction.Date;
            From = transaction.From;
            FromCurrency = transaction.FromCurrency;
            FromAmount = transaction.FromAmount;
            To = transaction.To;
            ToCurrency = transaction.ToCurrency;
            ToAmount = transaction.ToAmount;
            FeeCurrency = transaction.FeeCurrency;
            FeeAmount = transaction.FeeAmount;
        }

        /// <summary>
        /// Hash reference for the transaction
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// Date of the transaction
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The address of the account that originated the transaction
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// The currency code for the currency that the transaction started in
        /// </summary>
        public string FromCurrency { get; set; }

        /// <summary>
        /// The amount of currency that the transaction started in
        /// </summary>
        public decimal FromAmount { get; set; }

        /// <summary>
        /// The address that the transaction was directed at
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// The currency code for the currency that the transaction finished in
        /// </summary>
        public string ToCurrency { get; set; }

        /// <summary>
        /// The amount of currency that the transaction finished in
        /// </summary>
        public decimal ToAmount { get; set; }

        /// <summary>
        /// The currency code for the currency that the fee was taken in
        /// </summary>
        public string FeeCurrency { get; set; }

        /// <summary>
        /// The amount of fee that was taken
        /// </summary>
        public decimal FeeAmount { get; set; }

        /// <summary>
        /// The rate between the from and to amounts
        /// </summary>
        [JsonIgnore]
        public decimal Rate => FromAmount / ToAmount;
    }
}
