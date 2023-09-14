using System;
using WebApplicationNewSait.Domain.Enum;

namespace WebApplicationNewSait.Domain.Entity
{
    public class PolyurethaneFoam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Properties { get; set; }
        public decimal Price { get; set; }

        public TypePolyurethaneFoam TypePolyurethaneFoam { get; set; }

    }
}
