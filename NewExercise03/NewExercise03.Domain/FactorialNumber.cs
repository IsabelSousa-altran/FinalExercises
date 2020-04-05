using System;
using System.Collections.Generic;
using System.Text;

namespace NewExercise03.Domain
{
    class FactorialNumber
    {
        public static int FactorialOfANumber(int number)
        {
            if (number < 0 || number > 30)
            {
                throw new Exception("The number range is 0 to 30");
            }

            int product = 1;

            for (int i = 1; i <= number; i++)
            {
               product = product * i;
            }
            return product;
        }
    }
}
