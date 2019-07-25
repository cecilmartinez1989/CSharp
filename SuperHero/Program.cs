using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    class Program
    {
        static void Main(string[] args)
        {

            person p2 = new person("Cecil", "C");
            person p3 = new person("Donald", "Donny");
            person s2 = new superhero("Tony Stark", "", "Iron Man", "Intelligence");
            person s3 = new superhero("Peter Park", "", "Spider Man", "Spider Powers");
            person v2 = new villian("Venom", "", "Spider Man");
            person v3 = new villian("Thanos", "", "Avengers");

            List<person> allperson = new List<person>();

          

        }
        
        class person
        {
            public string name;
            public string nickname;

            public person(string inname,string innickname)
            {
                this.name = inname;
                this.nickname = innickname;
            }
            public void printgreeting()
            {
                person p1 = new person("William", "Bill");

                Console.WriteLine("Hi, my name is {0}, you can call me {1}",p1.name,p1.nickname);

                Console.ReadLine();
            }
            public override string ToString()
            {
                return name;
            }

        }

        class superhero : person
        {
            public string realname;
            public string superpower;
            public superhero(string inname, string innickname, string irealname, string isuperpower) : base(inname, null) {

                this.realname = irealname;
                this.superpower = isuperpower;
            }
            public new void printgreeting()
            {
                superhero s1 = new superhero("Wade Turner","", "Mr. Incredible", "Super Strength");
                Console.WriteLine("I am {0}. When I am {1}, my super power is {2}!",s1.name,s1.realname,s1.superpower);

            }
           
        }

        class villian : person
        {
            public string nemesis;
            public villian(string inname, string innickname, string inemesis) : base(inname, null)
            {
                this.nemesis = inemesis;
            }

            public new void printgreeting()
            {
                villian v1 = new villian("Joker","","Batman");
                Console.WriteLine("I am The {0}! Have you seen {1}?",v1.name,v1.nemesis);
            }
        }
            
    }
}
