using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class PerfectNumber
    {
        public static void checkPerfectNumber()
        {
            Console.WriteLine("enter a number");
            int number =Convert.ToInt16(Console.ReadLine());
            int sum_of_factors = 0;

            for (int i = 1; i < number; i++)
            {
                if (number%i==0)
                {
                    sum_of_factors += i;
                }
            }
            if(sum_of_factors == number)
            {
                Console.WriteLine("given number is perfect");

            }
            else
            {
                Console.WriteLine("given number is not perfect");
            }

        }
    }
}
