using PPUmarket.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPUmarket.Domain.Entity
{
    public class Foam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Properties { get; set; }
        public decimal Price { get; set; }

        public TypeFoam TypeFoam { get; set; }

    }
}
