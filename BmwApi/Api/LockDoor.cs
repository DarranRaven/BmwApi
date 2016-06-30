using System.Collections.Generic;

namespace BmwApi.Core.Api
{
    internal class LockDoor : ActionBase
    {
        internal override Dictionary<string, string> PostData
        {
            get { return new Dictionary<string, string> { { Constants.ActionServiceType, Constants.LockDoors } }; }
        }
    }
}
