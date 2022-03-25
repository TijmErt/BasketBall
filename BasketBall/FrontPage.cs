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
        BBPersoon Gebruiker;
        public FrontPage()
        {
            InitializeComponent();

        }

        private void btTeamView_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TeamView().ShowDialog();
        }

        private void btTeamAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TeamAdd().ShowDialog();
        }
    }
}
