using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            string input4;
            do
            {
                string input1, input2, input3;

                Console.WriteLine("This your To-do List");
                Console.WriteLine("Enter in the description of your to-do....EX. Do your coding projects!!!: ");
                input1 = Console.ReadLine();
                Console.WriteLine("Enter the due date... EX. 01/13/89: ");
                input2 = Console.ReadLine();
                Console.WriteLine("Enter the priority...EX. high, normal or low: ");
                input3 = Console.ReadLine();

                todo newitem = new todo(input1, input2, input3);
                Console.WriteLine("Desciption: {0} DueDate: {1} Priority: {2}", newitem.description, newitem.duedate, newitem.priority);

                List<todo> toadd = new List<todo>();
                toadd.Add(newitem);
                Console.WriteLine(toadd);

                Console.WriteLine("Do you want to add another item  to the list? (yes or no)");
                input4 = Console.ReadLine();

            } while (input4 == "yes");
        }


        class todo
        {
            public string description;
            public string duedate;
            public string priority;

            public todo(string indescription, string induedate, string inpriority)
            {
                this.description = indescription;
                this.duedate = induedate;
                this.priority = inpriority;
            }


        }



    }
}
