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
            List<string> list = new List<string>();
            Console.WriteLine("Введите массив. Чтобы закончить ввод, введите букву q");

            bool flag = true;
            while (flag)
            {
                string input = Console.ReadLine();
                if (input != "q")
                    list.Add(input);
                else flag = false;
            }

            string[] result = list.ToArray();
            return result;

        }
    }
}