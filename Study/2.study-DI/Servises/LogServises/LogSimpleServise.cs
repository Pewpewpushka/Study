using _2.study_DI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.study_DI.Servises.LogServises
{
    internal class LogSimpleServise : ILogServise
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
