using System;

namespace arrayShift
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Testing via console - sanity testing off of the second example given
            int[] exampleArr = { 4, 8, 15, 23, 42 };
            int exampleInt = 16;

            int[] newArr = InsertShiftArray(exampleArr, exampleInt);

            for (int i = 0; i < newArr.Length; i++)
            {
                //should print out "4 8 15 16 23 42 "
                Console.Write(newArr[i] + " ");
            }

        }
        /// <summary>
        /// Given an array of integers and a single, separate integer, return a single array where the separate integer has been inserted in the middle of the array, with values at indices greater than the middle being shifted back one index.
        /// </summary>
        /// <param name="baseArray"> An array of integers of length n. The array does not need to be sorted. An empty integer array ([]) is acceptable input. </param>
        /// <param name="addedInteger"> A single integer. No restrictions on input.</param>
        /// <returns name="returnArray"> An array of integers of length n+1.</returns>
        public static int[] InsertShiftArray(int[] baseArray, int addedInteger)
        {
            // Declaration of return array; since another int is being inserted, the new array must be one index longer than the input array.
            int[] returnArray = new int[baseArray.Length +1];
            int middleIndex = (baseArray.Length + 1) / 2;
            //Since we're inserting into the middle, we can just copy elements from the input array to the new array until we hit the insertion point
            for(int i = 0; i < middleIndex; i++)
            {
                returnArray[i] = baseArray[i];
            }
            returnArray[middleIndex] = addedInteger;
            //Since we're shifting the values instead overwriting one, an offset is needed when assigning values into the new array
            for(int i = middleIndex; i < baseArray.Length; i++)
            {
                returnArray[i + 1] = baseArray[i];
            }
            return returnArray;
        }
    }
}
