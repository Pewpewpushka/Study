using study3.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study3
{
    public class Loger
    {
        ILogServise logservise;
        public Loger (ILogServise logservise)
        {
            this.logservise = logservise;
        }
        public void Log(string message)
        {
            logservise.Write($"{DateTime.Now}{message}");
        }
    }
}
