using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBClassLib
{
    internal class BBWedstrijd
    {
        private int id;
        private string Bondsnummer;
        private BBleeftijdsCategorie leeftijdsCategorie;
        private BBGeslacht GeslachtCategorie;
        private DateTime SpeelDatum;
        private BBTeam ThuisTeam;
        private BBTeam UitTeam;
        private BBUitslag Uitslag;

        public BBWedstrijd()
        {

        }
    }
}
