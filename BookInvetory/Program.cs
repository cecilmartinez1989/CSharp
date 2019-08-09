using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInvetory
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            // instantiate an instance of the context
            bookcontext context = new bookcontext();

            // makes sure that the table exists, 
            //and creates it if it does not already exist
            context.Database.EnsureCreated();
            do {
                // ask the user for a bool title and author to add
                Console.WriteLine("Enter Book's Title and Author splited by a coma ex. Harry Potter and the Chamber of Secrets ,  J. K. Rowling");
                String titleauthor = Console.ReadLine();

                // split the input into parts, and make sure 
                // we have 2 parts only
                String[] parts = titleauthor.Split(',');
                if (parts.Length == 2)
                {
                    // create a new student object, notice that we do not 
                    // select an id, we let the framework handle that
                    book newbook = new book(parts[0], parts[1]);

                    // add the newly created student instance to the context
                    // notice how similar this is to adding a item to a list,
                    context.books.Add(newbook);

                    // ask the context to save any changes to the database 
                    context.SaveChanges();
                    Console.WriteLine("Added new book.");
                }
                else
                {
                    Console.WriteLine("NOT A BOOK");
                }

                Console.WriteLine("The Current List of Books are: ");
                // use a for each loop to loop through the students in the context
                // notice how similar this is to looping through a list
                foreach (book b in context.books)
                {
                    Console.WriteLine("{0} - {1},{2}",
                         b.Id, b.Title, b.Author);
                }

                Console.WriteLine("Would you like to add another book? ");
                 input = Console.ReadLine();

            } while (input == "yes");
            Console.ReadLine();







        }
    }
}
