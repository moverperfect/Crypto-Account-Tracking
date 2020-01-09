namespace CryptoAccountTracking.Objects
{
    /// <summary>
    /// Defines an account under the control of the user
    /// </summary>
    internal class Account
    {
        /// <summary>
        /// The address of the account that is used for referencing
        /// </summary>
        internal string Address { get; set; }

        /// <summary>
        /// The name of the account to be used for the user to give a purpose or location
        /// </summary>
        internal string Name { get; set; }

        /// <summary>
        /// Notes for the account
        /// </summary>
        internal string Notes { get; set; }
    }
}
