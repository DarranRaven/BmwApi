using System;
using System.Linq;

namespace BmwApiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var tz = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            var newDate = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.Utc, tz);

            var completionTime = newDate.AddMinutes(BmwApi.Core.Get.Status.ChargingTimeRemaining);
            Console.WriteLine(completionTime.ToShortTimeString());
            Console.ReadLine();
        }
    }
}
