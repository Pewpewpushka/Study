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
        public List<BlowingAgents> blowingAgents= new List<BlowingAgents>();

        private void UcBaseIngredients_Load(object sender, EventArgs e)
        {
            Polyol polyol1 = new Polyol() { Name = "Desmophen 41WB01", OHv = 37, Functions = 3 };
            polyols.Add(polyol1);
            Polyol polyol2 = new Polyol() { Name = "Arcol 1108", OHv = 48, Functions = 3 };
            polyols.Add(polyol2);
            Polyol polyol3 = new Polyol() { Name = "Laprol 6003", OHv = 27, Functions = 5 };
            polyols.Add(polyol3);
            Polyol polyol4 = new Polyol() { Name = "Laprol", OHv = 37, Functions = 3 };
            polyols.Add(polyol4);

            dgvPoliols.DataSource = polyols;

            BlowingAgents blowingAgents1 = new BlowingAgents() { Name = "Water", OHv = 1168, Functions = 3 };
            blowingAgents.Add(blowingAgents1);

            dgvBlowingagents.DataSource= blowingAgents;




                /*
                 * Desmophen 41WB01	37	3
Arcol 1108	48	3
Полиол 6003	27	5

                 */
        }
    }
}
