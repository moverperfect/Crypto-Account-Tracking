using Newtonsoft.Json;

namespace CryptoAccountTracking.Objects
{
    /// <summary>
    /// Details of a single currency that a user could own
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// The ticker for the currency e.g. GBP
        /// </summary>
        public string Ticker { get; set; }

        /// <summary>
        /// The name of the currency e.g. Great British Pounds
        /// </summary>
        public string Name { get; set; }

        [JsonIgnore] public decimal Price { get; set; }
    }
}
