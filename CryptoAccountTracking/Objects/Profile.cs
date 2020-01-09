using System.Collections.Generic;

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
    }
}
