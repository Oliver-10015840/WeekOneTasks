using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name? ");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName + " " + lastName + ", Nice to meet you!");
            Console.WriteLine("Hello {0} {1}, Nice to meet you!", firstName, lastName);
            Console.WriteLine($"Hello {firstName} {lastName}, Nice to meet you!");
        }
    }
}
