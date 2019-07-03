using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpapersisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randomNumber = generator.Next(0, 3);

            Console.WriteLine("Playing Rock, Paper,Sissors against the computer");
          
            Console.WriteLine("Enter rock, paper or sissors: ");
            string input = Console.ReadLine();

            Console.WriteLine(randomNumber);
           

            switch (input)
            {
                case "rock":
                    if (randomNumber == 0)
                    {
                        Console.WriteLine("Computer choses Rock");
                        Console.WriteLine("It's a tie!");
                    }
                    else if(randomNumber == 1)
                    {
                        Console.WriteLine("Computer choses Paper");
                        Console.WriteLine("you lose!");
                    }
                    else if(randomNumber == 2)
                    {
                        Console.WriteLine("Computer choses Sissores");
                        Console.WriteLine("you win!");
                    }
                    Console.ReadLine();
                break;
                case "paper":

                    if (randomNumber == 0)
                    {
                        Console.WriteLine("Computer choses Rock");
                        Console.WriteLine("you win!");
                    }
                    else if (randomNumber == 1)
                    {
                        Console.WriteLine("Computer choses Paper");
                        Console.WriteLine("its a tie!");
                    }
                    else if (randomNumber == 2)
                    {
                        Console.WriteLine("Computer choses Sissores");
                        Console.WriteLine("you loose");
                    }
                    Console.ReadLine();

                    break;

                case "sissors":

                    if (randomNumber == 0)
                    {
                        Console.WriteLine("Computer choses Rock");
                        Console.WriteLine("you lose!");
                    }
                    else if (randomNumber == 1)
                    {
                        Console.WriteLine("Computer choses Paper");
                        Console.WriteLine("you win!!");
                    }
                    else if (randomNumber == 2)
                    {
                        Console.WriteLine("Computer choses Sissores");
                        Console.WriteLine("it's a tie");
                    }
                    Console.ReadLine();

                    break;



            }









        }
    }
}
