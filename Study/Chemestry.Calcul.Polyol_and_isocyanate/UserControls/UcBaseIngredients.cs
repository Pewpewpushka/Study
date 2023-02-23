using Chemestry.Calcul.Polyol_and_isocyanate.Model;
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


        public List<Polyol> polyols = new List<Polyol>();
        public List<BlowingAgents> blowingAgents = new List<BlowingAgents>();
        public List<Cataliztions> cataliztions = new List<Cataliztions>();
        public List<Isocyanates> isocyanates = new List<Isocyanates>();
        public List<Silicones> silicones = new List<Silicones>();
        public List<Staplers> staplers = new List<Staplers>();



        private void UcBaseIngredients_Load(object sender, EventArgs e)
        {
            #region 1. Polyols
            Polyol polyol1 = new Polyol() { Name = "Desmophen 41WB01", OHv = 37, Functions = 3 };
            polyols.Add(polyol1);
            Polyol polyol2 = new Polyol() { Name = "Arcol 1108", OHv = 48, Functions = 3 };
            polyols.Add(polyol2);
            Polyol polyol3 = new Polyol() { Name = "Laprol 6003", OHv = 27, Functions = 5 };
            polyols.Add(polyol3);
            Polyol polyol4 = new Polyol() { Name = "Laprol 5003", OHv = 32, Functions = 6 };
            polyols.Add(polyol4);

            dgvPoliols.DataSource = polyols;
            #endregion

            #region 2. BlowingAgents
            BlowingAgents blowingAgents1 = new BlowingAgents() { Name = "Water", OHv = 6233, Functions = 2 };
            blowingAgents.Add(blowingAgents1);

            dgvBlowingagents.DataSource = blowingAgents;

            #endregion

            #region 3. Catalization
            Cataliztions cataliztions1 = new Cataliztions() { Name = "Catalizator 33", Viscosity25oC = 160 };
            cataliztions.Add(cataliztions1);
            dgvCatalizators.DataSource = cataliztions;
            #endregion

            #region 4. Isocyanates
            Isocyanates isocyanates1 = new Isocyanates() { Name = "MDI", NCO = 31, Viscosity25oC = 160 };
            isocyanates.Add(isocyanates1);
            dgvIsocyanates.DataSource = isocyanates;

            #endregion

            #region 5. Silicones

            Silicones silicones1 = new Silicones() { Name = "NIAX Silicone L-417", Viscosity25oC = 600 };
            silicones.Add(silicones1);
            Silicones silicones2 = new Silicones() { Name = "NIAX Silicone L-590", Viscosity25oC = 740 };
            silicones.Add(silicones2);
            dgrvSilicones.DataSource = silicones;
            #endregion

            #region 6. Staplers
            Staplers staplers1 = new Staplers() { Name = "TELA", Viscosity25oC = 160 };
            staplers.Add(staplers1);
            dgvStaplers.DataSource = staplers;

            #endregion
        }

        private void dgvPoliols_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCatalizators_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStaplers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrvSilicones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvIsocyanates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBlowingagents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
