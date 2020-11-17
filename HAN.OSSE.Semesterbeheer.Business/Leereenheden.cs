using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HAN.OSSE.Semesterbeheer.Model;

namespace HAN.OSSE.Semesterbeheer.Business
{
    public class Leereenheden
    {
        private string Name { get; set; }
        private List<Leereenheid> AvailableLeereenheden { get; set; }

        public bool LeereenheidExists()
        {
            throw new NotImplementedException();
        }

        //TODO: Enable after implement Semester: 
        //public List<Leereenheid> GetLeereenhedenFromSemester(Semester semester)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
