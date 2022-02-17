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

    public string ConvertNumberToLCD(int number)
    {
        var result = string.Empty;
       var templates = GetArrayOfTemplatesFromInteger(number);
        for (var line= 0; line < 3; line++)
        {
            for(var digit = 0; digit<templates.Count; digit++)
            {
                for(var symbol = 0; symbol < 3; symbol++)
                {
                    result+= templates[digit][line,symbol];
                }
                if (digit != templates.Count-1)
                    result += " ";
            }
            if (line < 2)
                result += "\n";
        }
        return result;
    }
}
