/*
COCKTAIL (SHAKER) SORTING - bubble sorting array algorythm but moving from both ends
*/

using System;
using System.Diagnostics;

// Starting code execution time evaluation
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

Console.Clear();
Console.WriteLine("COCKTAIL SORTING");

// Filling array up with random nums
int arrSize = 6;
int[] nums = new int[arrSize];
int ind = 0;
while (ind < nums.Length)
{
    nums[ind] = new Random().Next(1, 100);
    ind++;
}

//Printing random array to be sorted
Console.Write("\nAn array to be sorted:");
foreach (var item in nums) Console.Write(" " + item);

// Sorting an array
int start_idx = 0;
int end_idx = arrSize - 1;
int temp = 0;
while (start_idx < end_idx)
{
    //bool is_sorted = true;
    for (int i = start_idx; i < end_idx; i++)
    {
        if (nums[i] > nums[i + 1])
        {
            temp = nums[i + 1];
            nums[i + 1] = nums[i];
            nums[i] = temp;
            //is_sorted = false;
        }
    }
    for (int i = end_idx; i > start_idx; i--)
    {
        if (nums[i] < nums[i - 1])
        {
            temp = nums[i];
            nums[i] = nums[i - 1];
            nums[i - 1] = temp;
            //is_sorted = false;
        }
    }
    //if (is_sorted) break;
    end_idx--;
    start_idx++;
}

// PRINTING SORTED ARRAY
Console.WriteLine();
Console.Write("And now array sorted.: ");
for (int i = 0; i < nums.Length; i++)
{
    Console.Write(nums[i] + " ");
}

//Checking and printing code execution time
Console.WriteLine();
stopwatch.Stop();
Console.WriteLine("\nCode execution time is " + stopwatch.ElapsedMilliseconds + " ms\n");