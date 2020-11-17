using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAN.OSSE.Semesterbeheer.Model
{
    public class Les
    {
        private string Inhoud { get; set; }
        private string Leerdoelen { get; set; }
        private string Naam { get; set; }
        //TODO: Enable after implement Semester: private Semester Semester { get; set; }
        private Leereenheid Leereenheid { get; set; }
    }
}
