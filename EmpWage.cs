using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empWage
{
    public class EmpWage
    {
        int WAGE_PER_HOUR = 20;
        int FULL_DAY_HOUR = 8;
        bool IsPresent;

        public void checkingpresentORAbsent()
        {
            Random value = new Random();
            int empCheck = value.Next(0, 2);
            if (empCheck == 1)
            {
                IsPresent = true;
                Console.WriteLine("Employee is present");
            }
            else
            {
                IsPresent = false;
                Console.WriteLine("Employee is Absent");
            }
        }
        public void CaclEmpDailyWage()
        {
            int empDailyWage = 0;
            if (IsPresent)
            {
                FULL_DAY_HOUR = 8;
            }
            else
            {
                FULL_DAY_HOUR = 0;
            }
                empDailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                Console.WriteLine("Employee Daily Wage is" + empDailyWage);
        }
    }
}