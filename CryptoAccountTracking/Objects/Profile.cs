using System.Collections.Generic;

namespace CryptoAccountTracking.Objects
{
    /// <summary>
    /// A profile contains all the information for a single portfolio
    /// </summary>
    internal class Profile
    {
        /// <summary>
        /// Name of the profile
        /// </summary>
        internal string Name { get; set; }

        /// <summary>
        /// All of the accounts held by the profile
        /// </summary>
        internal List<Account> Accounts { get; set; } = new List<Account>();

        internal List<Transaction> Transactions { get; set; } = new List<Transaction>();

        //internal List<Currency> Currencies { get; set; } = new List<Currency>();
    }
}
