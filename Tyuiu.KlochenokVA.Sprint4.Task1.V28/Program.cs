using Tyuiu.KlochenokVA.Sprint4.Task1.V28.Lib;

namespace Tyuiu.KlochenokVA.Sprint4.Task1.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Клоченок В. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Одномерные массивы (пользовательский ввод)                      *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #28                                                            *");
            Console.WriteLine("* Выполнил: Клоченок Владимир Алексеевич | ИСПб-25-1                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный       *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 6. Подсчитать             *");
            Console.WriteLine("* произведение нечетных элементов массива.                              *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int len = 14;
            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Произведение нечетных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}
