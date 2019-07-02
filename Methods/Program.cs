using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
            {

            
                string name;
                Console.WriteLine("Hi There!! What is your name: ");
                name = Console.ReadLine();
                Console.WriteLine("OK! BYE BOB!");


            
            

                int a;
                int b;
                int c;
                string number, number2;
                Console.WriteLine("Input your first number to add: ");
                number = Console.ReadLine();
                a = Convert.ToInt32(number);
                Console.WriteLine("Now the second: ");
                number2 = Console.ReadLine();
                b = Convert.ToInt32(number2);
                c = a + b;
                Console.WriteLine("Your total is: {0}", c);


                Console.ReadLine();



            
        }
    }
}
