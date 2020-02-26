using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Lab4._5_Tammy_Griffin
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ArrayList scores = new ArrayList();
            scores.Add(4400);
            scores.Add(8900);
            scores.Add(1200);
            scores.Add(3700);
            scores.Add(7200);
            foreach (int number in scores)
            {
                Console.WriteLine(number);
            }
                        
            scores.Sort();
            foreach (int s in scores)
            {
                Console.WriteLine(s);
            }

            scores.Reverse();
            foreach (int s in scores)
            {
                Console.WriteLine(s);
            }
     
            scores.Add(2400);
            foreach (int number in scores)
            {
                Console.WriteLine(number);
            }
            scores.Remove(4400);
            foreach (int number in scores)
            {
                Console.WriteLine(number);
            }

        }
        
    }
}
