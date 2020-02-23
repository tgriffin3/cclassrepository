using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int myFirstNumber = 19;
            Console.WriteLine(myFirstNumber);

            int mySecondNumber = 244;
            Console.WriteLine(mySecondNumber);

           
            Console.WriteLine(myFirstNumber * mySecondNumber);

            string myText = "Some text ";
            Console.WriteLine(myText  +  mySecondNumber);

            string moreText = " Goes here";
            Console.WriteLine(myText  +  moreText);

            string color1 = "yellow";
            string color2 = "Red";

            bool isYellow = true;
            bool isGreen = false;
            Console.WriteLine(color1);
            Console.WriteLine(isYellow);
            Console.WriteLine(color2);
            Console.WriteLine(isGreen);

            double numbers;
            numbers = mySecondNumber / myFirstNumber;
            Console.WriteLine(numbers);

            Console.WriteLine(mySecondNumber/(double)myFirstNumber);
            Console.WriteLine(numbers);

            Console.WriteLine("Breakpoint here");

            string textToNumber = "80473";
            int results = 99 * int.Parse(textToNumber);
            Console.WriteLine(results);

            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);











        }
    }
}
