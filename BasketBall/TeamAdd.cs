using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBClassLib;

namespace BasketBall
{
    public partial class TeamAdd : Form
    {
        List<BBTeam> BBTeamList = new List<BBTeam>();
        public TeamAdd()
        {
            InitializeComponent();
        }


        private void cbLeeftijdsGroep_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxAvalaibleSpelers.Items.Clear();
            lbxaddedSpelers.Items.Clear();

 
        }

        private void btRemoveSpeler_Click(object sender, EventArgs e)
        {
            
        }

        private void btAddSpeler_Click(object sender, EventArgs e)
        {
            

        }
    }
}
