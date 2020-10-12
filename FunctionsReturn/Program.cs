using System;

namespace FunctionsReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth");
            string userinput = Console.ReadLine();
            int userage = CalculateAge(userinput);
            ValideAge(userage);

            Console.WriteLine($"You are {userage} years old");
        }

        public static int CalculateAge(string userinput)
        {
            int userage = 2020 - Int32.Parse(userinput);
            return userage;

        }

        public static void ValideAge(int age)
        {
            if (age < 18)
            {
                Console.WriteLine("You are not old enough to drive a car.");
            }
            else if (age > 18)
            {
                Console.WriteLine("You go get it.");
            }

        }
       




    }
}
