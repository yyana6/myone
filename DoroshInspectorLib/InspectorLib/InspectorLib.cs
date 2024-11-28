using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InspectorLib
{
    public class FunctionInsp

    {
        private const string InspectionName = "Автоинспекция г. Чита";
        private string chiefInspector = "Васильев Василий Иванович";
        private List<string> workers = new List<string>
        {
            "Иванов И.И.",
            "Зиронов Т.А.",
            "Миронов А.В.",
            "Васильев В.И."
        };

        public string GetInspector()
        {
            return chiefInspector;
        }

        public string GetCarInspection()
        {
            return InspectionName;
        }

        public void SetInspector(string fullname)
        {
            if (workers.Contains(fullname))
            {
                chiefInspector = fullname;
            }
            else
            {
                throw new ArgumentException("ФИО не найдено в списке сотрудников.");
            }
        }

        public string GenerateNumber(string number, char symbol, string code)
        {
            if (!char.IsUpper(symbol) || symbol.ToString().Length != 1)
            {
                throw new ArgumentException("Символ должен быть одной заглавной буквой.");
            }

            return $"{symbol}{number}_{code}";
        }

        public List<string> GetWorker()
        {
            return new List<string>(workers);
        }

        public void AddWorker(string fullname)
        {
            if (!workers.Contains(fullname))
            {
                workers.Add(fullname);
            }
            else
            {
                throw new ArgumentException("Сотрудник уже существует.");
            }
        }
    }

 }
    
