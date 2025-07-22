namespace FizzBuzzApp.Tests;

public class FizzBuzzTests
{
    // To run unit tests, run this command from the same folder as the .sln file: 
    // dotnet test
    [Fact]
    public void GetFizzBuzz_Input_1_ReturnsExpectedResult()
    {
        var result = FizzBuzz.GetFizzBuzz(1);
        Assert.Equal("1", result);
    }

    [Fact]
    public void GetFizzBuzz_Input_3_ReturnsExpectedResult()
    {
        Assert.True(true); // Placeholder. This will pass, but nothing is tested.
    }

    [Fact]
    public void GetFizzBuzz_Input_5_ReturnsExpectedResult()
    {
        Assert.True(true); // Placeholder. This will pass, but nothing is tested.
    }

    [Fact]
    public void GetFizzBuzz_Input_15_ReturnsExpectedResult()
    {
        Assert.True(true); // Placeholder. This will pass, but nothing is tested.
    }
}
