using BBClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketBall
{
    public partial class TeamView : Form
    {
        BBSpelers gebruiker;
        SqlDataReader reader;
        public TeamView(BBSpelers gebruiker)
        {
            InitializeComponent();
            
        }

        private void cbxTeamList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxPlayerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
