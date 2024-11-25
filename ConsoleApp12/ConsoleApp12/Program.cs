using System;

public class SimpleStringComparison
{
  public static void Main(string[] args)
  {
    string str1 = "hello";
    string str2 = "hello";
    string str3 = "Hello";

    // Операторы == и !=
    Console.WriteLine($"str1 == str2: {str1 == str2}"); // True
    Console.WriteLine($"str1 == str3: {str1 == str3}"); // False (чувствителен к регистру)

    // Метод Equals()
    Console.WriteLine($"str1.Equals(str2): {str1.Equals(str2)}"); // True
    Console.WriteLine($"str1.Equals(str3): {str1.Equals(str3)}"); // False (чувствителен к регистру)
    Console.WriteLine($"str1.Equals(str3, StringComparison.OrdinalIgnoreCase): {str1.Equals(str3, StringComparison.OrdinalIgnoreCase)}"); //True (нечувствителен к регистру)


    // Метод CompareTo()
    Console.WriteLine($"str1.CompareTo(str2): {str1.CompareTo(str2)}"); // 0 (равны)
    Console.WriteLine($"str1.CompareTo(str3): {str1.CompareTo(str3)}"); // > 0 (str1 > str3, чувствителен к регистру)

    // Метод CompareOrdinal()
    Console.WriteLine($"string.CompareOrdinal(str1, str2): {string.CompareOrdinal(str1, str2)}"); // 0 (равны)
    Console.WriteLine($"string.CompareOrdinal(str1, str3): {string.CompareOrdinal(str1, str3)}"); // >0 (чувствителен к регистру)


    // Метод IndexOf()
    Console.WriteLine($"str1.IndexOf('l'): {str1.IndexOf('l')}"); // 2 (индекс первого 'l')

    // Метод Contains()
    Console.WriteLine($"str1.Contains(\"ell\"): {str1.Contains("ell")}"); // True
  }
}


