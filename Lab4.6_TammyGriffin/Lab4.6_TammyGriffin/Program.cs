using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab4._6_TammyGriffin
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            string[] Tasks = new string[7];

            for (int i = 0; i < days.Length; i++)
            {

                Console.WriteLine("Type in a new Task for:  " + days[i]);
                Tasks[i] = days[i] + " : " + Console.ReadLine();

            }

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(Tasks[i]);
            }
        }
    }
}
