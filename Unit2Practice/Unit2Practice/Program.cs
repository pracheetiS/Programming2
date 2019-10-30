using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2Practice
{
    class Program 
    {
        static void Main(string[] args)
        {
            Textbook book1 = new Textbook();
            Textbook book2 = new Textbook();
            Textbook book3 = new Textbook();
            Equals(book1, book2);
            Equals(book1, book3);
            Books[] myBooks = new Books[100];
            int r = 1;
            while (r < 100){
                Console.WriteLine(myBooks[r]);
                r++;
            }
            
        }

        public static bool Equals(Textbook obj, Textbook obj2)
        {
            bool same = false;
            if (obj.myISBN() == obj2.myISBN()) {
                same = true;
            }


            return same;
        }
    }
}
