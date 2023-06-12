using System;
namespace DieRolled
{

    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int result = random.Next(1, 7); // Generates a random number between 1 and 6

            Console.WriteLine("The die rolled: " + result);
        }
    }
}