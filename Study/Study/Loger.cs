using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study.LogServises;

namespace Study
{
    internal class Loger
    {
        ILogServise lod1;
      

        public Loger(ILogServise lod11)
        {
            lod1 = lod11;
        }


        public void Log(string message)
    {
        string log = $"{DateTime.Now}: {message}";
        lod1.Write(log);
    }
}
    
}
