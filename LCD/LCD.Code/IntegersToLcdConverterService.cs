namespace LCD.Code;
public class IntegersToLcdConverterService
{
    public string[,] CreateEmptyGridSpace()
    {
        return DigitTemplates.getTemplate(-1);      
    }
}
