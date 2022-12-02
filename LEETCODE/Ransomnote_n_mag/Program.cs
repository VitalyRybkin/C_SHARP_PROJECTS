/*
Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.
*/

using System.Text;

Console.Clear();

Console.Write("Enter a string RANSOMNOTE: " );
string ransomNote = Console.ReadLine() ?? String.Empty;
Console.Write("Enter a string MAGAZINE: " );
string magazine = Console.ReadLine() ?? String.Empty;
List<char> chars_from_ran = new List<char>(ransomNote);
List<char> chars_from_mag = new List<char>(magazine);

bool is_constructed = false;
if (chars_from_ran.Count < chars_from_mag.Count) {
    while (chars_from_ran.Count != 0) {
        is_constructed = false;
        for (int j = 0; j < chars_from_mag.Count; j++){
            //if (chars_from_ran.Count == 0) break;
            if (chars_from_ran[0] == chars_from_mag[j] && chars_from_ran.Count != 0) {
                chars_from_ran.RemoveAt(0);
                chars_from_mag.RemoveAt(j);
                is_constructed = true;
            }
            if (is_constructed || chars_from_ran.Count == 0) break;
        }
        if (is_constructed == false) break;
    }
if (is_constructed) Console.WriteLine($"RansomNote \"{ransomNote}\" is constructed from magazine \"{magazine}\"!");
else Console.WriteLine($"RansomNote \"{ransomNote}\" can't be constructed from magazine \"{magazine}\" !");
}
else Console.WriteLine($"Magazine \"{magazine}\" is shorter, than ransomNote \"{ransomNote}\""!);


foreach (char item in chars_from_ran) Console.Write(item + " ");
Console.WriteLine();
foreach (char item in chars_from_mag) Console.Write(item + " ");