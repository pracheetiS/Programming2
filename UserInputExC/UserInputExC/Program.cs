using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputExC
{
    class Program
    {
        static void Main(string[] args)
        {
            if(Console.ReadLine() == "cat")
            {
                Console.WriteLine("meow");
            }
            else if(Console.ReadLine() == "dog")
            {
                Console.WriteLine("woof");
            }
            else if (Console.ReadLine() == "bird")
            {
                Console.WriteLine("tweet");
            }
            else
            {
                Console.WriteLine("Don't you like animals?");
            }
            Console.ReadLine();
        }
    }
}
