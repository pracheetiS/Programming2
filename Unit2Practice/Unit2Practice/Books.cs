using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2Practice
{
    public abstract class Books
    {
        int ISBN;
        double price;
        string author;
        string title;

        public Books() {
            

        }

        public Books(int ISBN, double price, string author, string title) {
            this.ISBN = ISBN;
            this.price = price;
            this.author = author;
            this.title = title;
        }

        abstract public double setPrice();

        public bool Equals(object obj, object obj2)
        {
            
            return base.Equals(obj);
        }

        public int myISBN()
        {

            return ISBN;
        }

    }
}
