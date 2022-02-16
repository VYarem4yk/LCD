namespace LCD.Code;
public class IntegersToLcdConverterService
{
    public string[,] GetLcdDigitTemplate(int digit)
    {
        return DigitTemplates.getTemplate(digit);      
    }
}
