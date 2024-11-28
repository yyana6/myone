using System;
using InspectorLib;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp insp = new FunctionInsp();

            //ФИО главного инспектора
            Console.WriteLine("Главный инспектор: " + insp.GetInspector());

            // название автоинспекции
            Console.WriteLine("Название автоинспекции: " + insp.GetCarInspection());

            // список сотрудников
            Console.WriteLine("Сотрудники:");
            foreach (var worker in insp.GetWorker())
            {
                Console.WriteLine(worker);
            }

            // Изменяем ФИО главного инспектора
            insp.SetInspector("Иванов И.И.");
            Console.WriteLine("Новый главный инспектор: " + insp.GetInspector());

            // Генерируем номер
            string carNumber = insp.GenerateNumber("1234", 'A', "75");
            Console.WriteLine("Сгенерированный номер: " + carNumber);

            // Добавляем нового сотрудника
            insp.AddWorker("Петров П.П.");
            Console.WriteLine("Сотрудники после добавления:");
            foreach (var worker in insp.GetWorker())
            {
                Console.WriteLine(worker);
            }
        }
    }
 }

