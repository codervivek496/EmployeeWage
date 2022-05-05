using System;
namespace empWage
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmpWage empWage = new EmpWage();
            empWage.checkingpresentORAbsent();
            empWage.CaclEmpDailyWage();
        }
    }
}
