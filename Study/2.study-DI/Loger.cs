using _2.study_DI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.study_DI
{
    internal class Loger
    {
      ILogServise logServise;
        public Loger(ILogServise logServise)
        {
            this.logServise = logServise;
        }
        public void Log(string message)
        {
            logServise.Write($"{DateTime.Now}{message}");
        }
            
    }
}
