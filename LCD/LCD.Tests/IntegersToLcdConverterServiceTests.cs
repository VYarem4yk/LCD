using LCD.Code;
using System;
using System.Collections.Generic;
using Xunit;

namespace LCD.Tests;

public class IntegersToLcdConverterServiceTests
{
    IntegersToLcdConverterService lcdConverter;
    string[,] empty = { { " " }, { " " }, { " " } };
    string[,] one = { { ".", ".", "." }, { ".", ".", "|" }, { ".", ".", "|" } };
    string[,] two = { { ".", "_", "." }, { ".", "_", "|" }, { "|", "_", "." } };
    string[,] three = { { ".", "_", "." }, { ".", "_", "|" }, { ".", "_", "|" } };
    string[,] four = { { ".", ".", "." }, { "|", "_", "|" }, { ".", ".", "|" } };
    string[,] five = { { ".", "_", "." }, { "|", "_", "." }, { ".", "_", "|" } };
    string[,] six = { { ".", "_", "." }, { "|", "_", "." }, { "|", "_", "|" } };
    string[,] seven = { { ".", "_", "." }, { ".", ".", "|" }, { ".", ".", "|" } };
    string[,] eight = { { ".", "_", "." }, { "|", "_", "|" }, { "|", "_", "|" } };
    string[,] nine = { { ".", "_", "." }, { "|", "_", "|" }, { ".", ".", "|" } };
    string[,] zero = { { ".", "_", "." }, { "|", ".", "|" }, { "|", "_", "|" } };
    public IntegersToLcdConverterServiceTests ()
    {
        lcdConverter = new IntegersToLcdConverterService();
    }
    [Fact]
    public void CreateEmptyGridSpace_emptyTemplate()
    {        
        var emptyGrid = lcdConverter.GetSpaceTemplate();
        Assert.Equal(empty, emptyGrid);
    }
    [Fact]
    public void CreateGridTemplate_0_zeroTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(0);      
        Assert.Equal(zero, actual);
    }
    [Fact]
    public void CreateGridTemplate_1_oneTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(1);       
        Assert.Equal(one, actual);
    }
    [Fact]
    public void CreateGridTemplate_2_twoTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(2);      
        Assert.Equal(two, actual);
    }
    [Fact]
    public void CreateGridTemplate_3_threeTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(3);      
        Assert.Equal(three, actual);
    }
    [Fact]
    public void CreateGridTemplate_4_fourTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(4);      
        Assert.Equal(four, actual);
    }
    [Fact]
    public void CreateGridTemplate_5_fiveTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(5);       
        Assert.Equal(five, actual);
    }
    [Fact]
    public void CreateZeroGridSpace_6_sixTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(6);        
        Assert.Equal(six, actual);
    }
    [Fact]
    public void CreateZeroGridSpace_7_sevenTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(7);       
        Assert.Equal(seven, actual);
    }
    [Fact]
    public void CreateZeroGridSpace_8_eightTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(8);       
        Assert.Equal(eight, actual);
    }
    [Fact]
    public void CreateZeroGridSpace_9_nineTemplate()
    {
        var actual = lcdConverter.GetLcdDigitTemplate(9);
        Assert.Equal(nine, actual);
    }

    [Fact]
    public void ThrowException_99_NullRefferenceException()
    {
        var actual = () => lcdConverter.GetLcdDigitTemplate(99);       
        var exception = Assert.Throws<ArgumentException>(actual);
        Assert.Equal("Parameter for GetLcdDigitTemplate should be digit 0-9", exception.Message);
    }
    [Fact]
    public void GetListOfDigitsFromInteger_1234567890_SameList()
    {
        var actual = lcdConverter.GetListOfDigitsFromInteger(1234567890);
        List<int> expectation = new List<int> {0, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        Assert.Equal(expectation, actual);
    }

    [Fact]
    public void GetListOfTemplates_1234567890_ListOfTemplatesForInputDigits()
    {
        var actual = lcdConverter.GetArrayOfTemplatesFromInteger(1234567890);
        List<string[,]> expectation = new List<string[,]> {one, two, three, four, five, six, seven, eight, nine, zero};
        Assert.Equal(expectation, actual);
    }
}