using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddColors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> colors1 = new List<string>() { "blue", "pink", "purple" };
            List<string> colors2 = new List<string>() { "navy", "violet" };

            Console.WriteLine("The colors in your first list are:");
            for (int i = 0; i < colors1.Count(); i++)
            {
                Console.Write(colors1[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("The colors in your second list are:");
            for (int i = 0; i < colors2.Count(); i++)
            {
                Console.Write(colors2[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            colors1.AddRange(colors2);
            Console.WriteLine("The colors in your combined list are:");
            for (int i = 0; i < colors1.Count(); i++)
            {
                Console.Write(colors1[i] + ", ");
            }

            Console.ReadLine();
        }
    }
}
