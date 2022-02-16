using LCD.Code;
using System;
using Xunit;

namespace LCD.Tests;

public class IntegersToLcdConverterServiceTests
{
    IntegersToLcdConverterService lcdConverter;
    public IntegersToLcdConverterServiceTests ()
    {
        lcdConverter = new IntegersToLcdConverterService();
    }
    [Fact]
    public void CreateEmptyGridSpace_emptyTemplate()
    {        
        var emptyGrid = lcdConverter.GetSpaceTemplate();
        string[,] expectation = { { " " }, {  " " }, {  " " } };
        Assert.Equal(expectation, emptyGrid);
    }
    [Fact]
    public void CreateGridTemplate_0_zeroTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(0);
        string[,] expectation = { { ".", "_", "." }, { "|", ".", "|" }, { "|", "_", "|" } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateGridTemplate_1_oneTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(1);
        string[,] expectation = { { ".", ".", "." }, { ".", ".", "|" }, { ".", ".", "|" } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateGridTemplate_2_twoTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(2);
        string[,] expectation = { { ".", "_", "." }, { ".", "_", "|" }, { "|", "_", "." } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateGridTemplate_3_threeTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(3);
        string[,] expectation = { { ".", "_", "." }, { ".", "_", "|" }, { ".", "_", "|" } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateGridTemplate_4_fourTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(4);
        string[,] expectation = { { ".", ".", "." }, { "|", "_", "|" }, { ".", ".", "|" } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateGridTemplate_5_fiveTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(5);
        string[,] expectation = { { ".", "_", "." }, { "|", "_", "." }, { ".", "_", "|" } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateZeroGridSpace_6_sixTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(6);
        string[,] expectation = { { ".", "_", "." }, { "|", "_", "." }, { "|", "_", "|" } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateZeroGridSpace_7_sevenTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(7);
        string[,] expectation = { { ".", "_", "." }, { ".", ".", "|" }, { ".", ".", "|" } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateZeroGridSpace_8_eightTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(8);
        string[,] expectation = { { ".", "_", "." }, { "|", "_", "|" }, { "|", "_", "|" } };
        Assert.Equal(expectation, actual);
    }
    [Fact]
    public void CreateZeroGridSpace_9_nineTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(9);
        string[,] expectation = { { ".", "_", "." }, { "|", "_", "|" }, { ".", ".", "|" } };
        Assert.Equal(expectation, actual);
    }

    [Fact]
    public void ThrowException_99_NullRefferenceException()
    {
        var actual = () => lcdConverter.GetLcdDigitTemplate(99);       
        var exception = Assert.Throws<ArgumentException>(actual);
        Assert.Equal("Parameter for GetLcdDigitTemplate should be digit 0-9", exception.Message);
    }
    [Fact]
    public void GetArrayOfDigitsFromInteger_1234567890_SameArray()
    {
        var actual = lcdConverter.GetArrayOfDigitsFromInteger(1234567890);
        int[] expectation = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        Assert.Equal(expectation, actual);
    }
}