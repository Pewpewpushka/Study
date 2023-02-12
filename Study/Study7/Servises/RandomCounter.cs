using Study7.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study7.Servises
{
    class RandomCounter : ICounter
    {
        static Random rnd = new Random();
        private int _value;
       

        public RandomCounter()
        {

             _value = rnd.Next(0, 1000000);


        }
        public int Value { get { return _value; } }
    }
}
