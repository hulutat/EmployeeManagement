using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personClass
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee E1 = new FullTimeEmployee("Jon", "Jonas", 32, 40, 8);
            FullTimeEmployee E2 = new FullTimeEmployee("Rick", "Morty", 29, 35, 15);
            E1.CalcWeeklyPay();
            E2.CalcWeeklyPay();
           
            Console.ReadKey();
        }
    }
}
