using System.Collections.Generic;
using System.Linq;

namespace Kjetil.Kata.Modulus11
{
    public class Modulus
    {
        public static bool IsMod11Valid(string accountNumber)
        {
            var numbers = accountNumber
                .Replace(".", string.Empty)
                .ToCharArray()
                .Select(x => int.Parse(x.ToString()))
                .ToList();

            return 11 - Sum(numbers) % 11 == CheckDigit(numbers);
        }

        private static int Sum(IReadOnlyList<int> numbers)
        {
            var totals = 0;
            var factor = 2;
            for (var i = numbers.Count-2; i >= 0; i--)
            {
                totals += numbers[i] * factor++;
                if (factor > 7)
                {
                    factor = 2;
                }
            }

            return totals;
        }

        private static int CheckDigit(IReadOnlyList<int> numbers)
        {
            return numbers[numbers.Count-1];
        }
    }
}