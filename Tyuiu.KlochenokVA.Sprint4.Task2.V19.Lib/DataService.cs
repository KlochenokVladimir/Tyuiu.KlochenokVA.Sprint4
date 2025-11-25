using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KlochenokVA.Sprint4.Task2.V19.Lib
{
    public class DataService : ISprint4Task2V19
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 1)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
