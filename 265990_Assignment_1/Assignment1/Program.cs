using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter your address");
            string add = Console.ReadLine();
            Console.WriteLine("Enter your contact number");
            int contact= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name + ". Your age is " + age);
            Console.WriteLine("Your addres is "+ add +". Your contact number is "+ contact);

            Console.ReadKey();
        }
    }
}
