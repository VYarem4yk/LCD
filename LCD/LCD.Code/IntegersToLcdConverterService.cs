namespace LCD.Code;
public class IntegersToLcdConverterService
{
    public string[,] GetLcdDigitTemplate(int digit)
    {
        return DigitTemplates.getTemplate(digit);      
    }

    public string[,] GetSpaceTemplate()
    {
        return DigitTemplates.getTemplate(-1);
    }

    public List<int> GetListOfDigitsFromInteger(int number)
    {
        var result = new List<int>();
        while (number != 0)
        {
            result.Add(number % 10);
            number /= 10;
        }
       return result;
    }

    public List<string[,]> GetArrayOfTemplatesFromInteger(int number)
    {
        var digitsTemplates = new List<string[,]>();
        var digits = GetListOfDigitsFromInteger(number);
        for (var i= digits.Count-1; i>=0; i--)
        {
            var template = GetLcdDigitTemplate(digits[i]);
            digitsTemplates.Add(template);
        }
        return digitsTemplates;
    }
}
