using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCos
{
    class Program
    {
        static void Main(string[] args)
        {
            DriversLicense person = new DriversLicense("Cecil", "Martinez III", "Male", 31415926);
            Console.WriteLine("Driver license name: {0} {1}",person.firstname,person.lastname);
            Console.WriteLine("Gender: {0}",person.gender);
            Console.WriteLine("Driver License #: {0}",person.licensenumber);

           book b = new book("Return of the King","J.R.R Toklein",416,7894545,"George Allen & Unwin",25.99);
            Console.WriteLine("{0} is written by {1} and has {2} pages, SKN is {3}, publish by {4} and is price at {5}",b.title,
                b.author,b.pages,b.SKU,b.publisher,b.price);

            airplane a = new airplane("McDonnell Douglas","F-15","F-15B",1,2);
            Console.WriteLine("Manufacturer of a {0} is {1}, it has {2} engines with {3} person capacity and a variant is {4}."
                ,a.model,a.manufacturer,a.engines,a.capacity,a.variant);
        }
        class DriversLicense
        {
            public string firstname;
            public string lastname;
            public string gender;
            public int licensenumber;
            public DriversLicense(string initialfirstname,string initiallastname,string initialgender, int initiallicensenumber)
                {
                this.firstname = initialfirstname;
                this.lastname = initiallastname;
                this.gender = initialgender;
                this.licensenumber = initiallicensenumber;

            }


        }
        class book
        {
            public string title;
            public string author;
            public int pages;
            public int SKU;
            public string publisher;
            public double price;
            
            public book(string intitle,string inauthor, int inpages,int inSKU,string inpublisher, double inprice)
            {
                this.title = intitle;
                this.author = inauthor;
                this.pages = inpages;
                this.SKU = inSKU;
                this.publisher = inpublisher;
                this.price = inprice;



            }

        }
        class airplane
        {
            public string manufacturer;
            public string model;
            public string variant;
            public int capacity;
            public int engines;
             public airplane(string inmanufacturer, string inmodel, string invariant, int incapacity, int inengines)
            {
                this.manufacturer = inmanufacturer;
                this.model = inmodel;
                this.variant = invariant;
                this.capacity = incapacity;
                this.engines = inengines;
            }


        }
    }
}
