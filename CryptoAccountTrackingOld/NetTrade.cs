namespace CryptoAccountTracking
{
    public class NetTrade : NetTransfer
    {
        public string ToCurrency { get; set; }

        public string FromCurrency { get; set; }

        public decimal FromAmount { get; set; }

        public decimal Rate => Amount / FromAmount;
    }
}
