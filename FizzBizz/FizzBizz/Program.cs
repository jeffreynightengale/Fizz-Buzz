using System;

namespace FizzBizz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int randomNum = r.Next(1, 101); // Generate a random number between 1 and 100. Always do 1 more.
            int divisableBy3Remainder = randomNum % 3;
            bool isDivisibleBy3 = randomNum % 3 == 0;
            
            
            if (randomNum % 3 == 0
                && randomNum % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }

            else if (randomNum % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }

            else if (randomNum % 3 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else
            {
                Console.WriteLine(randomNum);
            }

            
        }
    }
}
