# Insert and Shift an Array

## Challenge
Write a method called insertShiftArray which takes in an array and the value to be added. 
Without utilizing any of the array manipulation methods available in C#, return an array with the 
new value added at the middle index. 

## Approach & Efficiency

1. Big O Time = O(n) // Big O Space = O(n)
	- As this implementation is written in C# and the size of the array changes, we must make a new array to be 
	returned by the function; this requires a minimum of O(n) space for the algorithm, where n is the number of
	elements in the initial array. Since we are copying over all elements from the input array, we will need to 
	do n assignments from the original array, resulting in a minimum of O(n) time for the algorithm. 

## Solution

![Whiteboard for Insert and Shift an Array](../../assets/Challenge2_full.PNG)
Full picture of whiteboard. Apologies for the low quality of image.

![Algorithm for Insert and Shift an Array](../../assets/Challenge2_algorithm.PNG)
Detail picture of algorithm from whiteboard. Apologies for the low quality of image.