using Study4.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study4
{
    
    class TimeMessage
    {
        ITimeService timeService;
        public TimeMessage(ITimeService timeService)
        {
            this.timeService = timeService;
        }
        //public string GetTime() => $"Time: {timeService.GetTime()}";
        public string GetTime()
        {
            string result = string.Empty;
            result = $"Time: {timeService.GetTime()}";
            return result;

        }
    }
}
