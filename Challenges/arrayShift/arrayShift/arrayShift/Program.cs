using System;

namespace arrayShift
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] exampleArr = { 4, 8, 15, 23, 42 };
            int exampleInt = 16;

            int[] newArr = InsertShiftArray(exampleArr, exampleInt);

            for (int i = 0; i < newArr.Length; i++)
            {
                //should print out "4 8 15 16 23 42 "
                Console.Write(newArr[i] + " ");
            }

        }

        public static int[] InsertShiftArray(int[] baseArray, int addedInteger)
        {

            int[] returnArray = new int[baseArray.Length +1];
            int middleIndex = (baseArray.Length + 1) / 2;
            for(int i = 0; i < middleIndex; i++)
            {
                returnArray[i] = baseArray[i];
            }
            returnArray[middleIndex] = addedInteger;
            for(int i = middleIndex; i < baseArray.Length; i++)
            {
                returnArray[i + 1] = baseArray[i];
            }
            return returnArray;
        }
    }
}
