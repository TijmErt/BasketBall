using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBClassLib
{
    public class BBPersoon
    {
        public readonly int ID;
        private string Naam;
        private string Bondsnummer;
        private DateOnly GeboorteDatum;
        private BBGeslacht Geslacht;
        private List<BBRol> rol;
        



        public BBPersoon(int id, string naam)
        {
            this.ID = id;
            this.Naam = naam;

        }

    }
}
