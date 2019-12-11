using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // List<string> names = new List<string>();
            bool repeat = true;
            string repeater;
            while (repeat == true)
            {
                repeat = false;
                Console.WriteLine("Enter an employee name: ");
                List<string> names = new List<string>((Console.ReadLine()).Split());

                char[] firstname = names[0].ToCharArray();
                char[] middlename = names[1].ToCharArray();
                char[] lastname = names[2].ToCharArray();
                Console.WriteLine("The name for the name plate is " + names[0] + " " + names[1] + " " + names[2]);
                Console.WriteLine("The name for the company directory is " + names[2] + ", " + names[0] + " " + middlename[0] + ".");
                Console.WriteLine("The initials for the user id are " + firstname[0] + middlename[0] + lastname[0]);
                if (lastname.Length >= 5)
                { Console.WriteLine("The new email address is " + lastname[0] + lastname[1] + lastname[2] + lastname[3] + lastname[4] + firstname[0] + firstname[1] + (firstname.Length - 1).ToString() + (middlename.Length - 1).ToString() + (lastname.Length - 1).ToString() + "@apexpaper.com"); }
                else
                { Console.WriteLine("Last name was not long enough for email adress, must be at least 5 characters"); }
                Console.WriteLine("Enter R if you wish to repeat, Enter Q to exit");
                repeater = Console.ReadLine();
                if (repeater == "R")
                { repeat = true; }
            }
        }
    }
}
