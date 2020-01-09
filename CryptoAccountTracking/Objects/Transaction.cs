using System;

namespace CryptoAccountTracking.Objects
{
    /// <summary>
    /// A single transaction between one address and another. Trades between currencies are transactions
    /// </summary>
    internal class Transaction
    {
        /// <summary>
        /// Hash reference for the transaction
        /// </summary>
        internal string Hash { get; set; }

        /// <summary>
        /// Date of the transaction
        /// </summary>
        internal DateTime Date { get; set; }

        /// <summary>
        /// The address of the account that originated the transaction
        /// </summary>
        internal string From { get; set; }

        /// <summary>
        /// The currency code for the currency that the transaction started in
        /// </summary>
        internal string FromCurrency { get; set; }

        /// <summary>
        /// The amount of currency that the transaction started in
        /// </summary>
        internal decimal FromAmount { get; set; }

        /// <summary>
        /// The address that the transaction was directed at
        /// </summary>
        internal string To { get; set; }

        /// <summary>
        /// The currency code for the currency that the transaction finished in
        /// </summary>
        internal string ToCurrency { get; set; }

        /// <summary>
        /// The amount of currency that the transaction finished in
        /// </summary>
        internal decimal ToAmount { get; set; }

        /// <summary>
        /// The currency code for the currency that the fee was taken in
        /// </summary>
        internal string FeeCurrency { get; set; }

        /// <summary>
        /// The amount of fee that was taken
        /// </summary>
        internal decimal FeeAmount { get; set; }
    }
}
