using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("enter num1  ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter num2  ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine(sum);

            int diff = num1 - num2;
            Console.WriteLine(diff);

            int product = num1 * num2;
            Console.WriteLine(product);

            int result = num1 / num2;
            Console.WriteLine(result);

            Console.WriteLine("Enter your name");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello " + Name);

            int nom1;
            int nom2;
            int nom3;
            Console.WriteLine("enter a number");
            nom1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number");
            nom2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number");
            nom3 = Convert.ToInt32(Console.ReadLine());

            int results = nom1 * nom2 * nom3;
            Console.WriteLine(results);

            Console.WriteLine("Enter your age  ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look younger than " + age);

                    }
    }
}
