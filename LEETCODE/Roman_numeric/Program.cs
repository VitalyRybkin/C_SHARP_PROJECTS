/*
Given a roman numeral, convert it to an integer.
*/


using System;
using System.Text;

Console.Clear();

// Enter a roman numeric num
Console.Write("Enter roman numeric simbols: ");
string get_string = Console.ReadLine() ?? "";
get_string = get_string.ToUpper();

// Making char array 
char[] get_chars = get_string.ToCharArray(0, get_string.Length);
//char[] get_chars = get_string.ToCharArray();
//char[] get_chars = get_string.ToArray();

//Checking entered symbols from roman numeric list
foreach (char item in get_chars)
{
    if (item != 'M' & item != 'D' & item != 'C' & item != 'L' & item != 'X' & item != 'V' & item != 'I') {
        Console.WriteLine("Now such a roman numeric number! Try again!");
        Environment.Exit(0);
    }
}

//Checking sequence of sybols  
char[] char_sqnc = {'M', 'D', 'C', 'L', 'X', 'V', 'I'};
int idx = 0;
while (idx < get_chars.Length) {
    int char_sqnc_idx = 0;
    int char_sqnc_idx_next = 0;
    if (idx < get_chars.Length - 1) {
        for (int j = 0; j < char_sqnc.Length ; j++) {
            if (char_sqnc[j] == get_chars[idx]) char_sqnc_idx = j;
            if (char_sqnc[j] == get_chars[idx + 1]) char_sqnc_idx_next = j;
        }
    } 

    if (char_sqnc_idx > char_sqnc_idx_next){
        string temp = get_chars[idx].ToString() + get_chars[idx + 1].ToString();
        //Console.WriteLine(char_sqnc_idx + " " + char_sqnc_idx_next + " " + temp);
        if (temp != "IV" & temp != "IX" & temp != "XL" & temp != "XC" & temp != "CD" & temp != "CM" ) {
            Console.WriteLine("Something went wrong! Try again!");
            Environment.Exit(0);
        }
    }
    idx++;
} 

// Evaluating array by elems and getting sum
int get_num = 0;
int get_num_prev = 0;
int res = 0;
for (int i = 0; i < get_chars.Length; i++){
    switch (get_chars[i])
    {
        case 'I':
            get_num = 1;
            break;
        case 'V':
            get_num = 5;
            break;
        case 'X':
            get_num = 10;
            break;
        case 'L':
            get_num = 50;
            break;
        case 'C':
            get_num = 100;
            break;
        case 'D':
            get_num = 500;
            break;
        case 'M':
            get_num = 1000;
            break;
    }
    if (idx > 0 && get_num > get_num_prev) {
        res = res - get_num_prev * 2 + get_num;
    }
    else res += get_num;
    get_num_prev = get_num;

}

Console.Write("For ");
foreach (char item in get_chars) Console.Write(item);
Console.WriteLine(" result is " + res);

