/*
Given an integer num, return the number of steps to reduce it to zero.
In one step, if the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.
*/

Console.Clear();

Console.Write("Enter a number to reduce to 0: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (num > 0) {
    if (num % 2 == 0) num = num / 2;
    else num --;
    count ++;
}

Console.WriteLine(count);
