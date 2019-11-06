using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenActivityArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[15, 3];
            array[0, 0] = "Carrie";
            array[1, 0] = "BirdBox";
            array[2, 0] = "Dracula";
            array[3, 0] = "The Hauntong of Hill House";
            array[4, 0] = "The Turn of the Screw";
            array[5, 0] = "Rosemary's Baby";
            array[6, 0] = "Something Wicked This Way Comes";
            array[7, 0] = "Frankenstein";
            array[8, 0] = "Let the Right One In";
            array[9, 0] = "A Head Full of Ghosts";
            array[10, 0] = "At the Mountains of Madness";
            array[11, 0] = "Penpal";
            array[12, 0] = "It";
            array[13, 0] = "Coraline";
            array[14, 0] = "Carrion Comfort";

            array[0, 1] = "Stephen King";
            array[1, 1] = "Josh Malerman";
            array[2, 1] = "Bram Stoker";
            array[3, 1] = "Shirley Jackson";
            array[4, 1] = "Henry James";
            array[5, 1] = "Ira Levin";
            array[6, 1] = "Ray Bradbury";
            array[7, 1] = "Mary Shelley";
            array[8, 1] = "John Ajvide Lindqvist";
            array[9, 1] = "Paul G. Tremblay";
            array[10, 1] = "H. P. Lovecraft";
            array[11, 1] = "Dathan Auerbach";
            array[12, 1] = "Stephen King";
            array[13, 1] = "Neil Gaiman";
            array[14, 1] = "Dan Simmons";

            array[0, 2] = "The story of misfit high-school girl, Carrie White, who gradually discovers that she has telekinetic powers.";
            array[1, 2] = "Something is out there, something terrifying that must not be seen.";
            array[2, 2] = "Derived from vampire legends and published in 1897, that became the basis for an entire genre of literature and film";
            array[3, 2] = "Hill House is a mansion in a location that is never specified but is between many hills.";
            array[4, 2] = "A chilling ghost story, wrought with tantalising ambiguity";
            array[5, 2] = "A young wife comes to believe that her offspring is not of this world.";
            array[6, 2] = "It is about two 13-year-old best friends, Jim Nightshade and William Halloway, and their nightmarish experience with a traveling carnival that comes to their Midwestern home";
            array[7, 2] = "The story of Victor Frankenstein, a young scientist who creates a hideous sapient creature in an unorthodox scientific experiment";
            array[8, 2] = "The story centers on the relationship between a 12-year-old boy, Oskar, and a centuries-old vampire child, Eli.";
            array[9, 2] = "The plot involves an American family under strain when their fourteen-year-old daughter, Marjorie Barrett, exhibits signs of mental illness.";
            array[10, 2] = "Dyer relates how he led a group of scholars from Miskatonic University on a previous expedition to Antarctica, during which they discovered ancient ruins and a dangerous secret, beyond a range of mountains higher than the Himalayas.";
            array[11, 2] = "Penpal began as a series of short and interconnected stories posted on an online horror ";
            array[12, 2] = "The story follows the experiences of seven children as they are terrorized by an evil entity that exploits the fears of its victims to disguise itself while hunting its prey.";
            array[13, 2] = "The fourteenth is locked, and on the other side is only a brick wall, until the day Coraline unlocks the door to find a passage to another flat in another house";
            array[14, 2] = "The novel portrays a tiny fraction of humanity that has immense psychic powers, which they refer to as 'The Ability'. These powers can be used to completely control people from a distance to commit any physical action, including murder. ";

            //Array.Sort(array);
            Console.WriteLine("Enter a number 1-15 inclusive");
            string num = Console.ReadLine();
            int i = Convert.ToInt32(num);
            if (i < 0 || i > 15) {
                Console.WriteLine("Invalid");
                System.Environment.Exit(1);

            }
            else
            {

                Console.WriteLine(array[i, 0]);
                Console.WriteLine(array[i, 1]);
                Console.WriteLine(array[i, 2]);
                Console.WriteLine();
                Console.ReadLine();

            }


        }
    }
}
