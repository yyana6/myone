using System;
public class One
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        string oneInput = Console.ReadLine();
        Console.WriteLine("Введите второе число:");
        string twoInput = Console.ReadLine();
        try
        {
            int one = int.Parse(oneInput);
            int two = int.Parse(twoInput);
            int result = one / two;
            Console.WriteLine($"Результат:{result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: делить на ноль запрещено!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: неверный формат ввода. Введите целые числа.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла непредвиденная ошибка. {ex.Message}");
        }
    }
}