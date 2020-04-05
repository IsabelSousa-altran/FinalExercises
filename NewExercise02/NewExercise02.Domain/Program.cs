using System;

namespace NewExercise02.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                PerfectNumbers.ItIsPerfectNumber(number);

                Console.WriteLine(PerfectNumbers.ItIsPerfectNumber(number));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
           
        }
    }
}
