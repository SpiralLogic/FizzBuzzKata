﻿namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string Run(int iterations)
        {
            var output = string.Empty;
            for (var i = 1; i <= iterations; i++)
            {
                if (i % 3 == 0)
                {
                    output += "Fizz\n";
                    continue;
                }

                output += i + "\n";
            }

            return output.TrimEnd('\n');
        }
    }
}