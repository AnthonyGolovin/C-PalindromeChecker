using System;
using System.Threading;
using System.Collections.Generic;


public class Checker
{
    public string Palindrome;

    public Checker(string palindrome)
    {
        Palindrome = palindrome;
    }
public bool palindromeSeeker()
        {
            string initial = Palindrome.Substring(0, Palindrome.Length/2);
            char[] arr = Palindrome.ToCharArray();
            Array.Reverse(arr);
            string compare = new string(arr);
            string check = compare.Substring(0, compare.Length/2);
            return initial.Equals(check);
        }
}
class Program
{
public static void Main()
    {
        Console.WriteLine("Enter a word to check if its a Palindrome!");
        string palindrome = Console.ReadLine();
        Checker checker = new Checker(palindrome);
        bool palindromeChecker = checker.palindromeSeeker();
        Console.WriteLine(palindromeChecker);
    
    }
}