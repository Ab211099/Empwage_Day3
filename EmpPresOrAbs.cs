using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWage
{
    internal class EmpPresOrAbs
    {
        public static void UC1()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 2);// 0 1

            switch (empcheck)
            {
                case 0:
                    Console.WriteLine("is present");
                    break;
                case 1:
                    Console.WriteLine("is abscent");
                    break;
                default:
                    break;
            }
        }
    }
}
