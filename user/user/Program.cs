using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            { Name="Екатерина",
               Familia="Петрова",
               Login = "null",
               password="null"

            };
            Console.WriteLine(user.Name);
            Console.WriteLine("Введите имя:");
            user.Name=  Console.ReadLine();
            Console.WriteLine($"Ваше имя:"+user.Name);
            Console.WriteLine(user.Familia);
            Console.WriteLine("Введите фамилию:");
            user.Familia = Console.ReadLine();
            Console.WriteLine($"Ваше имя:" + user.Familia);
            Console.WriteLine(user.city);
            Console.WriteLine("Введите ваш город:");
            user.city = Console.ReadLine();
            Console.WriteLine($"Ваш город:" + user.city);

            Console.ReadLine();
        }
    }
    class User
    {
       public string Name;
       public string Familia;
       public string city;
       public string Login;
       public string password;
        public void Autohize(string login, string password)
        {
            if (login == Login)
            {
                Console.WriteLine("Вы успешно вошли в систему");
            }
            else
            {
                Console.WriteLine("Пароль не верный");
            }
        }
    }
}
