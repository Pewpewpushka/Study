using Study5.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study5.Servises
{
    class RandomCounter : ICounter

    {
        static Random _random = new Random();
        private int _value;
        

        public RandomCounter()
        {
            _value = _random.Next(0, 1000000);
           
        }
        public int Value { get { return _value; } }

        
    }
}
