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
    public void ConvertDividedByThree_6_Fizz()
    {
        var actual = converterService.ConvertDividedByThree(6);
        var expected = "Fizz";
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void ConvertDividedByThree_44_EmptyString()
    {
        var actual = converterService.ConvertDividedByThree(44);
        var expected = string.Empty;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ChangeDivisibleBy5Integers_6_12Fizz4BuzFizz()
    {
        var actual = converterService.FizzBuzzDetection(6);
        var expected = new string[] { "1", "2", fizz, "4", buzz, fizz };
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ChangeDivisibleBy15Integers_30_FizzBuzzArray()
    {
        var actual = converterService.FizzBuzzDetection(15);
        var expected = new string[] { "1", "2", fizz, "4", buzz, fizz, "7", "8", fizz, buzz, "11", fizz, "13", "14", fizz+buzz };
        Assert.Equal(expected, actual);
    }
}