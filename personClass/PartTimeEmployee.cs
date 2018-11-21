using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personClass
{
    class PartTimeEmployee:BasePerson
    {
        public int  PayPerH { get; set; }
        public int Hours { get; set; }


        public void EGetPayFN()
        {
            FullName();
            Console.WriteLine($"Pay: {PayPerH}$ Hours: {Hours}  ");
        }

    }
}
