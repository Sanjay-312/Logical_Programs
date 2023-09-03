using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Logical_Programs
{
    internal class Fibonacci
    {
        public static void readInput()
        {
            Console.WriteLine("enter the number");

            int number=Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(getFibonacci(i));
            }
        }
        public static int getFibonacci(int i)
        {
            if (i <= 1)
            {
                return i;
            }
            else
            {
                return getFibonacci(i - 1)+getFibonacci(i-2);
            }
        }

        
    }
}
