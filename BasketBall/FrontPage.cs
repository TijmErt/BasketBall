using BBClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketBall
{
    public partial class FrontPage : Form
    {
        BBSpelers Gebruiker;
        public FrontPage(BBSpelers gebruiker)
        {
            InitializeComponent();
            Gebruiker = gebruiker;
            if (gebruiker.Role == "Coach" || gebruiker.Role == "LeidingGevende")
            {
                btTeamAdd.Enabled = true;
            }
            else btTeamAdd.Enabled = true;
            
        }

        private void btTeamView_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TeamView(Gebruiker).ShowDialog();
        }

        private void btTeamAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
