using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a list of integers. Separate using single spaces");
            string lst = Console.ReadLine();
            string[] nums = new string[] { };
            nums = lst.Split();
            int[] nums2 = Array.ConvertAll(nums, delegate (string s) { return int.Parse(s); });
            Array.Sort(nums2);

            Console.WriteLine("Enter the number of top integers you want");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Top " + n + "integers");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(nums2[nums2.Length - i -1]);
            }
            Console.ReadLine();
        }
    }
}
