using System;

namespace CryptoAccountTracking.Forms
{
    /// <summary>
    /// Represents the holdings of a single currency for a single address at a point in time
    /// </summary>
    class CurrencyHolding
    {
        /// <summary>
        /// The address of the holdings
        /// </summary>
        internal string Address { get; set; }

        /// <summary>
        /// The date of the holdings
        /// </summary>
        internal DateTime Date { get; set; }

        /// <summary>
        /// The currency code
        /// </summary>
        internal string Code { get; set; }

        /// <summary>
        /// Total holdings of the currency at the date
        /// </summary>
        internal decimal Holdings { get; set; }
    }
}
