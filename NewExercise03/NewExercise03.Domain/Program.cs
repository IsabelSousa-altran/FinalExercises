using System;

namespace NewExercise03.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a number: ");
            int number = int.Parse(Console.ReadLine());

            int factorialNumber = FactorialNumber.FactorialOfANumber(number);

            Console.WriteLine(factorialNumber);
        }
    }
}
