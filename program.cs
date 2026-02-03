using System;

class StringUtility
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string s = Console.ReadLine();
        string rev = "";

        for (int i = s.Length - 1; i >= 0; i--)
        {
            rev += s[i];
        }

        Console.WriteLine("Reversed String: " + rev);

        if (s == rev)
            Console.WriteLine("Palindrome String");
        else
            Console.WriteLine("Not a Palindrome");

        int vowels = 0;
        foreach (char c in s.ToLower())
        {
            if ("aeiou".Contains(c))
                vowels++;
        }

        Console.WriteLine("Vowel Count: " + vowels);
    }
}
