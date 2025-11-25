using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KlochenokVA.Sprint4.Task3.V30.Lib
{
    public class DataService : ISprint4Task3V30
    {
        public int Calculate(int[,] array)
        {
            int max = array[2, 0];
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[2, j] > max)
                {
                    max = array[2, j];
                }
            }
            return max;
        }
    }
}