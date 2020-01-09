using System.Collections.Generic;

namespace CryptoAccountTracking
{
    internal class Account
    {
        /// <summary>
        /// Account Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Addresses associated with the Account
        /// </summary>
        public List<NetAddress> Addresses { get; set; } = new List<NetAddress>();

        /// <summary>
        /// Account Notes
        /// </summary>
        public string Notes { get; set; }
    }
}
