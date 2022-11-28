/*
You are given an m x n binary matrix mat of 1's (representing soldiers) and 0's (representing civilians). The soldiers are positioned in front of the civilians. That is, all the 1's will appear to the left of all the 0's in each row.

A row i is weaker than a row j if one of the following is true:

The number of soldiers in row i is less than the number of soldiers in row j.
Both rows have the same number of soldiers and i < j.
Return the indices of the k weakest rows in the matrix ordered from weakest to strongest.
*/


using System;
using System.Linq;
using System.Collections.Generic;

Console.Clear();

int[][] mat = { new int[] { 1, 1, 0, 0, 0 }, new int[] { 1, 1, 1, 1, 0 }, new int[] { 1, 0, 0, 0, 0 }, new int[] { 1, 1, 0, 0, 0 }, new int[] { 1, 1, 1, 1, 1 } };
//int[][] accounts = { new int[] { 1, 5 }, new int[] { 7, 3 }, new int[] { 3, 5 }};
//int[][] accounts = {new int[] { 2, 8, 7 }, new int[] { 7, 1, 3 }, new int[] { 1, 9, 5 }};

int k = 3;
List<int> res = new List<int>(k);
Dictionary<int, int> weakest_rows = new ();

int i = 0;
foreach (int[] rows in mat){
    int strength = 0;
    foreach (int num in rows) {
        strength += num;
    }
    weakest_rows.Add(i, strength);

    i++;
}

// 1
//List<KeyValuePair<int, int>> sorted_rows = weakest_rows.ToList();
//sorted_rows.Sort((x, y) => x.Value.CompareTo(y.Value));
// 2
var sorted_rows = weakest_rows.OrderBy(param => param.Value).Take(k);

int[] res_array = new int[k];
i = 0;
foreach (KeyValuePair<int, int> par in sorted_rows) {
    res_array[i] = par.Key;
    i++;
    }//res.Add(par.Key);

//int[] res_array = res.ToArray();

//return res_array;

foreach (var item in res_array) Console.WriteLine(item);


