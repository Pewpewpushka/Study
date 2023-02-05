using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using study3;
using study3.Domain;


namespace study3.Servises
{
    public class SimpleServise:ILogServise
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
           
    }
}
