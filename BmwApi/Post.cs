using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmwApi.Core
{
    public static class Post
    {
        public static void LockDoors() => new Api.LockDoor();
        public static void UnlockDoors() => new Api.UnlockDoor();
        public static void EnableOffPeakCharging() => new Api.EnableOffPeakCharging();
        public static void DisableOffPeakCharging() => new Api.DisableOffPeakCharging();
    }
}
