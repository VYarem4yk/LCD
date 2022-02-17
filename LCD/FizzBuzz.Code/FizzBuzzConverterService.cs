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

        for (int i = 0; i < number; i++)
        {
            if((i+1) % 3 == 0)
            {
                result[i] = "Fizz";
            }
            else if ((i+1) % 5 == 0)           
            {
                result[i] = "Buzz";
            }
            else
            {
                result[i] = (i + 1).ToString();
            }
        }
        return result;
    }
}
