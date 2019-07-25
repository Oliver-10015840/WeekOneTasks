using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a whole number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert another whole number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please insert a decimal number:");
            decimal dec1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please insert another decimal:");
            decimal dec2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please insert a string:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Please insert another string:");
            string str2 = Console.ReadLine();

            Console.WriteLine($"...Information...\n" +
                $"The two numbers are {num1} and {num2}\n" +
                $"The two decimals are {dec1} and {dec2}\n" +
                $"The two strings are {str1} and {str2}");
        }
    }
}
