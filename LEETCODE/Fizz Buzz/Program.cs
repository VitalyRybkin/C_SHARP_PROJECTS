/*
Given an integer n, return a string array answer (1-indexed) where:

answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
answer[i] == "Fizz" if i is divisible by 3.
answer[i] == "Buzz" if i is divisible by 5.
answer[i] == i (as a string) if none of the above conditions are true.
*/

Console.Clear();

Console.Write("Enter 'n' as an array size: ");
int n = Convert.ToInt32(Console.ReadLine());

List<string> answer = new List<string>(n);

string to_list;
for (int i = 1; i <= n; i++){
    if (i % 3 == 0 && i % 5 == 0) to_list = "FizzBuzz";
    else if (i % 5 == 0) to_list = "Buzz";
    else if (i % 3 == 0) to_list = "Fizz";
    else to_list = i.ToString();
    answer.Add(to_list);
}

foreach (string item in answer) Console.Write(item + " ");