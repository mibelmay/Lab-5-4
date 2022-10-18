using System;
using System.Collections.Generic;

namespace Labs
{
    public static class Program
    {
        public static void Main()
        {
            string[] numbers = GetArray();
            string[] newNumbers = ChangeArray(numbers);
        }

        public static string[] GetArray()
        {
            List<string> list = new List<string>();
            Console.WriteLine("Введите массив чисел. Чтобы закончить ввод, введите букву q");

            bool flag = true;
            while (flag)
            {
                string input = Console.ReadLine();
                if (input != "q") list.Add(input);
                else flag = false;
            }

            return list.ToArray();
        }

        public static string[] ChangeArray(string[] numbers)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                if (int.TryParse(numbers[i], out int intNumber))
                {
                    if (intNumber > 0)
                        list[i] = GetFactorial(intNumber).ToString();
                }
            }
        }

        public static int GetFactorial(int num)
        {

        }
    }
}