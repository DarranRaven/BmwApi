using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmwApi.Core.Model
{
    public class ApiChargingWindow
    {
        public bool enabled { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
    }
}
