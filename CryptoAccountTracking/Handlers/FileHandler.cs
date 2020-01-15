using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CryptoAccountTracking.Objects;
using Newtonsoft.Json;

namespace CryptoAccountTracking.Handlers
{
    internal static class FileHandler
    {
        internal static Profile LoadProfile(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    var profile = JsonConvert.DeserializeObject<Profile>(File.ReadAllText(fileName));
                    profile.SortTransactions();
                    return profile;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
            }

            return null;
        }

        internal static bool SaveProfile(Profile profile, string fileName)
        {
            try
            {
                profile.SortTransactions();
                File.WriteAllText(fileName, JsonConvert.SerializeObject(profile, Formatting.Indented));
                return true;
            }
            catch (Exception e)
            {
            }

            return false;
        }

        public static List<Transaction> BitfinexImport(string filename)
        {
            try
            {
                var transactions = new List<Transaction>();

                var lines = File.ReadAllLines(filename);

                if (lines[0] != "#,PAIR,AMOUNT,PRICE,FEE,FEE CURRENCY,DATE,ORDER ID") return null;

                for (var i = 1; i < lines.Length; i++)
                {
                    var line = lines[i].Split(',');

                    var tempTran = new Transaction()
                    {
                        Date = DateTime.ParseExact(line[6], "dd-MM-y H:mm:ss.fff", CultureInfo.InvariantCulture),
                        FeeAmount = Math.Abs(Convert.ToDecimal(line[4])),
                        FeeCurrency = line[5],
                        Hash = line[7]
                    };

                    var price = Convert.ToDecimal(line[3]);
                    var pair = line[1].Split('/');
                    var amount = Convert.ToDecimal(line[2]);

                    if (amount >= 0)
                    {
                        tempTran.FromAmount = Math.Round(Math.Abs(price * amount), 8);
                        tempTran.FromCurrency = pair[1];

                        tempTran.ToAmount = Math.Abs(amount);
                        tempTran.ToCurrency = pair[0];
                    }
                    else
                    {
                        tempTran.FromAmount = Math.Abs(amount);
                        tempTran.FromCurrency = pair[0];

                        tempTran.ToAmount = Math.Round(Math.Abs(price * amount), 8);
                        tempTran.ToCurrency = pair[1];
                    }

                    transactions.Add(tempTran);
                }

                return transactions;
            }
            catch (Exception e)
            {
                // TODO Proper error handling
                return null;
            }
        }

        public static List<Transaction> GdaxImport(string filename)
        {
            try
            {
                var transactions = new List<Transaction>();

                var lines = File.ReadAllLines(filename);

                if (lines[0] != "portfolio,trade id,product,side,created at,size,size unit,price,fee,total,price/fee/total unit") return null;

                for (var i = 1; i < lines.Length; i++)
                {
                    var line = lines[i].Split(',');

                    var tempTran = new Transaction()
                    {
                        Date = DateTime.Parse(line[4]),
                        FeeAmount = Math.Abs(Convert.ToDecimal(line[8])),
                        FeeCurrency = line[10],
                        Hash = line[1]
                    };

                    //var price = Convert.ToDecimal(line[3]);
                    //var pair = line[1].Split('/');
                    //var amount = Convert.ToDecimal(line[2]);

                    if (line[3] == "BUY")
                    {
                        tempTran.FromAmount = Math.Abs(Convert.ToDecimal(line[9])) - Convert.ToDecimal(line[8]);
                        tempTran.FromCurrency = line[10];

                        tempTran.ToAmount = Math.Abs(Convert.ToDecimal(line[5]));
                        tempTran.ToCurrency = line[6];
                    }
                    else
                    {
                        tempTran.FromAmount = Math.Abs(Convert.ToDecimal(line[5]));
                        tempTran.FromCurrency = line[6];

                        tempTran.ToAmount = Math.Abs(Convert.ToDecimal(line[9])) + Convert.ToDecimal(line[8]);
                        tempTran.ToCurrency = line[10];
                    }

                    transactions.Add(tempTran);
                }

                return transactions;
            }
            catch (Exception e)
            {
                // TODO Proper error handling
                return null;
            }
        }
    }
}
