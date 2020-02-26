using System;
using System.Collections;

namespace LabSpamChecker_Tammy_Griffin
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] spamwords = { "buy", "viagra", "XXX", "free money", "lifetime offer", "send money",
                                  "bank account", "nigeria", "online pharmacy", "h8te", "meet girls"};


            string message = Console.ReadLine();
            bool isSpam = false;
            message = message.ToLower();
            for (int i = 0; i < spamwords.Length; i++)
            {
                if (message.Contains(spamwords[i]))
                {
                    isSpam = true;
                }
            }

            if (isSpam == true)
            {
                isSpam = true;
                Console.WriteLine("This is spam");
                Console.WriteLine(message);
            }
            else
            {
                isSpam = false;
                Console.WriteLine("This is not spam.");

            }
        }
    }
}