using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationNewSait.Domain.Entity
{
    internal class PolyurethaneFoam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Properties { get; set; }
        public decimal Price { get; set; }

        public TypePolyurethaneFoam TypePolyurethaneFoam { get; set; }

    }
}
