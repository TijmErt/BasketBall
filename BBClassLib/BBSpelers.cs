using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBClassLib
{
    public class BBSpelers
    {

        public string Naam { get; private set; }

        public string AchterNaam { get; private set; }


        public BBSpelers(string naam, string achternaam)
        {
            this.Naam = naam;
            this.AchterNaam = achternaam;

        }

    }
}
