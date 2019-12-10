using System;
using System.Threading;
using System.Collections.Generic;


class Program
{
 public static bool PalindromeSeeker(string palindrome)
        {
            string initial = palindrome.Substring(0, palindrome.Length/2);
            char[] arr = palindrome.ToCharArray();
            Array.Reverse(arr);
            string compare = new string(arr);
            string check = compare.Substring(0, compare.Length/2);
            return initial.Equals(check);
        }
static void Main()
    {
        Console.WriteLine("Enter a word to check if its a Palindrome!");
        string word = Console.ReadLine();
        word = newword.PalindromeSeeker();

        Console.WriteLine(PalindromeSeeker);

        
    }
}