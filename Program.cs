public class Program
{
    public static void Main(string[] args)
    {
        // User input / User cards
        string[] input = new string[] { "A", "A", "Q", "Q", "6" };

        string[] value = GetHighestPair(input);

        Console.WriteLine(string.Join(",", value));
    }

    private static string[] GetHighestPair(string[] input)
    {
        // Pre-defined cards
        string[] Cards = new string[] { "A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2" };

        // Validate User Inputs
        if (input.Length > 5 || !input.All(item => Cards.Contains(item)))
        {
            return new string[] { "Your input cards contain one or more invalid cards." };
        }

        // Order the input according to the required cards order.
        input = input.OrderBy(x => Array.IndexOf(Cards, x)).ToArray();

        // Get the highest pair.
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                return new string[] { "true", input[i] };
            }
        }

        return new string[] { "false" };
    }
}