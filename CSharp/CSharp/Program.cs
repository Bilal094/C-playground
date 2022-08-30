using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Converts double to string
            double floatNumberToString = 5.6786D;
            Console.WriteLine(Convert.ToString(floatNumberToString));

            // The value of a char variable should always have a single quote ('b') instead of a double quote ("b")
            char letter = 'a';
            Console.WriteLine(letter);

            /* Console.ReadLine() should be used for user input and returns always a string, except if you use a Convert function
               You can use Console.Write() so the user can enter his name on the same line as the input question */
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");

            Console.Write("Give me a digit: ");
            int firstDigit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Give me a second digit: ");
            int secondDigit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of those 2 digits is: " + (firstDigit + secondDigit));
        }
    }
}
