using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationWinter2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.
            string name = "BriAnna Marsh";
            string location = "Rexburg ID";

            // 3.
            Console.WriteLine("My name is " + name + ".");
            Console.WriteLine("And I am from " + location + ".");

            // 4.
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("The current date is " + currentDate/*currentDate.ToString("d")*/);

            // 5.
            DateTime christmas = new DateTime(2021, 12, 25);
            Console.WriteLine("There is " + christmas.Subtract(currentDate).Days + " days until Christmas.");
            Console.WriteLine();

            // 6.
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Provide a width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Provide a height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");

            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");




            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");


            Console.ReadKey();
        }
    }
}
