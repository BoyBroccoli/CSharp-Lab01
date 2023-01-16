using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loopCount = 1;
            while (loopCount <= 5)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
                loopCount++;
            }
        }
    }
}
