using System;

namespace arrayBinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int BinarySearch(int[] sortedArray, int target)
        {
            //if the array is empty, return -1
            if(sortedArray.Length < 1)
            {
                return -1;
            }
            //Binary search - split the array into left, middle, and right; test the value in the middle against the target, then recurse if not equal
            int mid = (sortedArray.Length + 1) / 2;
            if(target == sortedArray[mid])
            {
                return mid;
            }
            //If the middle of the array is larger than the middle value, the value must be in the left side of the array if it's in the array
            else if(target < sortedArray[mid])
            {
                //middle has already been tested, so create a new array from all elements smaller than it
                int[] leftSubArray = new int[mid - 1];
                for(int i = 0; i < mid; i++)
                {
                    leftSubArray[i] = sortedArray[i];
                }
                return BinarySearch(leftSubArray, target);
            }
            //If the middle of the array is smaller than the middle value, the value must be in the right side of the array if it's in the array
            else
            {
                //left.Length + mid.Length + right.Length = sortedArray.Length
                //mid - 1     +      1     + right.Length = sortedArray.Length
                //right.length = sortedArray.Length - mid
                int[] rightSubArray = new int[sortedArray.Length - mid];
                for(int i = 0; i < sortedArray.Length - mid; i++)
                {
                    rightSubArray[i] = sortedArray[i + mid];
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
        }
    }
}
