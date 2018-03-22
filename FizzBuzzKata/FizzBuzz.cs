﻿namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string Run(int iterations)
        {
            var output = string.Empty;
            for (var i = 1; i <= iterations; i++)
            {
                output += i.ToString() + "\n";
            }

            return output.TrimEnd('\n');
        }
    }
}