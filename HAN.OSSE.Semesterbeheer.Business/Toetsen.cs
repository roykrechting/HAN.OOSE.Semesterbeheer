using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HAN.OSSE.Semesterbeheer.Model;

namespace HAN.OSSE.Semesterbeheer.Business
{
    public class Toetsen
    {
        private List<Toets> AvailableToetsen { get; set; }

        public void AttachBeoordelingsCriterea(string toetsNaam, string criterea)
        {
            throw new NotImplementedException();
        }

        public void AttachLeeruitkomst(Toets toets, Leeruitkomst leeruitkomst)
        {
            throw new NotImplementedException();
        }

        public void ToetsAanmaken()
        {
            throw new NotImplementedException();
        }

        private bool ValidateCriterea()
        {
            throw new NotImplementedException();
        }

        private bool ValidateLeeruitkomst()
        {
            throw new NotImplementedException();
        }

        private Toets FindToets(string toetsTitle)
        {
            throw new NotImplementedException();
        }
    }
}
