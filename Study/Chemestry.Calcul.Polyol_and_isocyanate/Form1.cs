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
            u�Rigin1.Show();
        }

        private void btElastic_Click(object sender, EventArgs e)
        {
            ucBaseIngredients1.Hide();
            u�Rigin1.Hide();
            ucElastic1.Show();
        }

        private void btBaseIngrelients_Click(object sender, EventArgs e)
        {
            u�Rigin1.Hide();
            ucElastic1.Hide();
            ucBaseIngredients1.Show();

        }

        private void u�Rigin1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ucElastic1.Polyols = this.ucBaseIngredients1.polyols;
        }
    }
}