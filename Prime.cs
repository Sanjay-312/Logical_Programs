using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Prime
    {
        public static void checkForPrime()
        {
            Console.WriteLine("enter a number");
            int number = Convert.ToInt16(Console.ReadLine());

            int factors = 0;

            if (number !=0 && number !=1) 
            { 

                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        factors += 1;
                    }
                }
                if (factors == 0)
                {
                    Console.WriteLine("given number is prime");

                }
                else
                {
                    Console.WriteLine("given number is not prime");
                }
            }
            else
            {
                Console.WriteLine("number should not be 0 and 1");
            }
        }
    }
}
