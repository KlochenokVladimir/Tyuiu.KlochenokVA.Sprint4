using Tyuiu.KlochenokVA.Sprint4.Task5.V11.Lib;

namespace Tyuiu.KlochenokVA.Sprint4.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[5, 5] { { -7, -3, 0, 1, 2 },
                                          { -5, -2, -1, 0, 1 },
                                          { -4, -6, 2, -3, 0 },
                                          { 1, -7, -2, 2, -1 },
                                          { 0, -5, 1, -4, 2 } };

            int[,] res = ds.Calculate(mtrx);

            int[,] wait = new int[5, 5] { { -7, -3, 0, 1, 1 },
                                          { -5, -2, -1, 0, 1 },
                                          { -4, -6, 1, -3, 0 },
                                          { 1, -7, -2, 1, -1 },
                                          { 0, -5, 1, -4, 1 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}