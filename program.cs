using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Nice to meet you, " + name + "! How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Great! You are {age} years old.");

            if (age < 18)
            {
                Console.WriteLine("You are quite young!");
            }
            else if (age < 50)
            {
                Console.WriteLine("You are in the prime of your life!");
            }
            else
            {
                Console.WriteLine("You are wise beyond your years!");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
