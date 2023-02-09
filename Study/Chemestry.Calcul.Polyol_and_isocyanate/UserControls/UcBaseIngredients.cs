using Chemestry.Calcul.Polyol_and_isocyanate.Model.Ingredients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemestry.Calcul.Polyol_and_isocyanate.UserControls
{
    public partial class UcBaseIngredients : UserControl
    {
        public UcBaseIngredients()
        {
            InitializeComponent();
        }
        public List<Polyol> polyols= new List<Polyol>();

        private void UcBaseIngredients_Load(object sender, EventArgs e)
        {
            Polyol polyol1 = new Polyol() { Name = "Desmophen 41WB01", OHv = 37, Functions = 3 };
            polyols.Add(polyol1);




            dgvPoliols.DataSource = polyols;
                /*
                 * Desmophen 41WB01	37	3
Arcol 1108	48	3
Полиол 6003	27	5

                 */
        }
    }
}
