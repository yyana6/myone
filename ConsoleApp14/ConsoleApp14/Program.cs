using System;

//class Program
//{
//    static void Main()
//    { //задание 1
//        int[] i = { 5, 2, 9, 1, 5 };
//        int[] j = { 3, 8, 7, 4 };

//        Console.WriteLine("Массив i: " + string.Join(", ", i));
//        Console.WriteLine("Массив j: " + string.Join(", ", j));

//        SortAscending(i);
//        Console.WriteLine("Отсортированный массив по возрастанию: " + string.Join(", ", i));
//        SortDescending(j);
//        Console.WriteLine("Отсортированный массив по убыванию: " + string.Join(", ", j));
//        int[] mergedArray = MergeArrays(i, j);
//        Console.WriteLine("Объединенный массив: " + string.Join(", ", mergedArray));
//    }

//    static void SortAscending(int[] array)
//    {
//        Array.Sort(array);
//    }

//    static void SortDescending(int[] array)
//    {
//        Array.Sort(array);
//        Array.Reverse(array);
//    }

//    static int[] MergeArrays(int[] i, int[] j)
//    {
//        int[] mergedArray = new int[i.Length + j.Length];
//        Array.Copy(i, mergedArray, i.Length);
//        Array.Copy(i, 0, mergedArray, i.Length, j.Length);
//        return mergedArray;

//    }
//}


class Prograamm2
{ //Задание 2
    static void Main()
    {
        Console.Write("Введите целое число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int absoluteDifference = Math.Abs(n - 123);

        if (n > 123)
        {
            Console.WriteLine("Результат: " + (3 * absoluteDifference));
        }
        else
        {
            Console.WriteLine("Результат: " + absoluteDifference);
        }
    }
}

