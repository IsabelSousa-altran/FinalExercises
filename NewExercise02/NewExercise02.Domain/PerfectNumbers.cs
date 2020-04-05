using System;
using System.Collections.Generic;
using System.Text;

namespace NewExercise02.Domain
{
    public class PerfectNumbers
    {
        public bool ItIsPerfectNumber(int number)
        {
            if (number < 0 || number > 10000)
            {
                throw new Exception("The range is between 0 and 10000");
            }

            bool perfectNumber = false;
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }

                if (number == sum)
                {
                    return perfectNumber = true;
                }
            }
            return perfectNumber = false;
        }
    }
}
