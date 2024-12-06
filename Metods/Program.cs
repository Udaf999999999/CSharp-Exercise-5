namespace Metods
{
    internal class Program
    {
        int val = 8;
        static string GetColor(string username, int userage)
        {
            Console.WriteLine("{0}, {1} лет\nНапишите свой любимый цвет", username, userage);
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
        static void ShowColors(string username, params string[] favcolors)
        {
            Console.WriteLine(username, ", Ваши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }
        static void SortComplexArray(int[,] arr)
        {
            int temp;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                        if (arr[i, j] > arr[i, k])
                        {
                            temp = arr[i, k];
                            arr[i, k] = arr[i, j];
                            arr[i, j] = temp;
                        }
            }
        }
        public int SumNumbers(ref int num1, in int num2, out int num3, int num4)
        {
            num1 = 5;
            num3 = num1 + num2;
            return 3;
        }
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
        static void SortArray(in int[] array, out int[] arrayDiscend, out int[] arrayAscend)
        {
            arrayDiscend = SortArrayDesc(array);
            arrayAscend = SortArrayAsc(array);
        }
        public static int[] SortArrayDesc(in int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
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
        public static int[] SortArrayAsc(in int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        static void ShowArray(int[] array, bool isSorted = false)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
        static void GetName(string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }
        static void ChangeName(string name)
        {
            name = "ds";
        }
        static void ChangeAge(int age)
        {
            age = 10;
        }
        static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            Console.WriteLine("..." + modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
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

            //(string name, int age) anketa;

            //Console.Write("Введите имя: ");
            //anketa.name = Console.ReadLine();
            //Console.Write("Введите возраст с цифрами: ");
            //anketa.age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ваше имя: {0}", anketa.name);
            //Console.WriteLine("Ваш возраст: {0}", anketa.age);

            //var favoriteColor = new string[3];

            //for (int i = 0; i < favoriteColor.Length; i++)
            //{
            //    favoriteColor[i] = GetColor(anketa.name, anketa.age);
            //}
            //ShowColors(anketa.name, favoriteColor);

            //int[,] arr =
            //{
            //    { - 5, 6, 9, 1, 2, -3},
            //    { - 8, 8, 1, 1, 2, -3}
            //};

            //SortComplexArray(arr);
            //int lenght = 5;
            ////var arr = GetArrayFromConsole(lenght);
            //int[] arr = { -5, 6, 9, 1, 2, -3 };
            //int[] disc;
            //int[] asce;
            //SortArray(arr,out disc,out asce);
            ////int[] arr = { 3, 6, -2, 5 };
            //ShowArray(arr, true);
            //Console.WriteLine();
            //ShowArray(disc, true);
            //Console.WriteLine();
            //ShowArray(asce, false);

            var str = "string";

            var deep = 3;

            Echo(str, deep);

        }
    }
}
