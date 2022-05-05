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
        int PART_TIME_HOUR = 4;
        int FullTimeSalary;
        int PartTimeSalary;
        bool IsPresent;
        bool IsFullTime;
        bool IsPartTime;
        Random value = new Random();

        public void checkingpresentORAbsent()
        {
            int empCheck = value.Next(0, 2);
            if (empCheck == 1)
            {
                IsPresent = true;
                Console.WriteLine("Full Time Employee is Present");
            }
            else
            {
                IsPresent = false;
                Console.WriteLine("Full Time Employee is Absent");
            }
        }
        public void CaclEmpDailyWage()
        {
            if(IsPresent)
            {
                FullTimeSalary = WAGE_PER_HOUR * FULL_DAY_HOUR;
                Console.WriteLine("Daily wage of full time employee is " + FullTimeSalary);
            }

        }
        public void CheckEmpFullOrPartTime()
        {
            int num = value.Next(0, 2);
            if (num == 1)
            {
                IsPartTime = true;
                Console.WriteLine("Part Time employee is present ");
                PartTimeSalary = WAGE_PER_HOUR * PART_TIME_HOUR;
                Console.WriteLine("Daily Wage wage of part time employee is " +PartTimeSalary );
            }
            else
            {
                IsPartTime = false;
                Console.WriteLine("Part Time Employee is absent ");
            }
        }
    }
}