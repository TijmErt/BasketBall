using BBClassLib;
namespace BasketBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void btLeidingGevende_Click(object sender, EventArgs e)
        {
            BBSpelers LeidingGevende = new BBSpelers(6,"Rob", "De Bouwer", "LeidingGevende");
            this.Hide();
            new FrontPage(LeidingGevende).ShowDialog();

        }

        private void btCoach_Click(object sender, EventArgs e)
        {
            BBSpelers Coach = new BBSpelers(7, "Eelco", "Coacher", "Coach");
            this.Hide();
            new FrontPage(Coach).ShowDialog();
        }

        private void btSpeler_Click(object sender, EventArgs e)
        {
            BBSpelers Speler = new BBSpelers(6, "Tijm", "van Dongen", "Speler");
            this.Hide();
            new FrontPage(Speler).ShowDialog();
        }

    }
}