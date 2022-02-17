using FizzBuzz.Code;
using Xunit;

namespace FizzBuzz.Tests;

public class FizzBuzzConverterServiceTests
{
    private const string fizz = "Fizz";
    private const string buzz = "Buzz";
    FizzBuzzConverterService converterService;

    
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
    public void ChangeDivisibleBy3Integers_6_12Fizz45Fizz()
    {
        var actual = converterService.FizzBuzzDetection(4);
        var expected = new string[] { "1", "2", fizz, "4"};
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ChangeDivisibleBy5Integers_6_12Fizz4BuzFizz()
    {
        var actual = converterService.FizzBuzzDetection(6);
        var expected = new string[] { "1", "2", fizz, "4", buzz, fizz };
        Assert.Equal(expected, actual);
    }
}