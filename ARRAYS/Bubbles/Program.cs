using System;

int arrSize = 6;
int [] nums = new int[arrSize];
int index = 0;
int buffer = 0;

// Fill up an array with nums
while (index < nums.Length) {
    nums[index] = new Random().Next(1, 100);
    index ++;
}

// Printing an array to be sorted
Console.Write("Array we've started from: ");
for (int i = 0; i < nums.Length; i++){
    Console.Write(nums[i] + " ");
}

index = 0;
while (index < arrSize - 1) {
    for (int i = 0; i < arrSize - 1; i++) {
        if (nums[i] > nums[i + 1]){
            buffer = nums[i];
            nums[i] = nums[i + 1];
            nums[i + 1] = buffer;
        }
    }
index ++;
arrSize --;
}

// Printing sorted array
Console.WriteLine();
Console.Write("We've sorted an array: ");
for (int i = 0; i < nums.Length; i++){
    Console.Write(nums[i] + " ");
}