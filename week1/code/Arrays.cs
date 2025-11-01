using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Arrays
{
    /*
     * --------------------------------------------------------
     * Part 1: MultiplesOf
     * --------------------------------------------------------
     * PLAN:
     * 1. Receive two inputs: 
     *      - start: the base number (e.g., 3)
     *      - count: how many multiples to generate (e.g., 5)
     * 2. Create a new array of type double with a size equal to 'count'.
     * 3. Use a for loop to fill each element in the array:
     *      - The value at index i should be (start * (i + 1)).
     *      - Example: if start = 3 and count = 5 → array = [3, 6, 9, 12, 15]
     * 4. Return the array at the end of the function.
     */

    public static double[] MultiplesOf(double start, int count)
    {
        // Step 1: Create a new array with length equal to count
        double[] result = new double[count];

        // Step 2: Use a loop to fill the array with multiples
        for (int i = 0; i < count; i++)
        {
            // Each element is the start number times (i + 1)
            result[i] = start * (i + 1);
        }

        // Step 3: Return the completed array
        return result;
    }


    /*
     * --------------------------------------------------------
     * Part 2: RotateListRight
     * --------------------------------------------------------
     * PLAN:
     * 1. Receive two inputs:
     *      - data: a List<T> (the list of numbers or items)
     *      - amount: how many places to rotate to the right
     * 
     * 2. Understand rotation:
     *      - Rotating right by 'amount' means that the last 'amount' 
     *        elements move to the front of the list.
     *      - Example:
     *          data = [1,2,3,4,5,6,7,8,9], amount = 3
     *          last part = [7,8,9]
     *          front part = [1,2,3,4,5,6]
     *          result = [7,8,9,1,2,3,4,5,6]
     *
     * 3. Use list slicing with GetRange():
     *      - lastPart = data.GetRange(data.Count - amount, amount)
     *      - firstPart = data.GetRange(0, data.Count - amount)
     * 
     * 4. Clear the original list and rebuild:
     *      - data.Clear()
     *      - data.AddRange(lastPart)
     *      - data.AddRange(firstPart)
     * 
     * 5. Done! The list is now rotated.
     */

    public static void RotateListRight<T>(List<T> data, int amount)
    {
        // Edge case: if list is empty or amount == 0, do nothing
        if (data == null || data.Count == 0 || amount == 0)
        {
            return;
        }

        // Step 1: Handle amount larger than list size (use modulo)
        amount = amount % data.Count;

        // Step 2: Get the slices
        List<T> lastPart = data.GetRange(data.Count - amount, amount);
        List<T> firstPart = data.GetRange(0, data.Count - amount);

        // Step 3: Clear and rebuild list
        data.Clear();
        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }
}
