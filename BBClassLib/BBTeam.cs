using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBClassLib
{
    public class BBTeam
    {
        private List<BBSpelers> BBGebruikerList = new List<BBSpelers>();
        public string Name { get; private set; }
        public int TeamID { get; private set; }
        public int ClubID { get; private set; }


        public BBTeam(string name, int teamid, int clubid)
        {
            Name = name;
            TeamID = teamid;
            ClubID = clubid;
        }

        public void AddSpelersToTeam(BBSpelers gebruiker)
        {
            BBGebruikerList.Add(gebruiker);
        }

        public List<BBSpelers> GetTeamSpelers()
        {
            return BBGebruikerList;
        }

        public void RemoveSpelerFromTeam(BBSpelers gebruiker)
        {
            BBGebruikerList.Remove(gebruiker);
        }

    }
}
