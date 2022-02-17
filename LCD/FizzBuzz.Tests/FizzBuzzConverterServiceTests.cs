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
    public void GetArrayOfIntegers()
    {
        var actual = converterService.GetIntegers(5);
        var expected = new int[] { 1, 2, 3, 4, 5 };
        Assert.Equal(expected, actual);
    }
}