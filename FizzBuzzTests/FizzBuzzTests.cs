using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void ShouldReturn1For1Iteration()
        {
            var fizzBuzz= new FizzBuzz();
            var results = fizzBuzz.Run(1);
            
            Assert.Equal("1", results);
        }
    }
}