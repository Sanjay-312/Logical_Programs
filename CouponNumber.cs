using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class CouponNumber
    {

        public static void getCouponNumber()
        {
            Console.WriteLine("enter the number of coupon required");

            int number=Convert.ToInt32(Console.ReadLine());

            int[] coupounArray= new int[number];

            Random random = new Random();

            int generate = 0;

            int i = 0;

            while(i < number)
            {
                int randomNumber=random.Next(500+1);
                generate++;
                Console.WriteLine("random number is : "+randomNumber);
                if(coupounArray.Contains(randomNumber))
                {
                    continue;
                }
                else
                {
                    coupounArray[i] = randomNumber;
                }
                i++;
            }
            foreach(int coupon in coupounArray)
            {
                Console.WriteLine(coupon+" ");

            }
            Console.WriteLine("random numbers we need to generate : " + number + " number of coupouns are " + generate);




        }
    }
}
