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
            
            this.Hide();
            new FrontPage().ShowDialog();

        }

        private void btCoach_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            new FrontPage().ShowDialog();
        }

        private void btSpeler_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            new FrontPage().ShowDialog();
        }


    }
}