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
        // Plan:
        // 1. Create an array of doubles with the size equal to length.
        // 2. Use a loop that runs from 0 to length - 1.
        // 3. For each position in the array, calculate the multiple of the number.
        // 4. The multiple can be calculated by multiplying number by (index + 1).
        // 5. Store the value in the array.
        // 6. After filling the array, return it.

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
    }

        /// <summary>
        /// Rotate the 'data' to the right by the 'amount'.
        /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Plan:
        // 1. Find the index where the last 'amount' elements start.
        // 2. Use GetRange to copy the last 'amount' elements into a temporary list.
        // 3. Remove those elements from the original list using RemoveRange.
        // 4. Insert the saved elements at the beginning of the list using InsertRange.
        // 5. The list will now be rotated to the right.

        int startIndex = data.Count - amount;
        List<int> temp = data.GetRange(startIndex, amount);
        data.RemoveRange(startIndex, amount);
        data.InsertRange(0, temp);
    }
}   