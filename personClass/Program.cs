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

            Manager Marius = new Manager();
            Marius.Name = "Marius";
            Marius.Lastname = "Huluta";
            Marius.Age = 34;
            Marius.Pay = 2500;
            Marius.Days = 20;
            Marius.MGetPayFN();


            PartTimeEmployee Teo = new PartTimeEmployee();
            Teo.Name = "Teo";
            Teo.Lastname = "Huluta";
            Teo.Age = 20;
            Teo.PayPerH = 30;
            Teo.Hours = 40;
            Teo.EGetPayFN();


            PartTimeEmployee Andrei = new PartTimeEmployee();
            Andrei.Name = "Andrei";
            Andrei.Lastname = "Huluta";
            Andrei.Age = 22;
            Andrei.PayPerH = 33;
            Andrei.Hours = 40;
            Andrei.EGetPayFN();


           


            Console.ReadKey();


        }
    }
}
