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
            var temp = string.Empty;
            temp += ConvertDividedByThree(i + 1);
            temp += ConvertDividedByFive(i + 1);
            if(temp.Length == 0)
                temp += (i + 1).ToString();

            result[i] = temp;
        }
        return result;
    }

    public string ConvertDividedByThree(int number)
    {
        if (number % 3 == 0)
            return "Fizz";
        else
            return "";
    }

    public string ConvertDividedByFive(int number)
    {
        if (number % 5 == 0)
            return "Buzz";
        else
            return "";
    }
}
