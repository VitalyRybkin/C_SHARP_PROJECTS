/*
You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.
A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.
*/

Console.Clear();

int[][] accounts = { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 }};
//int[][] accounts = { new int[] { 1, 5 }, new int[] { 7, 3 }, new int[] { 3, 5 }};
//int[][] accounts = {new int[] { 2, 8, 7 }, new int[] { 7, 1, 3 }, new int[] { 1, 9, 5 }};


int wealth = 0;
foreach (int[] row in accounts) {
    int sum = 0;
    foreach (int num in row) {
        sum += num;
    }
    if (sum > wealth) wealth = sum; 
}

Console.WriteLine(wealth);
