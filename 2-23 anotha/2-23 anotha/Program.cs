using System;

namespace _2_23_anotha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your lucky # >>");
            string answer = Console.ReadLine();
            int luckyNum;

            while (int.TryParse(answer, out luckyNum) == false)
            {
                Console.WriteLine("Sorry you entered an invalid integer. Please enter another number");
                answer = Console.ReadLine();
            }

            Console.WriteLine("Good job. you got it right");
        }
    }
}
