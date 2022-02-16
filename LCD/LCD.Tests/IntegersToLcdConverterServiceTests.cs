using LCD.Code;
using Xunit;

namespace LCD.Tests;

public class IntegersToLcdConverterServiceTests
{

    [Fact]
    public void CreateEmptyGridSpace_minus1_emptyTemplate()
    {
        var lcdConverter = new IntegersToLcdConverterService();
        var emptyGrid = lcdConverter.GetLcdDigitTemplate(-1);
        string[,] expectation = { { ".", ".", "." }, { ".", ".", "." }, { ".", ".", "." } };
        Assert.Equal(expectation, emptyGrid);
    }
    [Fact]
    public void CreateZeroGridSpace_0_zeroTemplate()
    {
        var lcdConverter = new IntegersToLcdConverterService();
        var actual = lcdConverter.GetLcdDigitTemplate(0);
        string[,] expectation = { { ".", "_", "." }, { "|", ".", "|" }, { "|", "_", "|" } };
        Assert.Equal(expectation, actual);
    }
}