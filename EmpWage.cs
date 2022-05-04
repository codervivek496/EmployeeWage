using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empWage
{
    public class EmpWage
    {
        public void checkingpresentORAbsent()
        {
            Random value = new Random();

            int empCheck = value.Next(0, 2);
            if (empCheck == 1)
            {
            Console.WriteLine("Employee is present");
            }
            else
            {
            Console.WriteLine("Employee is Absent");
            }
        }

    }
}