using System.Diagnostics;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Create an array to store the results, with the specified length
        var result = new double[length];

        // Multiply the number by each integer from 1 to 'length' using a for loop
        // (Iteration starts from 1 to include the last number)
        for (int i = 1; i <= length; i++)
        {
            double newNum = number * i; // Calculate the multiple of the number
            result[i - 1] = newNum; // Store it in the array. Index starts from 0
        }
        return result; // Return an array of multiples of a number
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // get last elements from the list
        var lastEmel = data.GetRange(data.Count - amount, amount);

        // get the remaining elements
        var startingElem = data.GetRange(0, data.Count - amount);

        // clear list and add slices back
        data.Clear();
        data.AddRange(lastEmel);
        data.AddRange(startingElem);
    }
}
