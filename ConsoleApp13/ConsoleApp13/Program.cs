using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите дату в формате 'yyyy-MM-dd': ");
        string inputDate1 = Console.ReadLine();
        try
        {
            DateOnly parsedDate1 = DateOnly.Parse(inputDate1); 
            Console.WriteLine($"Parsed date (Parse): {parsedDate1}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный формат даты для Parse().");
        }
        Console.WriteLine("Введите дату в формате 'dd/MM/yyyy': ");
        string inputDate2 = Console.ReadLine();
        try
        {
            DateOnly parsedDate2 = DateOnly.ParseExact(inputDate2, "dd/MM/yyyy"); 
            Console.WriteLine($"Parsed date (ParseExact): {parsedDate2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный формат даты для ParseExact().");
        }

        Console.WriteLine("Введите дату в формате 'yyyy-MM-dd': ");
        string inputDate3 = Console.ReadLine();
        if (DateOnly.TryParse(inputDate3, out DateOnly parsedDate3))
        {
            Console.WriteLine($"Parsed date (TryParse): {parsedDate3}");
        }
        else
        {
            Console.WriteLine("Неверный формат даты для TryParse().");
        }
        Console.WriteLine("Введите дату в формате 'dd/MM/yyyy': ");
        string inputDate4 = Console.ReadLine();
        if (DateOnly.TryParseExact(inputDate4, "dd/MM/yyyy", out DateOnly parsedDate4)) 
        {
            Console.WriteLine($"Parsed date (TryParseExact): {parsedDate4}");
        }
        else
        {
            Console.WriteLine("Неверный формат даты для TryParseExact().");
        }
    }
}

