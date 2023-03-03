using Chemestry.Calcul.Polyol_and_isocyanate.UserControls;

namespace Chemestry.Calcul.Polyol_and_isocyanate
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void btRegin_Click(object sender, EventArgs e)
        {
            ucBaseIngredients1.Hide();
            ucElastic1.Hide();
            uñRigin1.Show();
        }

        private void btElastic_Click(object sender, EventArgs e)
        {
            ucBaseIngredients1.Hide();
            uñRigin1.Hide();
            ucElastic1.Show();
        }

        private void btBaseIngrelients_Click(object sender, EventArgs e)
        {
            uñRigin1.Hide();
            ucElastic1.Hide();
            ucBaseIngredients1.Show();

        }

        private void uñRigin1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ucElastic1.Polyols = this.ucBaseIngredients1.polyols;
            this.ucElastic1.BlowingAgents = this.ucBaseIngredients1.blowingAgents;
            this.ucElastic1.Cataliztions = this.ucBaseIngredients1.cataliztions;
            this.ucElastic1.Isocyanates = this.ucBaseIngredients1.isocyanates;
            this.ucElastic1.Silicones = this.ucBaseIngredients1.silicones;
            this.ucElastic1.Staplers = this.ucBaseIngredients1.staplers;
        }   
    }
}