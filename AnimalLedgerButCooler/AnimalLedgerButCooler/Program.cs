using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLedgerButCooler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>();
            animals.Add("Dog1 is at the vet");
            animals.Add("Dog2 is not at the vet");
            animals.Add("Dog3 is at the vet");
            animals.Add("Dog4 is at the vet");
            animals.Add("Dog5 is not at the vet");
            animals.Add("Dog6 is at the vet");
            animals.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
