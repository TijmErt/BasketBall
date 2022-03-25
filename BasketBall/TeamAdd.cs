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
using BBClassLib;

namespace BasketBall
{
    public partial class TeamAdd : Form
    {
        
        List<BBTeam> BBTeamList = new List<BBTeam>();

        


        public TeamAdd()
        {
            InitializeComponent();

            BBDataBaseRepository BBConnections = new BBDataBaseRepository();
            SqlDataReader readerClub = BBConnections.GetClubData();
            if (readerClub.HasRows)
            {
                Dictionary<string, string> comboSource = new Dictionary<string, string>();

                while (readerClub.Read())
                {
                    comboSource.Add(readerClub.GetValue(1).ToString(), readerClub.GetString("ClubName"));

                }
                cbClubSelect.DataSource = new BindingSource(comboSource, null);
                cbClubSelect.DisplayMember = "Value";
                cbClubSelect.ValueMember = "Key";

            }
            



        }
        private void cbxLeeftijdsCatagorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btRemoveSpeler_Click(object sender, EventArgs e)
        {
            
        }

        private void btAddSpeler_Click(object sender, EventArgs e)
        {
            

        }

        private void cbClubSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            BBDataBaseRepository BBConnections = new BBDataBaseRepository();
            SqlDataReader reader = BBConnections.GetLeeftijdsCatagorieData();
            if (reader.HasRows)
            {
                Dictionary<string, string> comboSource = new Dictionary<string, string>();

                while (reader.Read())
                {
                    comboSource.Add(reader.GetValue(1).ToString(), reader.GetString("LeeftijdsCategorieënNaam"));

                }
                cbxLeeftijdsCatagorie.DataSource = new BindingSource(comboSource, null);
                cbxLeeftijdsCatagorie.DisplayMember = "Value";
                cbxLeeftijdsCatagorie.ValueMember = "Key";

            }
            
        }
    }
}
