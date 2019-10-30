using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num;
            num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Counting up with a loop...");
            writeUpRecursively(num);
            Console.WriteLine("Counting up with recursively...");
            writeDownLoop(num);


            Console.ReadLine();
        }

        static void writeUpRecursively(int n)
        {
            if (n > 1)  // stopping/continuing conditon            
            {                writeUpRecursively(n - 1);  // modify argument            
            }
            Console.WriteLine("{0}", n);
        }

        static void writeDownLoop(int n) {
            for (int i = 1; i <= n; i++) {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
