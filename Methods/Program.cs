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


            hello();
            add();
            catdog();
            oddEvent();
            inches();
            kilograms();
            echo();
            date();
            age();
            guess();





        }
        public static void hello()
        {
            string name;
            Console.WriteLine("Hi There!! What is your name: ");
            name = Console.ReadLine();
            Console.WriteLine("OK! BYE " + name);
        }
        public static void add()
        {
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

        public static void catdog()
        {
            string input;
            Console.WriteLine("Do you prefer cats or dogs? ");
            input = Console.ReadLine();
            if (input == "cats")
            {
                Console.WriteLine("meow");
            }
            else if (input=="dogs")
                {
                Console.WriteLine("bark");
            }
            Console.ReadLine();
        }
        public static void oddEvent()
        {
            int x;
            Console.WriteLine("enter a number:");
            x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 1)
            {
                Console.WriteLine("odd");
            }
            else
            {
                Console.WriteLine("even");
            }
            Console.ReadLine();

        }
        public static void inches()
        {
            Console.WriteLine("Enter a amout in feet: ");

            int feet= Convert.ToInt32(Console.ReadLine());

            int inches = feet * 12;
            Console.WriteLine(inches+" incehes");
            Console.ReadLine();
        }
        public static void echo() {

            Console.WriteLine("enter a word ");

            string input = Console.ReadLine();

            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());
            Console.WriteLine(input.ToLower());
            Console.ReadLine();
        }
        
        public static void kilograms()
        {
            Console.WriteLine("enter your wieght: ");
            int pounds= Convert.ToInt32(Console.ReadLine());
            double kilo = (double)pounds * 0.453592;

            Console.WriteLine(kilo+ "in kilograms");

            Console.ReadLine();

        }
        public static void date()
        {
            Console.WriteLine(DateTime.Today);
        }
        public static void age()
        {
            Console.WriteLine("What year where you born in? ");

            int year= Convert.ToInt32(Console.ReadLine());
            int age = DateTime.Today.Year - year;
            Console.WriteLine("you are "+age);
            Console.ReadLine();
        }
        public static void guess()
        {
            Console.WriteLine("guess a word ");
            string input = Console.ReadLine();
            if (input =="Csharp"){
                Console.WriteLine("Correct");

            }
            else
            {
                Console.WriteLine("wrong");
            }
            Console.ReadLine();
        }

    }
}
