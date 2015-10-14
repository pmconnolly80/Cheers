using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello there! What's your name?");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Hi, " + name);
            int counter = 0;
            char[] ans = { 'a', 'e', 'f', 'h', 'i', 'l', 'm', 'n', 'o', 'r', 's', 'x' };
            foreach (char letter in name)
            {
                if (ans.Contains(char.ToLower(letter)))
                {
                    System.Console.WriteLine("Give me an " + letter + "\n");
                }
                else
                {
                    System.Console.WriteLine("Give me a " + letter + "\n");
                }
                counter += 1;
                if (counter == name.Length)
                {
                    System.Console.WriteLine(name.ToUpper() + " is GRAND! \n");
                }
            }

            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();


            //Get the user's name and print it
            //Cheer the user on
            //For example, if name is "Bob", output should be:

            //Give me a..b
            //Give me an..o
            //Give me a..b
            //BOB is.. GRAND!
        }
    }
}
