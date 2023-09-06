using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class StopWatchClass
    {
        public static void getDuration()
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i <= 50000; i++)
            {
                Console.WriteLine(i);
            }
            sw.Stop();

            Console.WriteLine("time elaspsed : " + sw.Elapsed);
            
        
        }

    }
}
