using System;
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
                    return profile;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        internal static bool SaveProfile(Profile profile, string fileName)
        {
            try
            {
                File.WriteAllText(fileName, JsonConvert.SerializeObject(profile, Formatting.Indented));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
