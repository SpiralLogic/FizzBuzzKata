
namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string Run(int iterations)
        {
            var elements = new string[iterations];

            for (var i = 1; i <= iterations; i++)
            {
                if (i % 3 == 0)
                {
                    elements[i - 1] = "Fizz";
                    continue;
                }

                elements[i - 1] = i.ToString();
            }

            return string.Join('\n', elements);
        }
    }
}