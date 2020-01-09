namespace CryptoAccountTracking.Objects
{
    /// <summary>
    /// Defines an account under the control of the user
    /// </summary>
    public class Account
    {
        /// <summary>
        /// The address of the account that is used for referencing
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The name of the account to be used for the user to give a purpose or location
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Notes for the account
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Default currency code for the account
        /// </summary>
        public string DefaultCurrency { get; set; }
    }
}
