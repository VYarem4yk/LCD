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
        return new List<string[,]> { new string[0,0]};
    }
}
