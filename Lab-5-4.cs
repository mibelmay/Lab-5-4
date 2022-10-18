using System;
using System.Collections.Generic;

namespace Labs
{
    public static class Program
    {
        public static void Main()
        {
            string[] numbers = GetArray();
        }

        public static string[] GetArray()
        {
            List<string> numbers = new List<string>();
            Console.WriteLine("Введите массив. Чтобы закончить ввод, введите букву q");

            while (true)
            {
                string input = Console.ReadLine();
                if (!(input == "q"))
                    numbers.Add(input);
            }


        }
    }
}