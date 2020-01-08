using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a list of integers to be squared. Separate using single spaces");
            string lst = Console.ReadLine();
            string[] nums = new string[] {};
            nums = lst.Split();
            int[] nums2 = Array.ConvertAll(nums, delegate (string s) { return int.Parse(s); });
            int hi = nums2.Length;
            var listOfInts = new List<int>();
            for (int i = 0; i < nums.Length; i++) {
                listOfInts.Add((nums2[i] * nums2[i]));
            }

            Console.WriteLine("Squared List:");
            foreach (int n in listOfInts) {
                Console.Write(n.ToString() + " ");
            }

            Console.ReadLine();
        }

    }
}

