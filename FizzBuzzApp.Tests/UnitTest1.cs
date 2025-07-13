namespace FizzBuzzApp.Tests;

public class UnitTest1
{
    [Fact]
        public void GetFizzBuzz_ReturnsExpectedResult(int input, string expected)
        {
            var result = FizzBuzz.GetFizzBuzz(input);
            Assert.Equal(expected, result);
        }
}
