using System;
using System.Collections.Generic;
using System.Text;

namespace NewExercises.Domain
{
    public class RomanNumber
    {
        //public int Number { get; set; }

        //public RomanNumber(int number)
        //{
        //    Number = number;
        //}

        public  readonly Dictionary<int, string> NumberToRomanDictionary;

        public  RomanNumber()
        {
            NumberToRomanDictionary = new Dictionary<int, string>
            {
                {1000, "M" },
                {900, "CM" },
                {500, "D" },
                {400, "CD" },
                {100, "C" },
                {90, "XC" },
                {50, "L" },
                {40, "XL" },
                {10, "X" },
                {9, "IX" },
                {5,"V" },
                {4, "IV" },
                {1, "I" },
            };
        }

        public string ConvertIntegerToRoman(int integerNumber)
        {
            if ((integerNumber < 1) || (integerNumber > 3999))
            {
                throw new Exception("Insert values between 1 and 3999 ");
            }


            StringBuilder roman = new StringBuilder();

            foreach (var item in NumberToRomanDictionary)
            {
                while (integerNumber >= item.Key)
                {
                    roman.Append(item.Value);
                    integerNumber -= item.Key;
                }
            }
            return roman.ToString();
        }
    }
}

