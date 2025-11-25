using Tyuiu.KlochenokVA.Sprint4.Task2.V19.Lib;

namespace Tyuiu.KlochenokVA.Sprint4.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Клоченок В. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                  *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #19                                                            *");
            Console.WriteLine("* Выполнил: Клоченок Владимир Алексеевич | ИСПб-25-1                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный       *");
            Console.WriteLine("* случайными в диапазоне от 4 до 9 подсчитать сумму нечетных элементов *");
            Console.WriteLine("* массива.                                                              *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int len = 14;
            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(4, 10);
            }

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Сумма нечетных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}