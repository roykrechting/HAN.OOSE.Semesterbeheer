using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAN.OSSE.Semesterbeheer.Model
{
    public class Toets
    {
        private string Titel { get; set; }
        private string Omschrijving { get; set; }
        private string Inhoud { get; set; }
        private List<string> Criterea { get; set; }
        private Leeruitkomst Leeruitkomst { get; set; }

        public Toets()
        {
            Criterea = new List<string>();
        }

        public void AttachBeoordelingsCriterea(string criterea)
        {
            throw new NotImplementedException();
        }

        public void AttachLeeruitkomst (Leeruitkomst leeruitkomst)
        {
            throw new NotImplementedException();
        }

        private void AddCriterea()
        {
            throw new NotImplementedException();
        }

        private void CreateLeeruitkomst()
        {
            throw new NotImplementedException();
        }

        private void AddLeeruitkomst()
        {
            throw new NotImplementedException();
        }
    }
}
