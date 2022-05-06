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
        int WORKING_DAYS = 20;
        int maxWorkingHours = 100;
        int FullTimeWage;
        int PartTimeSalary;
        int Wage;
        int partTimeWage;
        int monthlyWagesFullTime;
        int monthlyWagesPartTime;
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;
        int empHrs;
        int totalWage;
        bool IsPresent;
        bool IsFullTime;
        bool IsPartTime;
        Random value = new Random();

        //***************** USING IF ELSE STATEMENT ************************
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
                FullTimeWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                Console.WriteLine("Daily wage of full time employee is " + FullTimeWage);
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
                Console.WriteLine("*****************");
                Console.WriteLine("***************** ");
            }
        }
    
        //******** Using Switch Case Statement ******//

        public void usingswitch()
        {
            int num1 = value.Next(0, 2);
            switch(num1)
            {
                case 0:
                    Console.WriteLine("Full time employee");
                    Wage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                    Console.WriteLine("Wage of full time employee is " + Wage);
                    break;

                case 1:
                    Console.WriteLine("Part time employee");
                    partTimeWage = WAGE_PER_HOUR * PART_TIME_HOUR;
                    Console.WriteLine("Wages of  part time employee is " +partTimeWage);
                    break;

                default:
                    Console.WriteLine("Employee is Absent");
                    break;


                        
            }
        }

        public void monthlywages()
        {
            int num2 = value.Next(0, 2);
            switch(num2)
            {
                case 0:
                    monthlyWagesFullTime = WAGE_PER_HOUR * FULL_DAY_HOUR * WORKING_DAYS;
                    Console.WriteLine("Monthly wages for full time employee " + monthlyWagesFullTime);
                    break;
                case 1:
                    monthlyWagesPartTime = WAGE_PER_HOUR * PART_TIME_HOUR * WORKING_DAYS;
                    Console.WriteLine("Monthly wages for part time employee " + monthlyWagesPartTime);
                    break;
                default :
                    Console.WriteLine("Employee is Absent in this month ");
                    break;
            }
        }
        public void totaoWorkingDaysOrHoursReached()
        {
            while (totalEmpHrs<maxWorkingHours && totalWorkingDays<WORKING_DAYS)
            {
                totalWorkingDays++;
                int num3 = value.Next(0, 2);
                switch (num3)
                {
                    case 0:
                        empHrs = 8;
                        break;
                    case 1:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs=(totalEmpHrs + empHrs);
            }
            totalWage=(totalEmpHrs + WAGE_PER_HOUR);
            Console.WriteLine("Wages till a total working hours (100 Hrs) or days (20  Days) is reached is " +totalWage);
        }
    }
}

