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

            Console.Write("When is your birthday? ");
            string birthday = Console.ReadLine();
            Console.WriteLine($"Your birthday: {birthday}");

            Console.ReadLine();
        }
    }
}
