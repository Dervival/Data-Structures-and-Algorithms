using System;

namespace arrayBinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Barrage testing in console - make sure that each element can be found
            int[] testArray = new int[] { 4, 8, 15, 16, 23, 42, 99 };
            int foundIndex;
            for (int i = 0; i < testArray.Length; i++)
            {
                foundIndex = BinarySearch(testArray, testArray[i]);
                Console.WriteLine("The element " + testArray[i] + " was found in the array at index " + foundIndex);
            }
            //Make sure that an element that can't be found returns -1
            foundIndex = BinarySearch(testArray, 222);
            Console.WriteLine("The element 222 was found in the array at index " + foundIndex);
        }

        public static int BinarySearch(int[] sortedArray, int target)
        {
            //if the array is empty, return -1
            if(sortedArray.Length < 1)
            {
                return -1;
            }
            //Binary search - split the array into left, middle, and right; test the value in the middle against the target, then recurse if not equal
            int mid = (sortedArray.Length) / 2;
            //if mid is outside of the bounds of the array, the element cannot be found
            if (mid < 0 || mid > sortedArray.Length - 1)
            {
                return -1;
            }
            //if the target is found at the middle index, return that index
            if (target == sortedArray[mid])
            {
                return mid;
            }
            //If the middle of the array is larger than the middle value, the value must be in the left side of the array if it's in the array
            else if(target < sortedArray[mid])
            {
                //middle has already been tested, so create a new array from all elements smaller than it
                int[] leftSubArray = new int[mid];
                for(int i = 0; i < mid; i++)
                {
                    leftSubArray[i] = sortedArray[i];
                }
                return BinarySearch(leftSubArray, target);
            }
            //If the middle of the array is smaller than the middle value, the value must be in the right side of the array if it's in the array
            else if(target > sortedArray[mid])
            {
                //left.Length + mid.Length + right.Length = sortedArray.Length
                //mid     +      1     + right.Length = sortedArray.Length
                //right.length = sortedArray.Length - mid - 1
                int[] rightSubArray = new int[sortedArray.Length - mid - 1];
                for(int i = 0; i < sortedArray.Length - mid - 1; i++)
                {
                    rightSubArray[i] = sortedArray[i + mid + 1];
                }
                int offsetIndex = BinarySearch(rightSubArray, target);
                if(offsetIndex < 0)
                {
                    return -1;
                }
                else
                {
                    return offsetIndex + mid + 1;
                }
            }
            return -1;
        }
    }
}
