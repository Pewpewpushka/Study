using _2.study_DI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.study_DI.Servises.CalculateServises
{
    internal class MultiplusLogServise : ICalculate
    {
        public void Run(double a, double b)
        {
            Console.WriteLine(a*b);
        }
    }
}
