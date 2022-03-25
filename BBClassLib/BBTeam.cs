using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBClassLib
{
    public class BBTeam
    {
        private int id;
        private List<BBPersoon> Spelers = new List<BBPersoon>();
        private List<BBPersoon> Coaches = new List<BBPersoon>();
        private BBleeftijdsCategorie leeftijdsCategorie;
        private BBGeslacht GeslachtsKlass;

        public BBTeam()
        {

        }

        public void AddSpelersToTeam(BBPersoon speler)
        {
            Spelers.Add(speler);
        }
        public void AddCoachToTeam(BBPersoon coach)
        {
            Coaches.Add(coach);
        }
        public void RemoveSpelerFromTeam(BBPersoon speler)
        {
            Spelers.Remove(speler);
        }
        public void RemoveCoachesFromTeam(BBPersoon coach)
        {
            Coaches.Remove(coach);
        }

        public List<BBPersoon> GetTeamSpelers()
        {
            return Spelers;
        }
        public List<BBPersoon> GetTeamCoaches()
        {
            return Coaches;
        }



    }
}
