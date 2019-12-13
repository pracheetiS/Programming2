using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pptxpart1_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fileName = @"\\testRead.txt";
            //using (StreamWriter fileStr = File.SpecialFolder.Personal.CreateText(fileName))
            //{
            //    fileStr.WriteLine("Hello and Welcome");
            //    Console.WriteLine(" It is the first content");
            //    Console.WriteLine(" of the text file mytest.txt");
            //    Console.WriteLine(" A file created with the content name mytest\n\n");
            //    Console.ReadLine();
            //}
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\testRead.txt";  // this resolves to My Documents
            string readText = File.ReadAllText(fileName);
            Console.WriteLine(readText);
            string textToAdd = "Hello World" + "\n" + readText;
          
                
            File.WriteAllText( fileName, textToAdd);
            File.AppendAllText(fileName, textToAdd);
            Console.ReadLine();
        }
    }
}
