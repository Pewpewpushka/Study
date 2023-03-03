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

        public List<BlowingAgents> BlowingAgents { get; internal set; }

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
            Polyol polyol5 = new Polyol() { Name = "Laprol 5503", OHv = 29, Functions = 5};
            polyols.Add(polyol5);
            Polyol polyol6 = new Polyol() { Name = "Laprol 4503", OHv = 37, Functions = 5 };
            polyols.Add(polyol6);
            Polyol polyol7 = new Polyol() { Name = "Laprol 3003", OHv = 52, Functions = 6 };
            polyols.Add(polyol7);
            Polyol polyol8 = new Polyol() { Name = "Laprol 3603", OHv = 47, Functions = 5 };
            polyols.Add(polyol8);
            dgvPoliols.DataSource = polyols;
            #endregion

            #region 2. BlowingAgents
            BlowingAgents blowingAgents1 = new BlowingAgents() { Name = "Water", OHv = 6233, Functions = 2 };
            blowingAgents.Add(blowingAgents1);
            
            dgvBlowingagents.DataSource = blowingAgents;

            #endregion

            #region 3. Catalization
            Cataliztions cataliztions1 = new Cataliztions() { Name = "NIAX Catalyst EF-700-1,4-диазабицикло[2.2.2]октан (DABCO), полиэтиленгликоль",  };
            cataliztions.Add(cataliztions1);
            Cataliztions cataliztions2 = new Cataliztions() { Name = "Jeffcat DPA-Диметиламинопропиламин" };
            cataliztions.Add(cataliztions2);
            Cataliztions cataliztions3 = new Cataliztions() { Name = "Jeffcat ZF-10-Триметилгидроксиэтилбисаминоэтиловый эфир"};
            cataliztions.Add(cataliztions3);
            Cataliztions cataliztions4 = new Cataliztions() { Name = "Катализатор 33-1,4-диазабицикло[2.2.2]октан (DABCO), полиэтиленгликоль, вода" };
            cataliztions.Add(cataliztions4);
            Cataliztions cataliztions5 = new Cataliztions() { Name = "DMEA (Dimethylethanolamine)" };
            cataliztions.Add(cataliztions5);
            Cataliztions cataliztions6 = new Cataliztions() { Name = "Triethylenediamine (TEDA)" };
            cataliztions.Add(cataliztions6);
            Cataliztions cataliztions7 = new Cataliztions() { Name = "Dabco T-12" };
            cataliztions.Add(cataliztions7);
            dgvCatalizators.DataSource = cataliztions;
            #endregion

            #region 4. Isocyanates
            Isocyanates isocyanates1 = new Isocyanates() { Name = "MDI-Voranate M229", NCO = 31, Viscosity25oC = 160 };
            isocyanates.Add(isocyanates1);
            Isocyanates isocyanates2 = new Isocyanates() { Name = "MDI-100", NCO = 31, Viscosity25oC = 102 };
            isocyanates.Add(isocyanates2);
            Isocyanates isocyanates3 = new Isocyanates() { Name = "MDI-50", NCO = 27, Viscosity25oC = 190 };
            isocyanates.Add(isocyanates3);
            Isocyanates isocyanates4 = new Isocyanates() { Name = "TDI", NCO = 31, Viscosity25oC = 25 };
            isocyanates.Add(isocyanates4);
            Isocyanates isocyanates5 = new Isocyanates() { Name = "HDI", NCO = 23, Viscosity25oC = 65 };
            isocyanates.Add(isocyanates5);
            Isocyanates isocyanates6 = new Isocyanates() { Name = "NDI", NCO = 28, Viscosity25oC = 100 };
            isocyanates.Add(isocyanates6);
            dgvIsocyanates.DataSource = isocyanates;

            #endregion

            #region 5. Silicones

            Silicones silicones1 = new Silicones() { Name = "NIAX Silicone L-417", Viscosity25oC = 600 };
            silicones.Add(silicones1);
            Silicones silicones2 = new Silicones() { Name = "NIAX Silicone L-590", Viscosity25oC = 740 };
            silicones.Add(silicones2);
            Silicones silicones3 = new Silicones() { Name = "Niax SC 240", Viscosity25oC = 300 };
            silicones.Add(silicones3);
            Silicones silicones4 = new Silicones() { Name = "Niax L-2100", Viscosity25oC = 300 };
            silicones.Add(silicones4);
            Silicones silicones5 = new Silicones() { Name = "AK-7715", Viscosity25oC = 1000 };
            silicones.Add(silicones5);
            Silicones silicones6 = new Silicones() { Name = "КЭП-2А", Viscosity25oC = 500 };
            silicones.Add(silicones6);
            dgrvSilicones.DataSource = silicones;
            #endregion

            #region 6. Staplers
            Staplers staplers1 = new Staplers() { Name = "TELA(ТЭА)", Viscosity25oC = 1500 };
            staplers.Add(staplers1);
            Staplers staplers2 = new Staplers() { Name = "MEG (Моноэтиленгликоль)", Viscosity25oC = 50 };
            staplers.Add(staplers2);
            Staplers staplers3 = new Staplers() { Name = "1,4-BDO (1,4-бутилендигликоль)", Viscosity25oC = 150 };
            staplers.Add(staplers3);
            Staplers staplers4 = new Staplers() { Name = "Dela(ДЭА)", Viscosity25oC = 300 };
            staplers.Add(staplers4);
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
