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

    public int [] GetArrayOfDigitsFromInteger(int number)
    {
        return new int[0];
    }
}
