using System;

Console.WriteLine("Enter a word to check if it's a palindrome:");
string text = Console.ReadLine();
Console.WriteLine(sPalindrome(text));


static string sPalindrome(string text)
{

    text = text.ToLower();

    int start = 0;
    int end = text.Length - 1;


    while (start < end)
    {
        if (text[start] != text[end])
        {

            return "The text is not a palindrome.";
        }

        start++;
        end--;
    }
    return "The text is a palindrome.";

}

