using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Mind
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter your two guesses: ");
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();
            Random generator = new Random();
            int randomNumber = generator.Next(0, 3);

            int red = 0, blue = 1, yellow = 2;


        }
    }
}
