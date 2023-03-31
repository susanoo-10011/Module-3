using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork._3._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Egor";
            byte MyAge = 19;
            bool HaveIApet = false;
            double MyShoeSize = 41.5;

            Console.WriteLine($"My name is {MyName}");
            Console.WriteLine($"MyAge {MyAge}");
            Console.WriteLine($"Do I have a pet? {HaveIApet}");
            Console.WriteLine($"My shoe size is {MyShoeSize}");

            Console.ReadKey();
        }
    }
}
