using FizzBuzzKata;
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

        [Fact]
        public void ShouldReturn2For2Iterations()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Run(2);
            
            Assert.Equal("1\n2", result);
        }
        
        [Fact]
        public void ShouldReturnFizzFor3Iterations()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Run(3);
            
            Assert.Equal("1\n2\nFizz", result);
        }
        
        [Fact]
        public void ShouldReturnBuzzFor5Iterations()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Run(5);
            
            Assert.Equal("1\n2\nFizz\n4\nBuzz", result);
        }
    }
}