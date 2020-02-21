using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListWord = "Trump";
            bool isSpam = false;
            string message = Console.ReadLine();

            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("This is spam");
                Console.WriteLine(blackListWord);
            }
            else
            {
                isSpam = false;
                Console.WriteLine("This is not spam.");
                Console.WriteLine(message);
            }
        }
    }
}
