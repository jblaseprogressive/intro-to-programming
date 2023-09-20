namespace StringCalculator
{
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
                // Check if the string starts with a custom delimiter declaration
                if (numbers.StartsWith("//"))
                {
                    // Find the end of the delimiter declaration
                    int delimiterEnd = numbers.IndexOf("\n");
                    if (delimiterEnd != -1)
                    {
                        // Extract the custom delimiter and remove the declaration
                        string delimiter = numbers.Substring(2, delimiterEnd - 2);
                        numbers = numbers.Substring(delimiterEnd + 1); // Remove the declaration line
                        string[] separators = new string[] { delimiter, "\n" }; // Use the custom delimiter
                        string[] numbersArray = numbers.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                        int sum = 0;
                        foreach (string num in numbersArray)
                        {
                            sum += int.Parse(num);
                        }
                        return sum;
                    }
                }

                // If no custom delimiter is specified, use the default delimiters (',', '\n')
                string[] separators = new string[] { ",", "\n" };
                string[] numbersArray = numbers.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                int sum = 0;
                foreach (string num in numbersArray)
                {
                    sum += int.Parse(num);
                }
                return sum;
            }
        }
    }
}
