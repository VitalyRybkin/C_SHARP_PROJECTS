/*
INSERTION SORTING - checking an array by each elem and moving it to a right pos among sorted elems
*/

using System;
using System.Diagnostics;
using System.Collections.Generic;

//Code executoion time diagnostic
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

Console.Clear();
Console.WriteLine("INSERTION SORTING");

//Fills an array up with random nums
int arrSize = 10;
int[] nums = new int[arrSize];
int idx = 0;
while (idx < arrSize)
{
    nums[idx] = new Random().Next(1, 100);
    idx++;
}

//Array output
Console.Write("\nAn array to be sorted: ");
foreach (int item in nums) Console.Write(item + " ");
Console.WriteLine();

//Copy an array to list, then sorting
idx = 1;
List<int> numsList = new List<int>(arrSize);
numsList = nums.ToList<int>();
while (idx < arrSize)
{
    for (int i = 0; i < idx; i++)
    {
        if (numsList[idx] < numsList[i])
        {
            numsList.Insert(i, numsList[idx]);
            numsList.RemoveAt(idx + 1);
        }
    }
    idx++;
}

//Copying list back to array
nums = numsList.ToArray();

//Soerted array output
Console.Write("Now sorted array is... ");
foreach (int item in nums) Console.Write(item + " ");

//Code execution time
stopwatch.Stop();
Console.WriteLine("\n\nCode execution time is " + stopwatch.ElapsedMilliseconds + " ms\n");