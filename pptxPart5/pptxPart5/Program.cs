using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pptxPart5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using stream reader method: ");
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\SomeText.txt";
            FileStream inFile = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string contents = reader.ReadLine();
            Console.WriteLine("The contents of the file are:");
            Console.WriteLine(contents);
            reader.Close();
            Console.ReadLine();
            //Console.WriteLine("Adding text: ");
            //FileInfo fileInfo = new FileInfo(filePath);
            //FileStream outFile = fileInfo.OpenWrite();
            //Console.ReadLine();
            //outFile.Close();
            //inFile.Close();

        }
    }
}
