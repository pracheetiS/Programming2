using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num;
            num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The sum of the numbers 1 to " + num + " computed with a loop is " + computeSum(num));
            Console.WriteLine("The sum of the numbers 1 to " + num + "computed recursively is " + computeSumRecursively(num));
            Console.ReadLine();
        }

        static int computeSum(int n) {
            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                total += i;
            }
            return total;
        }

        static int computeSumRecursively(int n)
        {
            if (n == 1) {
                return 1; }  // the calls to itself will stop when we reach 1  
            else {
                return n + (computeSumRecursively(n - 1));
            } // add the current number and call myself with current number minus 1}
        }
    }
}
