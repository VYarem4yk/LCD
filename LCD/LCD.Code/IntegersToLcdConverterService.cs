﻿namespace LCD.Code;
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

    public List<int> GetArrayOfDigitsFromInteger(int number)
    {
        var result = new List<int>();
        while (number != 0)
        {
            result.Add(number % 10);
            number /= 10;
        }
       return result;
    }
}
