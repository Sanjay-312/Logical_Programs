using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class ReverseNumber
    {
        public static void reverseNumber()
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt16(Console.ReadLine());

            int reverse = 0;
            int reminder;

            while (number != 0)
            {

                reminder = number % 10;
                reverse = reverse * 10 + reminder;
                number /= 10;
                
            }
            Console.WriteLine(reverse);
        }
    }
}
