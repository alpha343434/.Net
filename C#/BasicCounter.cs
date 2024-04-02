using System;

namespace iamlearning
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string enteredtext = "";

            while (enteredtext.Equals(""))
            {
                Console.WriteLine("press enter to count");
                enteredtext = Console.ReadLine();

                counter++;
                Console.WriteLine("Current number is: {0}",counter);
            }
            Console.Read();
        }
    }
}
