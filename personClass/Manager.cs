using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personClass
{
    class Manager:BasePerson
    {
        public int Pay { get; set; }
        public int Days { get; set; }

        public void MGetPayFN()
        {
            FullName();
            Console.WriteLine($"Pay: {Pay}$ Days: {Days}  ");
        }
    }
}
