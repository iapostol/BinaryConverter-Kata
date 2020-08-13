using System;
using System.Linq;

namespace BinaryConverter_Kata
{
    public static class BinaryConverter
    {
        public static string BinaryFor(int number)
        {
            if (number == 0)
                return "0";

            var binary = string.Empty;

            while (number > 0)
            {
                binary = (number % 2).ToString() + binary;
                number /= 2;
            }

            return binary;
        }

        public static int DecimalFor(string binary)
        {
            if (binary.Length == 1)
                return int.Parse(binary);

            double number = 0;

            var index = binary.Length - 1;

            foreach (var digit in binary.Select(c => c - '0').ToArray())
                number += digit * Math.Pow(2, index--);

            return Convert.ToInt32(number);
        }
    }
}
