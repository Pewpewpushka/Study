using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruePPY.Domain.Entity
{
    public class SystemsPPY
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public double Density { get; set; }
        public decimal Price { get; set; }

        public TypePPY TypePPYSystem { get; set; }

    }
}
