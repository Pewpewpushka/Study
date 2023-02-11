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

        }

        private void btElastic_Click(object sender, EventArgs e)
        {
            ucBaseIngredients1.Hide();
            uñRigin1.Hide();
            ucElastic1.Show();
        }

        private void btBaseIngrelients_Click(object sender, EventArgs e)
        {

        }
    }
}