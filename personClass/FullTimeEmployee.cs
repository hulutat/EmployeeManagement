using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personClass
{
    class FullTimeEmployee: BasePerson
    {
        public int WeeklyHWorked { get; set; }
        public decimal HPay { get; set; }
        public decimal WeeklyPay { get; set; }
        public decimal MonthlyPay { get; set; }
        public FullTimeEmployee(string nAme, string lastName, int aGe, int weeklyHWorked, decimal hPay)
        {
            this.Name = nAme;
            this.Lastname = lastName;
            this.Age = aGe;
            this.HPay = hPay;
            this.WeeklyHWorked = weeklyHWorked;
        }
        public void CalcWeeklyPay()
        {
            WeeklyPay = HPay * WeeklyHWorked;
            Console.WriteLine($"The weekly pay for {Name} {Lastname} is: {WeeklyPay}");
        }
        public void CalcMonthlyPay()
        {
            MonthlyPay = (HPay * WeeklyHWorked)*4;
            Console.WriteLine($"The monthly pay for {Name} {Lastname} is: {MonthlyPay}");
        }
        
    }
}
