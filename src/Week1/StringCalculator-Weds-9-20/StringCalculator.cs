
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
            string[] numbersArray;

            if (numbers.Contains(","))
            {
                numbersArray = numbers.Split(',');
            }
            else
            {
                numbersArray = new string[] { numbers };
            }

            int sum = 0;
            foreach (string num in numbersArray)
            {
                sum += int.Parse(num);
            }
            return sum;
        }
    }
}

