using BmwApi.Core.Api;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmwApi.Core.Account
{
    internal static class AccountSettings
    {
        public static Lazy<string> Username = new Lazy<string>(() => ApiSettings.Default.Username);
        public static Lazy<string> Password = new Lazy<string>(() => ApiSettings.Default.Password);
        public static Lazy<string> AuthenticationKey = new Lazy<string>(() => ApiSettings.Default.AuthenticationKey);
        public static Lazy<string> Vin = new Lazy<string>(() => new Vehicles().CurrentVehicles.First().Vin);
        public static Lazy<string> BearerToken = new Lazy<string>(() => new UserAccount().Token);
    }
}
