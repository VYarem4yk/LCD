using FizzBuzz.Code;
using Xunit;

namespace FizzBuzz.Tests;

public class FizzBuzzConverterServiceTests
{
    FizzBuzzConverterService converterService;
    private string fizz = "Fizz";
    private string buzz = "Buzz";
    
    public FizzBuzzConverterServiceTests()
    {
        converterService = new FizzBuzzConverterService();
    }
    [Fact]
    public void GetArrayOfIntegers_5_12345()
    {
        var actual = converterService.GetIntegers(5);
        var expected = new int[] { 1, 2, 3, 4, 5 };
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ChageDivisibleBy3Integers_6_12Fizz45Fizz()
    {
        var actual = converterService.FizzBuzzDetection(5);
        var expected = new string[] { "1", "2", "Fizz", "4", "5", "Fizz" };
        Assert.Equal(expected, actual);
    }
}