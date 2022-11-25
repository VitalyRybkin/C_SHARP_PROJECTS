/*
BUBBLE SORTING - moving larger elems to the end, smaller - to the beginning
*/

using System;
using System.Diagnostics;

// Checking execution time
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

Console.Clear();
Console.WriteLine("BUBBLE SORTING\n");

// Fill up an array with random nums
int index = 0;
int arrSize = 6;
int [] nums = new int[arrSize];
while (index < nums.Length) {
    nums[index] = new Random().Next(1, 100);
    index ++;
}

// Printing an array to be sorted
Console.Write("Array we've started from.. ");
for (int i = 0; i < nums.Length; i++){
    Console.Write(nums[i] + " ");
}

//Sorting an array
index = 0;
int buffer = 0;
while (index < arrSize - 1) {
    bool is_sorted = true;
    for (int i = 0; i < arrSize - 1; i++) {
        if (nums[i] > nums[i + 1]){
            buffer = nums[i];
            nums[i] = nums[i + 1];
            nums[i + 1] = buffer;
            is_sorted = false;
        }
    }
    if (is_sorted) {
    break;
    }
arrSize --;
}

// PRINTING SORTED ARRAY
Console.WriteLine();
Console.Write("Now we've sorted an array. ");
for (int i = 0; i < nums.Length; i++){
    Console.Write(nums[i] + " ");
}

//Checking and printing code execution time
stopwatch.Stop();
Console.WriteLine();
Console.WriteLine("\nCode execution time is " + stopwatch.ElapsedMilliseconds + " ms\n");
