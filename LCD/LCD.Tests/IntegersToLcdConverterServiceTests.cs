using LCD.Code;
using Xunit;

namespace LCD.Tests;

public class IntegersToLcdConverterServiceTests
{

    [Fact]
    public void CreateEmptyGridSpace_emptyTemplate()
    {
        var lcdConverter = new IntegersToLcdConverterService();
        var emptyGrid = lcdConverter.GetSpaceTemplate();
        string[,] expectation = { { " " }, {  " " }, {  " " } };
        Assert.Equal(expectation, emptyGrid);
    }
    [Fact]
    public void CreateGridTemplate_0_zeroTemplate()
    {
        var lcdConverter = new IntegersToLcdConverterService();
        var actual = lcdConverter.GetLcdDigitTemplate(0);
        string[,] expectation = { { ".", "_", "." }, { "|", ".", "|" }, { "|", "_", "|" } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateGridTemplate_1_oneTemplate()
    {
        var lcdConverter = new IntegersToLcdConverterService();
        var actual = lcdConverter.GetLcdDigitTemplate(1);
        string[,] expectation = { { ".", ".", "." }, { ".", ".", "|" }, { ".", ".", "|" } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateGridTemplate_2_twoTemplate()
    {
        var lcdConverter = new IntegersToLcdConverterService();
        var actual = lcdConverter.GetLcdDigitTemplate(2);
        string[,] expectation = { { ".", "_", "." }, { ".", "_", "|" }, { "|", "_", "." } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateGridTemplate_3_threeTemplate()
    {
        var lcdConverter = new IntegersToLcdConverterService();
        var actual = lcdConverter.GetLcdDigitTemplate(3);
        string[,] expectation = { { ".", "_", "." }, { ".", "_", "|" }, { ".", "_", "|" } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateGridTemplate_4_fourTemplate()
    {
        var lcdConverter = new IntegersToLcdConverterService();
        var actual = lcdConverter.GetLcdDigitTemplate(4);
        string[,] expectation = { { ".", ".", "." }, { "|", "_", "|" }, { ".", ".", "|" } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateGridTemplate_5_fiveTemplate()
    {
        var lcdConverter = new IntegersToLcdConverterService();
        var actual = lcdConverter.GetLcdDigitTemplate(5);
        string[,] expectation = { { ".", "_", "." }, { "|", "_", "." }, { ".", "_", "|" } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateZeroGridSpace_6_sixTemplate()
    {
        var lcdConverter = new IntegersToLcdConverterService();
        var actual = lcdConverter.GetLcdDigitTemplate(6);
        string[,] expectation = { { ".", "_", "." }, { "|", "_", "." }, { "|", "_", "|" } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateZeroGridSpace_7_sevenTemplate()
    {
        var lcdConverter = new IntegersToLcdConverterService();
        var actual = lcdConverter.GetLcdDigitTemplate(7);
        string[,] expectation = { { ".", "_", "." }, { ".", ".", "|" }, { ".", ".", "|" } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateZeroGridSpace_8_eightTemplate()
    {
        var lcdConverter = new IntegersToLcdConverterService();
        var actual = lcdConverter.GetLcdDigitTemplate(8);
        string[,] expectation = { { ".", "_", "." }, { "|", "_", "|" }, { "|", "_", "|" } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateZeroGridSpace_9_nineTemplate()
    {
        var lcdConverter = new IntegersToLcdConverterService();
        var actual = lcdConverter.GetLcdDigitTemplate(9);
        string[,] expectation = { { ".", "_", "." }, { "|", "_", "|" }, { ".", ".", "|" } };
        Assert.Equal(expectation, actual);
    }
}