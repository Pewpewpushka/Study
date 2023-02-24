using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemestry.Calcul.Polyol_and_isocyanate.Model.Ingredients
{
     public class Cataliztions : IIngredients
    {
        /// <summary>
        /// Наименование катализатора
        /// </summary>
        public string Name { get; set; }
        public double MW { get; set; }
        public double Viscosity25oC { get; set; }
        public double OHv { get; set ; }
        public double Functions { get ; set ; }
    }
}
