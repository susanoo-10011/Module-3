using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итоговое_задание_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine($"Your name is {name} and age is {age}.");

            Console.Write("What is your favorite day of week?  ");
            DayOfWeek day = (DayOfWeek)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your favorite day is {day}");

            Console.Write("Enter your birthdate (dd.MM.yyyy): ");

            DateTime birthdate;
            //пошаманил с ChatGPT. DateTime - это структура (structure) встроенного в .NET языка C#.
            //Она предоставляет методы и свойства для работы с датами и временем в формате григорианского календаря.
            while (true) // проверяет корректность введенных данных.
            {
                if (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out birthdate))
                // Метод DateTime.TryParseExact() позволяет преобразовать строку, содержащую дату и время в указанном формате, в объект DateTime
                    Console.WriteLine("You entered an incorrect date. Please try again: ");
                else
                {
                    Console.WriteLine($"Your birthdate is {birthdate.ToShortDateString()}");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
