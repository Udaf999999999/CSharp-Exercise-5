﻿namespace Metods
{
    internal class Program
    {
        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
        static int[] SortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        static void ShowArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            //(string Name, string[] Dishes) user;
            //Console.WriteLine("Enter your name:");
            //user.Name = Console.ReadLine();

            //user.Dishes = new string[5];

            //for (int i = 0; i < user.Dishes.Length; i++)
            //{
            //    Console.WriteLine("Write your " + (i + 1) + " favorite dish.");
            //    user.Dishes[i] = Console.ReadLine();
            //}

            var array = GetArrayFromConsole();
            array = SortArray(array);

            ShowArray(array);
            array = GetArrayFromConsole();
        }
    }
}
