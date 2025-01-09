public static class Divisors
{
    /// <summary>
    /// Entry point for the Divisors class
    /// </summary>
    public static void Run()
    {
        List<int> list = FindDivisors(80);
        Console.WriteLine("<List>{" + string.Join(", ", list) + "}"); // <List>{1, 2, 4, 5, 8, 10, 16, 20, 40}
        List<int> list1 = FindDivisors(79);
        Console.WriteLine("<List>{" + string.Join(", ", list1) + "}"); // <List>{1}
    }

    /// <summary>
    /// Create a list of all divisors for a number including 1
    /// and excluding the number itself. Modulo will be used
    /// to test divisibility.
    /// </summary>
    /// <param name="number">The number to find the divisor</param>
    /// <returns>List of divisors</returns>
    private static List<int> FindDivisors(int number)
    {
        List<int> results = new();
        // TODO problem 1

        for (int i = 1; i <= Math.Sqrt(number); i++) // Loop from 1 to sqrt(number)
        {
            if (number % i == 0) // check if i is a divisor
            {
                results.Add(i);
                int pair = number / i; // calculate the paired divisor for i

                if (pair != number) // checking if pair is not a number
                {
                    results.Add(pair);
                }
            }
        }
        results.Sort();
        return results;
    }
}