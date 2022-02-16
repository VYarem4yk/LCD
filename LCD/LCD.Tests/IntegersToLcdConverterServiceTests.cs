using LCD.Code;
using Xunit;

namespace LCD.Tests;

public class IntegersToLcdConverterServiceTests
{
    [Fact]
    public void CreateEmptyGridSpace_null_zeroTemplate()
    {
        var lcdConverter = new IntegersToLcdConverterService();
        var emptyGrid = lcdConverter.CreateEmptyGridSpace();
        const string o = ".";
        string[,] expectation = { { o, o, o }, { o, o, o }, { o, o, o } };
        Assert.Equal(expectation, emptyGrid);
    }
}