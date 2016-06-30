using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmwApi.Core.Model
{
    public class ApiTimer
    {
        public string departureTime { get; set; }
        public bool timerEnabled { get; set; }
        public List<string> weekdays { get; set; }
    }
}
