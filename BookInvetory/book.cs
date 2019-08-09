using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInvetory
{
    class book
    { //class that represents that data we want to store.
        public int Id { get; private set; }
        public String Title{ get; set; }
        public String Author { get; set; }
        public book(String Title, String Author)
        {
            this.Title = Title;
            this.Author = Author;
        }
    }
}
