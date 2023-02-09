using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemestry.Calcul.Polyol_and_isocyanate.Model.Ingredients
{
     class Isocyanates
    {

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
        public double NCO { get; set; }
        public double MW { get; set; }
        public double Viscosity25oC { get; set; }
    }
}
