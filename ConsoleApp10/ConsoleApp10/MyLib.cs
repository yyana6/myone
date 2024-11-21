using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Calculator
    {
        public void PrintSum(int a, int b)
        {
            Console.WriteLine($"Сумма {a} + {b} = {a + b}");
        }

        public void PrintDifference(int a, int b)
        {
            Console.WriteLine($"Разность {a} - {b} = {a - b}");
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно!");
            }
            return a / b;
        }

        public string GetResultAsString(int a, int b)
        {
            return $"Результат: {a + b}";
        }
    }
}
