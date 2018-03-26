using System;
using System.Collections.Generic;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string Run(int iterations)
        {
            var elements = new string[iterations];

            PopulateOutputElements(iterations, elements);

            return string.Join('\n', elements);
        }

        private void PopulateOutputElements(int iterations, IList<string> elements)
        {
            for (var i = 1; i <= iterations; i++)
            {
                if (i % 3 == 0)
                {
                    elements[i - 1] += "Fizz";
                }

                if (i % 5 == 0)
                {
                    elements[i - 1] += "Buzz";
                }

                if (elements[i - 1] == string.Empty)
                {
                    elements[i - 1] = i.ToString();
                }

            }
        }
    }
}