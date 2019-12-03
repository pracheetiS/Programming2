using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise3AddColors
{
    class Program
    {
        

        static void Main(string[] args)
        {
            List<string> colors = new List<string>() {"blue","pink", "purple"};
            List<string> newColors = new List<string>() {"violet", "navy"}; //blue, pink, purple, violet, navy
            colors.AddRange(newColors);
            Console.ReadLine();

            Console.WriteLine("The colors in the first list are: ");
            Console.WriteLine("blue  pink  purple");
            Console.ReadLine();

            Console.WriteLine("The colors in the second list are: ");
            Console.WriteLine("navy  violet");
            Console.ReadLine();

            Console.WriteLine("The colors in the list after using AddRange: ");
            Console.WriteLine("blue  pink  purple  navy  violet");

            Console.ReadLine();


        }

    }
}
