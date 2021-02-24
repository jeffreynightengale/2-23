using System;

namespace Participation__Guess_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomMin;
            Random randMin = new Random();
            randomMin = randMin.Next(1, 6); //I want a random minimum for them to guess from 1 to 5
            
            Console.WriteLine($"Guess a random minimum number. (1-5) >>");
            string answer = Console.ReadLine();

            while (int.TryParse(answer, out randomMin) == false)
            {
                Console.WriteLine("Your random guess was incorrect.");
                answer = Console.ReadLine();
            }


            Random randMax = new Random();
            int randomMax = randMax.Next(6, 11); //I want a random max for them to guess from 6 to 10
        }
    }
}
