using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = new List<int>() { 1,4,5,7,7,8,7,7,4,6,1,1,1 };

            var g = l1.GroupBy(i => i);

            foreach (int n in l1)
            {
                Console.Write(n.ToString() + " ");
            }
            Console.WriteLine("\n");

            foreach (var grp in g)
            {
                Console.WriteLine("{0} occurred {1} time(s)", grp.Key, grp.Count());
            }
            Console.ReadLine();
        }
    }
}
