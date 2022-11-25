/*
INSERTION SORTING - checking an array by each elem and moving it to a right pos among sorted elems
This version findes a larger elem and moves it to the end of array swapping elems
*/

using System;
using System.Diagnostics;

// Checking execution time
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

Console.Clear();
Console.WriteLine("INSERTION SORTING\n");

// Filling up an array with random nums and printing to console
int arrSize = 6;
int [] nums = new int[arrSize];
int idx = 0;
while (idx < nums.Length){
    nums[idx] = new Random().Next(0, 100);
    idx++;
}
Console.Write("We've got a random array. ");
for (int i = 0; i < nums.Length; i++){
    Console.Write(nums[i] + " ");
}

//Sorting an array
idx = 0;
int max_idx = 0;
int temp = 0;
while (idx < arrSize - 1){
    for (int i = 0; i < arrSize; i++){
        if (nums[max_idx] < nums[i]){
            max_idx = i;
        }
    }
    temp = nums[max_idx];
    nums[max_idx] = nums[arrSize -1];
    nums[arrSize - 1] = temp;
    arrSize --;
    max_idx = 0;
}

// PRINTING SORTED ARRAY
Console.WriteLine();
Console.Write("And now array sorted..... ");
for (int i = 0; i < nums.Length; i++){
    Console.Write(nums[i] + " ");
}

//Checking and printing code execution time
Console.WriteLine();
stopwatch.Stop();
Console.WriteLine("\nCode execution time is " + stopwatch.ElapsedMilliseconds + " ms\n");
