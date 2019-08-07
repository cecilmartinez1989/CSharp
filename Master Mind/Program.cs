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
            int hint1=0, hint2=0;
           Random generator = new Random();
           
            int randomcolor1 = generator.Next(0, 3);
            int randomcolor2 = generator.Next(0, 3);
            Console.WriteLine("Master mind is a game you guess 2 colors in a specific order from a group of 3 colors(red,yellow and blue)");
            Console.WriteLine("Your hints are: ");
            Console.WriteLine("0-0 if the user did not guess the correct colors at all");
            Console.WriteLine("1-0 if they guessed one of the colors correctly but not at the correct position");
            Console.WriteLine("0-1 if they guessed one of the colors correctly at the correct position");
            Console.WriteLine("2-0 if they guessed both colors correctly but at the wrong positions");
           while (hint1 != 2)
            {
            Console.WriteLine("Enter your first guesses: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter your second guesse: ");
            string input2 = Console.ReadLine();
            

            Console.WriteLine(randomcolor1);
            Console.WriteLine(randomcolor2);
            
            int guess1=3, guess2=3;

           

                if (input1 == "red")
                    guess1 = 0;
                else if (input1 == "yellow")
                    guess1 = 1;
                else if (input1 == "blue")
                    guess1 = 2;
                else
                    guess1 = 3;
                Console.WriteLine();

                if (input2 == "red")
                    guess2 = 0;
                else if (input2 == "yellow")
                    guess2 = 1;
                else if (input2 == "blue")
                    guess2 = 2;
                else
                    guess2 = 3;

                Console.WriteLine();

                if ((randomcolor1 == guess1 && randomcolor2 == guess2))
                {
                    Console.WriteLine("you WON");
                    hint1 = 2;
                }
                else if ((randomcolor1 == guess1 || randomcolor2 == guess2))
                {

                    hint1 = 1;

                }
                else
                    hint1 = 0;


                Console.WriteLine();

                if ((randomcolor2 == guess1 && randomcolor2 == guess2))
                {
                    
                    hint2 = 2;
                }
                else if ((randomcolor2 == guess1 || randomcolor1 == guess2))
                {

                    hint2 = 1;

                }
                else
                    hint2 = 0;
                Console.WriteLine("hint " +hint2+"-"+hint1);


            }
            Console.ReadLine();
            


            }



        
    }
}
