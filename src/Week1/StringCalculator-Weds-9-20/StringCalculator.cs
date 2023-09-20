
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }
        else
        {
            string[] numbersArray = numbers.Split(',');
            int sum = 0;
            foreach (string num in numbersArray)
            {
                sum += int.Parse(num);
            }
            return sum;
        }
    }
}

