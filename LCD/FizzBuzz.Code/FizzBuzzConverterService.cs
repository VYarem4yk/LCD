namespace FizzBuzz.Code;
public class FizzBuzzConverterService
{
    public int[] GetIntegers(int number)
    {
        var result = new int[number];
        for (int i = 0; i < number; i++)
        {
            result[i] = i+1;
        }
        return result;
    }

    public string[] FizzBuzzDetection(int number)
    {
        var result = new string[number];
        return result;
    }
}
