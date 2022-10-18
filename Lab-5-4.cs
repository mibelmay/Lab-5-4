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
            foreach (string number in newNumbers)
                Console.Write($"{number} ");
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
            List<string> newList = numbers.ToList();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.TryParse(numbers[i], out int intNumber))
                {
                    if (intNumber > 0)
                        newList[i] = GetFactorial(intNumber).ToString();
                }
            }
            return newList.ToArray();
        }

        public static int GetFactorial(int num)
        {
            int factorial = 1;
            for (int i = 2; i <= num; i++)
                factorial *= i;
            return factorial;
        }
    }
}