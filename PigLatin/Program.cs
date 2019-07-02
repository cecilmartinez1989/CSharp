using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string pigword;
            string pigfinal = "";
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            string[] vowels2 = new string[] { "a", "e", "i", "o", "u" };

            Console.WriteLine("Type in your word to translate to piglatin: ");
            pigword = Console.ReadLine();
            string frist = pigword.Substring(0, 1);
            string last = pigword.Substring(pigword.Length-1);
            if (vowels2.Contains(frist)&&vowels2.Contains(last))
            {
                pigfinal = pigword + "yay";
            }
            else if(vowels2.Contains(frist)&& !vowels2.Contains(last))
            {
                pigfinal = pigword + "ay";
            } 
            else if (pigword.IndexOfAny(vowels)==-1)
            {
                pigfinal = pigword + "ay";


            }
            else if (!vowels2.Contains(frist) && pigword.IndexOfAny(vowels) > -1)
            {
                int index=pigword.IndexOfAny(vowels);
                string before = pigword.Substring(0, index);
                string after = pigword.Substring(index);
                pigfinal = after + before + "ay";
            }


            Console.WriteLine(pigfinal);
            Console.ReadLine();


        }
    }
}
