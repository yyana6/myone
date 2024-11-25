using System;

public class StringComparisonExample
{
    public static void Main(string[] args)
    {
        string i = "Cat";
        string str2 = "cat";
        string str3 = "Cat";
        string str4 = "Dog";
        string str5 = "at";


        // Операторы == и !=
        Console.WriteLine($"'{i}' == '{str2}': {i == str2}"); 
        Console.WriteLine($"'{i}' == '{str3}': {i == str3}"); 
        Console.WriteLine($"'{i}' != '{str4}': {i != str4}"); 

        // Метод Equals()
        Console.WriteLine($"'{i}'.Equals('{str2}'): {i.Equals(str2)}"); 
        Console.WriteLine($"'{i}'.Equals('{str3}', StringComparison.OrdinalIgnoreCase): {i.Equals(str3, StringComparison.OrdinalIgnoreCase)}"); // True (нечувствителен к регистру)

        // Метод Compare()
        Console.WriteLine($"'{i}'.CompareTo('{str2}'): {i.CompareTo(str2)}"); // > 0 (чувствителен к регистру)
        Console.WriteLine($"'{i}'.CompareTo('{str3}'): {i.CompareTo(str3)}"); // 0
        Console.WriteLine($"'{i}'.CompareTo('{str4}'): {i.CompareTo(str4)}"); // < 0 (чувствителен к регистру)


        // Метод CompareOrdinal()
        Console.WriteLine($"string.CompareOrdinal('{i}', '{str2}'): {string.CompareOrdinal(i, str2)}"); // > 0 (чувствителен к регистру)
        Console.WriteLine($"string.CompareOrdinal('{i}', '{str3}'): {string.CompareOrdinal(i, str3)}"); // 0


        // Метод IndexOf()
        Console.WriteLine($"'{i}'.IndexOf('l'): {i.IndexOf('l')}"); // 2

        // Метод Contains()
        Console.WriteLine($"'{i}'.Contains('{str5}'): {i.Contains(str5)}"); // True
    }
}


