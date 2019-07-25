using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Address");
            string address = Console.ReadLine();
            Console.WriteLine("Age:");
            double age = double.Parse(Console.ReadLine());
            Console.WriteLine("Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Pin:");
            int pin = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n...Details...\nName {name}\nAddress: {address}\nAge: {age}\nEmail: {email} \nPin: {pin}");
        }
    }
}
