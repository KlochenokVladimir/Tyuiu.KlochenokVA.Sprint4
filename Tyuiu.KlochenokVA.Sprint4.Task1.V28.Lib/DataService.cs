using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KlochenokVA.Sprint4.Task1.V28.Lib
{
    public class DataService : ISprint4Task1V28
    {
        public int Calculate(int[] array)
        {
            int mult = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 1)
                {
                    mult = mult * array[i];
                }
            }
            return mult;
        }
    }
}
