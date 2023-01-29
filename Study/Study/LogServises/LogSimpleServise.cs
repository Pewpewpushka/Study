using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.LogServises
{
    internal class LogSimpleServise:ILogServise
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
