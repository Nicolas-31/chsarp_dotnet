﻿internal class Program
{
    // Foreach loop - IsAnyWordLongerThan
    public static void Main(string[] args) { 
        var words1 = new string[] { "aaa", "bbbb", "ccccc" };
        var words2 = new string[] { "aaa", "bbbb", "ccccc" };
        var words3 = new string[] { };
        Console.WriteLine("The result is: " + IsAnyWordLongerThan(4, words1));
        Console.WriteLine("The result is: " + IsAnyWordLongerThan(5, words2));
        Console.WriteLine("The result is: " + IsAnyWordLongerThan(5, words3));
        Console.WriteLine("press any key to exist the program");
        Console.ReadKey();
    }

    private static bool IsAnyWordLongerThan(int length, string[] words)
    {
        foreach(var word in words)
        {
            if (word.Length > length) return true;
        }
        return false;
    }
}