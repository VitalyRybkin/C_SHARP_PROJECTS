/*
Given a string s, find the length of the longest substring without repeating characters.
 */

Console.Clear();

string s = "abcabdee";
string sub_s = String.Empty;
int max_length = 0;

for (int a = 0; a < s.Length; a++)
{
    sub_s = String.Empty;
    for (int i = a; i < s.Length; i++)
    {
        if (sub_s.Length == 0) sub_s += s[i];
        else
        {
            if (sub_s.Contains(s[i]))
            {
                break;
            }
            else sub_s += s[i];
        }
    }
    if (sub_s.Length > max_length)
    {
        max_length = sub_s.Length;
    }
}

Console.WriteLine(sub_s + " " + max_length);
