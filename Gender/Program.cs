using System;

namespace Gender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a for male, f for female: ");
            string UserInput = Console.ReadLine();
            Hello(UserInput);
        }
        public static void Hello(string gender)
        {

            if (gender == "f")
            {
                Console.WriteLine("Hello, Madam!");
            }
            else if (gender == "m")
            {
                Console.WriteLine("Hello, Sir!");
            } else
            {
                Console.WriteLine("Hello, magical unicorn!");
            }


        }
    }
}