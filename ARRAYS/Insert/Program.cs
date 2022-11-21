using System;

int arrSize = 6;
int [] nums = new int[arrSize];
int index = 0;
int max_index = 0;
int buffer = 0;

// Filling up an array and printing to console
while (index < nums.Length){
    nums[index] = new Random().Next(0, 100);
    index++;
}
Console.Write("We've got a random array: ");
for (int i = 0; i < nums.Length; i++){
    Console.Write(nums[i] + " ");
}

//Sorting an array
index = 0;
while (index < arrSize - 1){
    for (int i = 0; i < arrSize; i++){
        if (nums[max_index] < nums[i]){
            max_index = i;
        }
    }
    buffer = nums[max_index];
    nums[max_index] = nums[arrSize -1];
    nums[arrSize - 1] = buffer;
    arrSize --;
    max_index = 0;
}

Console.WriteLine();
Console.Write("And now it is sorted: ");
for (int i = 0; i < nums.Length; i++){
    Console.Write(nums[i] + " ");
}