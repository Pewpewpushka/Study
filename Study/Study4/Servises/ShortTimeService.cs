using Study4.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study4.Servises
{
    class ShortTimeService : ITimeService
    {
        //public string GetTime() => DateTime.Now.ToShortTimeString();
        public string GetTime()
        {

            //throw new Exception();

            string result=string.Empty;
            result= DateTime.Now.ToShortTimeString();
            return result;
        }
    }
}
