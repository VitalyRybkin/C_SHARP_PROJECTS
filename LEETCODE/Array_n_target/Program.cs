/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.
*/

Console.Clear();

int[] nums = { 2,5,5,11 };
int target = 10;
int[] target_arr = new int[2];
bool targeted = false;
for (int i = 0; i < nums.Length; i++) {
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] + nums[j] == target) {
            target_arr[0] = i;
            target_arr[1] = j;
            targeted = true;
            break;
        }
    if (targeted) break;
    }
if (targeted) break;
}

foreach (int item in target_arr) Console.Write(item +" ");

