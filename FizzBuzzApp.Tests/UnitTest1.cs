namespace FizzBuzzApp.Tests;

public class UnitTest1
{
    [Fact]
        public void GetFizzBuzz_ReturnsExpectedResult()
        {
            var result = FizzBuzz.GetFizzBuzz(1);
            Assert.Equal("this should fail :)", result);
        }
}
